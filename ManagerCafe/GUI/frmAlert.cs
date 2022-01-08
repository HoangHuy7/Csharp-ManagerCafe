
using ManagerCafe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCafe.GUI
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();

        }
        public enum enmAction
        {
            wait,
            close,
            start
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        bool YesNo = false;
        private frmAlert.enmAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 1000;
                    action = enmAction.close;
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void showYesNO(string msg, enmType type, ref bool result)
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            pictureBox1.Visible = false;
            btnNo.Visible = true;
            btnYes.Visible = true;
            this.Size = new Size(291, 113);
            btnYes.Image = Resources.ok;
            btnNo.Image = Resources.cancel_32px;
            lblContent.Text = msg;

            pictureBox1.Location = new Point(90, 12);
            switch (type)
            {
                case enmType.Success:
                    this.BackColor = Color.Black;
                    break;
                case enmType.Error:
                    this.BackColor = Color.Black;
                    break;
                case enmType.Info:
                    this.BackColor = Color.Black;
                    break;
                case enmType.Warning:
                    this.BackColor = Color.Black;
                    break;
            }


            this.ShowDialog();
            if (YesNo)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            YesNo = true;
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            YesNo = false;
            this.Close();
        }

        public void showNoti(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            btnNo.Visible = false;
            btnYes.Visible = false;
            btnYes.Image = Resources.ok;
            pictureBox1.Visible = true;
            this.Size = new Size(291, 72);
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "Noti" + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 5;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.ok;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.sad3;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning3;
                    this.BackColor = Color.DarkOrange;
                    break;
            }
            this.lblContent.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }

    }
}

