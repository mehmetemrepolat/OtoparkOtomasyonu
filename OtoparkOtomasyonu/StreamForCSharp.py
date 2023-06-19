from flask import Flask, render_template, Response
import cv2
import pytesseract
import re
import imutils
import numpy as np
import socket
import time
import threading



class VideoStreamerWebCam:


    def fix_plate_text(self, irregular_plate):
        # Adım 1: Sayı ve büyük harf haricindeki karakterleri çıkar
        cleaned_text = re.sub(r'[^A-Z0-9\s]', '', irregular_plate)
        # Adım 2: Türkiye plaka kodlamasına uygun plaka var mı kontrolünü gerçekleştir
        plaka_kodu = re.findall(r'[0-9]{2}\s[A-Z]{1,4}\s[0-9]{2,4}', cleaned_text)
        if plaka_kodu:
            # Bulunan plaka kodu haricindeki karakterleri sil
            cleaned_plaka_kodu = plaka_kodu[0]
        else:
            return None
        return cleaned_plaka_kodu

    @staticmethod
    def send_plate_to_front(self, plate):
        if plate is not None:
            try:
                client_socket_front = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
                client_socket_front.connect(("localhost", 1234))
                client_socket_front.send(plate.encode())
                time.sleep(0.1)
                client_socket_front.close()
                print(plate)
            except Exception as e:
                print("send_plate_to_front Error:", str(e))

    @staticmethod
    def send_plate_to_rear(self, plate):
        if plate is not None:
            try:
                client_socket_rear = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
                client_socket_rear.connect(("localhost", 1235))
                client_socket_rear.send(plate.encode())
                time.sleep(0.1)  # İstemci mesajı gönderdikten sonra bir bekleme süresi eklendi
                client_socket_rear.close()
            except:
                print("Hata; Çıkış Kamerası Sunucu Hatası!")



    def plateRecognize(self, img, camera):
        pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files\Tesseract-OCR\tesseract'
        img = cv2.resize(img, (800, 500))
        gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        gray = cv2.bilateralFilter(gray, 13, 75, 75)
        cany = cv2.Canny(gray, 30, 200)
        contours = cv2.findContours(cany.copy(), cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
        contours = imutils.grab_contours(contours)
        contours = sorted(contours, key=cv2.contourArea, reverse=True)[:10]
        screenCnt = None
        for c in contours:
            _ = cv2.arcLength(c, True)
            approx = cv2.approxPolyDP(c, 0.018 * _, True)
            if len(approx) == 4:
                screenCnt = approx
                break
        if screenCnt is not None:
            cv2.drawContours(img, [screenCnt], -1, (0, 0, 255), 3)
            mask = np.zeros(gray.shape, np.uint8)
            new_image = cv2.drawContours(mask, [screenCnt], 0, 255, -1)
            new_image = cv2.bitwise_and(img, img, mask=mask)
            (x, y) = np.where(mask == 255)
            (tx, ty) = (np.min(x), np.min(y))
            (bx, by) = (np.max(x), np.max(y))
            Cropped = gray[tx:bx + 1, ty:by + 1]
            custom_config = r'-l eng --psm 6'
            text = pytesseract.image_to_string(Cropped, config=custom_config)
            plateNoFix = text.replace("\n", "")
            plateNoFix2 = plateNoFix.replace("\f", "")
            plateNoFix3 = plateNoFix2.strip("#")
            resultPlateText = re.sub('[()"{}<>!-.]', '', plateNoFix3)
            clean_plate = self.fix_plate_text(resultPlateText)

            if camera == "front":
                self.send_plate_to_front(self, clean_plate)

            elif camera == "rear":
                self.send_plate_to_rear(self, clean_plate)
            else:
                print("Hata mesaj gönderilemiyor!")

            return None


    def __init__(self, video_source1, video_source2):
        self.camera1 = cv2.VideoCapture(video_source1)
        self.camera2 = cv2.VideoCapture(video_source2)



    def gen_frames1(self):
        while True:
            success, frame = self.camera1.read()
            if not success:
                break
            else:
                camera_index = "front"
                front_plate_thread = threading.Thread(target=self.plateRecognize, args=(frame, camera_index))
                front_plate_thread.start()
                ret, buffer = cv2.imencode('.jpg', frame)
                frame = buffer.tobytes()
                yield (b'--frame\r\n'
                       b'Content-Type: image/jpeg\r\n\r\n' + frame + b'\r\n')

    def gen_frames2(self):
        while True:
            success, frame = self.camera2.read()
            if not success:
                break
            else:
                # self.plateRecognize(frame, "rear")

                camera_index = "rear"
                rear_plate_thread = threading.Thread(target=self.plateRecognize, args=(frame, camera_index))
                rear_plate_thread.start()

                # self.send_plate_to_rear(plate_text_rear)  # 1235
                # print(f"Arka taraf:{plate_text_rear}")
                ret, buffer = cv2.imencode('.jpg', frame)
                frame = buffer.tobytes()
                yield (b'--frame\r\n'
                       b'Content-Type: image/jpeg\r\n\r\n' + frame + b'\r\n')

    def run(self):
        app = Flask("__main__")

        @app.route('/')
        def index():
            return render_template("index.html")

        @app.route('/video_feed1')
        def video_feed1():
            return Response(self.gen_frames1(), mimetype='multipart/x-mixed-replace; boundary=frame')

        @app.route('/video_feed2')
        def video_feed2():
            return Response(self.gen_frames2(), mimetype='multipart/x-mixed-replace; boundary=frame')

        app.run(host='127.0.0.1', port=8000, debug=True, threaded=True)


video_source1 = 0
video_source2 = 'rtsp://admin:admin@192.168.1.108:554/cam/realmonitor?channel=1&subtype=1'

streamerWebCam = VideoStreamerWebCam(video_source1, video_source2)
streamerWebCam.run()
