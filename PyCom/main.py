import os
import win32com.client as COM
from ctypes import *


def use_com():
    os.system("regsvr32 /s deps/PuenteCom.comhost.dll")

    try:
        puente = COM.Dispatch("PuenteCom.Server")

        print(puente)
    except Exception as ex:
        print(ex)

    os.system("regsvr32 /s /u deps/PuenteCom.comhost.dll")


def use_aot():
    puente = windll.LoadLibrary("deps/PuenteAot.dll")
    result = puente.addNumbers(3, 7)
    print(result)


if __name__ == '__main__':
    use_com()
    use_aot()
