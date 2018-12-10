# -*- coding: utf-8 -*-
import win32gui
import datetime
import os
import time
import io

global files_name
global files_handle
files_handle = {}

def EnumWindowsHandler(hwnd, extra):
    wintext = win32gui.GetWindowText(hwnd)
    files_handle[wintext] = hwnd

def allfiles(path):
    files_name = {}

    for root, dirs, files in os.walk(path):
        rootpath = os.path.join(os.path.abspath(path), root)

        for file in files:
            filepath = os.path.join(rootpath, file)
            files_name[file] = filepath

    return files_name

def write(path, data):
    t = str(datetime.datetime.now())
    f = io.open("log/"+path+".txt", mode="a", encoding="utf-8-sig")
    f.write(data+"    "+str(t)+"\n")
    f.close()

if __name__ == '__main__':
    try:
        os.mkdir(os.getcwd() +'/log')
    except:
        pass
    f = io.open("path.txt", mode="r", encoding="utf-8-sig")
    path = f.read()
    f.close()

    while True:
        win32gui.EnumWindows(EnumWindowsHandler, None)
        files = allfiles(path)

        for file_handle in files_handle:
            try:
                temp = file_handle.split(' - ')
                if temp[0] in files:
                    write(temp[0], temp[1])
                else:
                    for file in files:
                        if file.split('.')[0] == temp[0]:
                            write(temp[0], temp[1])
            except:
                pass
        files_handle = {};
        time.sleep(1)