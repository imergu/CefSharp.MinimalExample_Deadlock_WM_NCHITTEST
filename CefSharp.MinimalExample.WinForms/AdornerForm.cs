using System;
using System.Drawing;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class AdornerForm : Form
    {
        private const int WM_NCHITTEST = 132;
        private const int HTTRANSPARENT = -1;

        public AdornerForm()
        {
            Opacity = 0.8;
            TopMost = true;
            Controls.Add(new Label()
            {
                Text = "Click on the ChromiumWebBrowser control through this form a few times to freeze the application.",
                Dock = DockStyle.Fill,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = new IntPtr(HTTRANSPARENT);
                return;
            }
            base.WndProc(ref m);
        }
    }
}
