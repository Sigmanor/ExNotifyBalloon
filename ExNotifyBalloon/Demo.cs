using ExNotifyBalloon.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExNotifyBalloon
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            cbxIcon.SelectedIndex = 0;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            Bitmap icon = null;
            switch (cbxIcon.Text)
            {
                case
                    "Warning":
                    icon = Resources.warning;
                    break;
                case
                    "Error":
                    icon = Resources.error;
                    break;
                case
                    "Info":
                    icon = Resources.info;
                    break;
            }

            try
            {
                var notification = new ExNotifyBalloon(icon, txtTitle.Text, txtBody.Text, Convert.ToInt32(txtTimeout.Text));
                notification.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

    }
}
