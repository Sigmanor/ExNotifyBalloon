using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExNotifyBalloon.Properties;

namespace ExNotifyBalloon
{
    public partial class ExNotifyBalloon : Form
    {
        private const int WM_MOUSEACTIVATE = 0x0021, MA_NOACTIVATE = 0x0003;
        private static readonly List<ExNotifyBalloon> OpenNotifications = new List<ExNotifyBalloon>();
        const int WS_EX_NOACTIVATE = 0x08000000;
        const int WS_EX_TOPMOST = 0x00000008;
        private bool stopFadeOut;

        public ExNotifyBalloon(Bitmap notifyIcon, string notifyTitle, string notifyBody, int notifyTimeout)
        {
            InitializeComponent();
            System.Media.SoundPlayer notifySound = new System.Media.SoundPlayer(Resources.normal);
            notifySound.Play();
            pictureBoxIcon.Image = notifyIcon;
            labelTitle.Text = notifyTitle;
            labelBody.Text = notifyBody;
            labelApp.Text = Assembly.GetExecutingAssembly().GetName().Name;
            notifyTimer.Interval = notifyTimeout;
            notifyTimer.Start();
        }
        public new void Show()
        {
            base.Show();
            FadeIn(this, 20);
        }
        public void CloseNotify()
        {
            stopFadeOut = false;
            notifyTimer.Stop();
            Close();
        }


        #region WinApi
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEACTIVATE)
            {
                m.Result = (IntPtr)MA_NOACTIVATE;
                return;
            }
            base.WndProc(ref m);
        }
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= WS_EX_TOPMOST; 
                param.ExStyle |= WS_EX_NOACTIVATE;
                return param;
            }
        }
        #endregion


        #region Animations
        private async void FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1;
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            while (o.Opacity > 0.0)
            {
                if (stopFadeOut)
                {
                    return;
                }
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0;
            Close();
        }
        #endregion


        #region Event Handlers
        private void ExNotifyBalloon_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 20,
                                    Screen.PrimaryScreen.WorkingArea.Height - Height - 20);
            foreach (ExNotifyBalloon openForm in OpenNotifications)
            {
                openForm.Top -= Height;
            }

            OpenNotifications.Add(this);

            if (labelBody.PreferredWidth > labelBody.Width)
            {
                labelTitle.Location = new Point(77,8);
                labelBody.Location = new Point(78, 32);
                labelBody.Size = new Size(262, 53);
            }
        }
        private void ExNotifyBalloon_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (ExNotifyBalloon openForm in OpenNotifications)
            {
                if (openForm == this)
                {
                    break;
                }
                openForm.Top += Height;
            }

            OpenNotifications.Remove(this);
        }
        private void NotifyTimer_Tick(object sender, EventArgs e)
        {
            stopFadeOut = false;
            FadeOut(this, 40);
            notifyTimer.Stop();
        }

        private void PictureBoxIcon_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void ExNotifyBalloon_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void LabelTitle_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void LabelBody_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void LabelApp_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void Panel1_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void LabelClose_Click(object sender, EventArgs e)
        {
            CloseNotify();
        }
        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.DarkGray;
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.DimGray;
        }

        private void PictureBoxIcon_MouseEnter(object sender, EventArgs e)
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        private void LabelTitle_MouseEnter(object sender, EventArgs e)
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        private void LabelBody_MouseEnter(object sender, EventArgs e)
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        private void LabelApp_MouseEnter(object sender, EventArgs e)
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            notifyTimer.Start();
            stopFadeOut = false;
        }
        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }
        #endregion


    }
}
