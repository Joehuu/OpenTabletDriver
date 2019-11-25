﻿namespace NativeLib.Windows.Input
{
    public enum MOUSEEVENTF : uint
    {
        LEFTDOWN = 0x0002,
        LEFTUP = 0x0004,
        MIDDLEDOWN = 0x0020,
        MIDDLEUP = 0x0040,
        RIGHTDOWN = 0x0008,
        RIGHTUP = 0x0010,
        XDOWN = 0x0080,
        XUP = 0x0100
    }
}