# -*- coding: euc-kr -*-

import win32gui
import datetime
import os
import time
import io
import cv2

global files_name
global files_handle

def EnumWindowsHandler(hwnd, extra):
    wintext = win32gui.GetWindowText(hwnd)
    files_handle[wintext] = hwnd

def allfiles(path):

    for root, dirs, files in os.walk(path):
        rootpath = os.path.join(os.path.abspath(path), root)

        for file in files:
            filepath = os.path.join(rootpath, file)
            files_name[file] = filepath

    return files_name

def write(path, data):
    t = str(datetime.datetime.now())
    f = io.open("log/"+path+".txt", mode="a", encoding="utf-8")
    f.write(data+"    "+str(t)+"\n")
    f.close()

def takepic(path):
    cap = cv2.VideoCapture(0)
    cap.set(3, 640)
    cap.set(4, 480)
    _, frame = cap.read()
    cap.release()
    cv2.imwrite('pic/' + path + '.jpg', frame)

if __name__ == '__main__':
    try:
        os.mkdir(os.getcwd() +'/log')
        os.mkdir(os.getcwd() + '/pic')
    except:
        pass
    f = io.open("path.txt", mode="r", encoding="utf-8")
    path = f.read()
    f.close()

    while True:
        files_handle = {}
        files_name = {}
        win32gui.EnumWindows(EnumWindowsHandler, None)
        files = allfiles(path)

        for file_handle in files_handle:
            try:
                temp = file_handle.split(' - ')
                if temp[0] in files:
                    write(temp[0], temp[1])
                    takepic(temp[0])
                else:
                    for file in files:
                        if file.split('.')[0] == temp[0]:
                            write(temp[0], temp[1])
                            takepic(temp[0])
            except:
                pass

        time.sleep(1)

# made by PlanNoa
# https://github.com/PlanNoa

