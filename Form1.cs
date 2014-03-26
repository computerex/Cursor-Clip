using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CursorClip
{
    public partial class Form1 : Form
    {
        private IntPtr hwnd;
        private bool selection;
        public Form1()
        {
            hwnd = IntPtr.Zero;
            selection = false;
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();
        
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int ClipCursor(IntPtr rect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int ClipCursor(ref RECT rect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int IsWindow(IntPtr hWnd);

        private void btntarget_Click(object sender, EventArgs e)
        {
            selection = true;
        }
        private void togglestate()
        {
            if (IsWindow(hwnd) != 0)
            {
                SetForegroundWindow(hwnd);
                RECT rect = new RECT();
                GetWindowRect(hwnd, ref rect);
                ClipCursor(ref rect);
            }
            else
            {
                MessageBox.Show("error, invalid window selected");
            }
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (selection)
            {
                hwnd = GetForegroundWindow();
                StringBuilder wnd = new StringBuilder(255);
                GetWindowText(hwnd, wnd, 255);
                label1.Text = wnd.ToString();
                selection = false;
            }
        }

        private void btntoggle_Click(object sender, EventArgs e)
        {
            togglestate();
        }
    }
}
