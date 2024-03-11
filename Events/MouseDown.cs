using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ISBGroup.Events
{
    internal static class MouseDown
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static IntPtr Handle { get; set; }
        /// <summary>
        /// Передвижение формы при зажатии кнопкой мыши
        /// </summary>
        /// <param name="handle"></param>
        public static void MouseOffset(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
