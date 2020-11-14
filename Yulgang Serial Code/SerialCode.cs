using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Yulgang_Serial_Code
{
    public class SerialCode
    {
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        private readonly InputSimulator _input;
        private readonly IntPtr _hWnd;
        private readonly int _screenWidth;
        private readonly int _screenHeight;

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        public struct GameWindow
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static List<GameWindow> GameWindowList()
        {
            List<GameWindow> list = new List<GameWindow>
            {
                new GameWindow() { Width = 1600, Height = 900, X = 1161, Y = 500 },
                new GameWindow() { Width = 1360, Height = 768, X = 1010, Y = 480 },
                new GameWindow() { Width = 1024, Height = 768, X = 795, Y = 480 },
                new GameWindow() { Width = 800, Height = 600, X = 653, Y = 380 }
            };

            return list;
        }

        public SerialCode(IntPtr hWnd)
        {
            _hWnd = hWnd;
            _screenWidth = Screen.PrimaryScreen.Bounds.Width;
            _screenHeight = Screen.PrimaryScreen.Bounds.Height;
            _input = new InputSimulator();
        }

        public void NpcSelection()
        {
            //Send key
            _input.Keyboard.KeyPress(VirtualKeyCode.MBUTTON);
        }

        public void OpenWindow(GameWindow gameWindow)
        {
            MovePointer(_hWnd, gameWindow.X, gameWindow.Y);
            _input.Mouse.LeftButtonClick();
        }

        public void Code(String code)
        {
            _input.Keyboard.TextEntry(code);
        }

        public void Enter()
        {
            _input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        private Rect FindPosition(IntPtr handleWindow)
        {
            Rect windowRect = new Rect();
            GetWindowRect(handleWindow, ref windowRect);

            return windowRect;
        }

        public void MovePointer(IntPtr handleWindow, int x, int y)
        {
            SetForegroundWindow(handleWindow);
            var windowRect = FindPosition(handleWindow);

            x = ( windowRect.Left + x ) * 65535 / _screenWidth;
            y = ( windowRect.Top + y ) * 65535 / _screenHeight;

            _input.Mouse.MoveMouseTo(x, y);
        }
    }
}