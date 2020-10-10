using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Attendance_Management_System
{
    public partial class AlertShow : Form
    {


        bool rstCl;
        public static bool okPressed = false,
             cancelPressed = false,
             yesPressed=false,
             noPressed=false,
             formCancelled=false;
        public AlertShow(string message, AlertType type,ButtonType btnType=ButtonType.OK, string caption = "",bool rqstCl=false)
        {
            InitializeComponent();
         
            this.TopMost = true;
            rstCl = rqstCl;
            switch (type)
            {
                case AlertType.success:
                    if (caption == "")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    msgLabel.Text = message;
                    msgLabel.BackColor=this.BackColor = Color.FromArgb(38, 121, 81);
                    pictureBox1.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    if (caption == "")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    msgLabel.Text = message;
                    msgLabel.BackColor= this.BackColor = Color.FromArgb(212, 24, 16);
                    pictureBox1.Image = imageList1.Images[3];
                    break;
                case AlertType.warning:
                    if (caption == "")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    msgLabel.Text = message;
                    msgLabel.BackColor=this.BackColor = Color.FromArgb(255, 128, 0);
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case AlertType.information:
                    if (caption == "")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    msgLabel.Text = message;
                    msgLabel.BackColor=this.BackColor = Color.FromArgb(0, 120, 215);
                    pictureBox1.Image = imageList1.Images[0];
                    break;

            }
            switch (btnType)
            {
                case ButtonType.OK:
                    //// codes...
                    okPanel.Visible = true;
                    break;
                case ButtonType.CANCEL:
                    //// codes...
                    cancelPanel.Visible = true;
                    break;
                case ButtonType.OK_CANCEL:
                    //// codes...
                    okPanel.Visible = true;
                    cancelPanel.Visible = true;
                    break;
                case ButtonType.YES_NO:
                    //// codes...
                    yesPanel.Visible = true;
                    noPanel.Visible = true;
                    break;
                case ButtonType.YES_NO_CANCEL:
                    //// codes...
                    yesPanel.Visible = true;
                    noPanel.Visible = true;
                    cancelPanel.Visible = true;

                    break;

            }

        }
        // enum 
        public enum AlertType
        {
            warning, information, success, error
        }
        public enum ButtonType
        {
            OK,CANCEL,OK_CANCEL,YES_NO,YES_NO_CANCEL
        }

        private void AlertShow_Load(object sender, EventArgs e)
        {
            this.Top = login.dragLimit - this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 30;

            show.Start();

        }


        private void fadeout_Tick(object sender, EventArgs e)
        {
            

            if (Opacity > 0)
            {
                this.Opacity -= .009;
                if (Opacity > 0.7)
                    this.Left -= 1;
                else
                    this.Left += 10;
            }
            else
            {
                fadeout.Stop();
                this.Close();
                login.dragLimit -= (this.Height + 1);
            }

            ////////////////////
            


        }
        int interval = 0;
        private void Show_Tick(object sender, EventArgs e)
        {
            if (this.Top < login.dragLimit - this.Height)
            {
                this.Top += interval;
                interval += 2;
            }
            else
                show.Stop();
            

        }

        private void timeoutTimer_Tick(object sender, EventArgs e)
        {
            fadeout.Start();
            timeoutTimer.Stop();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            formCancelled = true;
            fadeout.Start();
            timeoutTimer.Stop();

        }

        private void msgLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            okPressed = true;
            if (rstCl == true) {
                login.closeApplication = true;
                rstCl = false;
            }
            fadeout.Start();
            timeoutTimer.Stop();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            yesPressed = true;
            fadeout.Start();
            timeoutTimer.Stop();

        }

        private void no_Click(object sender, EventArgs e)
        {
            noPressed = true;
            fadeout.Start();
            timeoutTimer.Stop();
        }

        private void cancel_Click(object sender, EventArgs e)
        {        
            cancelPressed = true;
            fadeout.Start();
            timeoutTimer.Stop();
        }
    }
}
