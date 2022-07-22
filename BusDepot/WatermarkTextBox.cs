using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BusDepot
{
    class WatermarkTextBox : TextBox
    {
        [Localizable(true)]
        public string Watermark
        {
            get { return mWatermark; }
            set { mWatermark = value; updateWatermark(); }
        }

        private void updateWatermark()
        {
            if (this.IsHandleCreated && mWatermark != null)
            {
                SendMessage(this.Handle, 0x1501, (IntPtr)1, mWatermark);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            updateWatermark();
        }
        private string mWatermark;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
    }
}
