namespace Attendance_Management_System
{
    partial class AlertShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertShow));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeout = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.btnPanel = new System.Windows.Forms.Panel();
            this.yesPanel = new System.Windows.Forms.Panel();
            this.yes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.noPanel = new System.Windows.Forms.Panel();
            this.no = new Bunifu.Framework.UI.BunifuFlatButton();
            this.okPanel = new System.Windows.Forms.Panel();
            this.ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelPanel = new System.Windows.Forms.Panel();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.parentPanel = new System.Windows.Forms.Panel();
            this.msgLabel = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.captionLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnPanel.SuspendLayout();
            this.yesPanel.SuspendLayout();
            this.noPanel.SuspendLayout();
            this.okPanel.SuspendLayout();
            this.cancelPanel.SuspendLayout();
            this.parentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info_30px.png");
            this.imageList1.Images.SetKeyName(1, "warning_shield_32px.png");
            this.imageList1.Images.SetKeyName(2, "ok_48px.png");
            this.imageList1.Images.SetKeyName(3, "unavailable_100px.png");
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Enabled = true;
            this.timeoutTimer.Interval = 10000;
            this.timeoutTimer.Tick += new System.EventHandler(this.timeoutTimer_Tick);
            // 
            // fadeout
            // 
            this.fadeout.Interval = 10;
            this.fadeout.Tick += new System.EventHandler(this.fadeout_Tick);
            // 
            // show
            // 
            this.show.Interval = 5;
            this.show.Tick += new System.EventHandler(this.Show_Tick);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.yesPanel);
            this.btnPanel.Controls.Add(this.noPanel);
            this.btnPanel.Controls.Add(this.okPanel);
            this.btnPanel.Controls.Add(this.cancelPanel);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 99);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(500, 39);
            this.btnPanel.TabIndex = 8;
            // 
            // yesPanel
            // 
            this.yesPanel.Controls.Add(this.yes);
            this.yesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.yesPanel.Location = new System.Drawing.Point(146, 0);
            this.yesPanel.Name = "yesPanel";
            this.yesPanel.Size = new System.Drawing.Size(81, 39);
            this.yesPanel.TabIndex = 2;
            this.yesPanel.Visible = false;
            // 
            // yes
            // 
            this.yes.Activecolor = System.Drawing.Color.Transparent;
            this.yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yes.BorderRadius = 0;
            this.yes.ButtonText = "YES";
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.DisabledColor = System.Drawing.Color.Gray;
            this.yes.Iconcolor = System.Drawing.Color.Transparent;
            this.yes.Iconimage = ((System.Drawing.Image)(resources.GetObject("yes.Iconimage")));
            this.yes.Iconimage_right = null;
            this.yes.Iconimage_right_Selected = null;
            this.yes.Iconimage_Selected = null;
            this.yes.IconMarginLeft = 0;
            this.yes.IconMarginRight = 0;
            this.yes.IconRightVisible = true;
            this.yes.IconRightZoom = 0D;
            this.yes.IconVisible = false;
            this.yes.IconZoom = 90D;
            this.yes.IsTab = false;
            this.yes.Location = new System.Drawing.Point(11, 3);
            this.yes.Name = "yes";
            this.yes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.yes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(63)))), ((int)(((byte)(3)))));
            this.yes.OnHoverTextColor = System.Drawing.Color.White;
            this.yes.selected = false;
            this.yes.Size = new System.Drawing.Size(61, 31);
            this.yes.TabIndex = 0;
            this.yes.Text = "YES";
            this.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes.Textcolor = System.Drawing.Color.White;
            this.yes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // noPanel
            // 
            this.noPanel.Controls.Add(this.no);
            this.noPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.noPanel.Location = new System.Drawing.Point(227, 0);
            this.noPanel.Name = "noPanel";
            this.noPanel.Size = new System.Drawing.Size(91, 39);
            this.noPanel.TabIndex = 2;
            this.noPanel.Visible = false;
            // 
            // no
            // 
            this.no.Activecolor = System.Drawing.Color.Transparent;
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.no.BorderRadius = 0;
            this.no.ButtonText = "NO";
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.DisabledColor = System.Drawing.Color.Gray;
            this.no.Iconcolor = System.Drawing.Color.Transparent;
            this.no.Iconimage = ((System.Drawing.Image)(resources.GetObject("no.Iconimage")));
            this.no.Iconimage_right = null;
            this.no.Iconimage_right_Selected = null;
            this.no.Iconimage_Selected = null;
            this.no.IconMarginLeft = 0;
            this.no.IconMarginRight = 0;
            this.no.IconRightVisible = true;
            this.no.IconRightZoom = 0D;
            this.no.IconVisible = false;
            this.no.IconZoom = 90D;
            this.no.IsTab = false;
            this.no.Location = new System.Drawing.Point(22, 3);
            this.no.Name = "no";
            this.no.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no.OnHovercolor = System.Drawing.Color.Gray;
            this.no.OnHoverTextColor = System.Drawing.Color.White;
            this.no.selected = false;
            this.no.Size = new System.Drawing.Size(61, 31);
            this.no.TabIndex = 0;
            this.no.Text = "NO";
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.Textcolor = System.Drawing.Color.White;
            this.no.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // okPanel
            // 
            this.okPanel.Controls.Add(this.ok);
            this.okPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.okPanel.Location = new System.Drawing.Point(318, 0);
            this.okPanel.Name = "okPanel";
            this.okPanel.Size = new System.Drawing.Size(94, 39);
            this.okPanel.TabIndex = 2;
            this.okPanel.Visible = false;
            // 
            // ok
            // 
            this.ok.Activecolor = System.Drawing.Color.Transparent;
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok.BorderRadius = 0;
            this.ok.ButtonText = "OK";
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.DisabledColor = System.Drawing.Color.Gray;
            this.ok.Iconcolor = System.Drawing.Color.Transparent;
            this.ok.Iconimage = ((System.Drawing.Image)(resources.GetObject("ok.Iconimage")));
            this.ok.Iconimage_right = null;
            this.ok.Iconimage_right_Selected = null;
            this.ok.Iconimage_Selected = null;
            this.ok.IconMarginLeft = 0;
            this.ok.IconMarginRight = 0;
            this.ok.IconRightVisible = true;
            this.ok.IconRightZoom = 0D;
            this.ok.IconVisible = false;
            this.ok.IconZoom = 90D;
            this.ok.IsTab = false;
            this.ok.Location = new System.Drawing.Point(23, 3);
            this.ok.Name = "ok";
            this.ok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ok.OnHoverTextColor = System.Drawing.Color.White;
            this.ok.selected = false;
            this.ok.Size = new System.Drawing.Size(61, 31);
            this.ok.TabIndex = 0;
            this.ok.Text = "OK";
            this.ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok.Textcolor = System.Drawing.Color.White;
            this.ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancelPanel
            // 
            this.cancelPanel.Controls.Add(this.cancel);
            this.cancelPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelPanel.Location = new System.Drawing.Point(412, 0);
            this.cancelPanel.Name = "cancelPanel";
            this.cancelPanel.Size = new System.Drawing.Size(88, 39);
            this.cancelPanel.TabIndex = 2;
            this.cancelPanel.Visible = false;
            this.cancelPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cancelPanel_Paint);
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.Transparent;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(2)))), ((int)(((byte)(10)))));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "CANCEL";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel.Iconimage")));
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = false;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new System.Drawing.Point(18, 3);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(2)))), ((int)(((byte)(10)))));
            this.cancel.OnHovercolor = System.Drawing.Color.Red;
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(61, 31);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "CANCEL";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.btnPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.msgLabel);
            this.parentPanel.Controls.Add(this.btnPanel);
            this.parentPanel.Controls.Add(this.pictureBox1);
            this.parentPanel.Controls.Add(this.bunifuImageButton1);
            this.parentPanel.Controls.Add(this.captionLbl);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(500, 138);
            this.parentPanel.TabIndex = 9;
            // 
            // msgLabel
            // 
            this.msgLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(121)))), ((int)(((byte)(81)))));
            this.msgLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.ForeColor = System.Drawing.Color.White;
            this.msgLabel.Location = new System.Drawing.Point(63, 30);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.ReadOnly = true;
            this.msgLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.msgLabel.Size = new System.Drawing.Size(425, 66);
            this.msgLabel.TabIndex = 12;
            this.msgLabel.Text = "message";
            this.msgLabel.ZoomFactor = 1.101F;
            this.msgLabel.TextChanged += new System.EventHandler(this.msgLabel_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(473, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // captionLbl
            // 
            this.captionLbl.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.White;
            this.captionLbl.Location = new System.Drawing.Point(9, 2);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(119, 25);
            this.captionLbl.TabIndex = 11;
            this.captionLbl.Text = "caption";
            this.captionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = null;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AlertShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(121)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(500, 140);
            this.Controls.Add(this.parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertShow";
            this.Text = "AlertShow";
            this.Load += new System.EventHandler(this.AlertShow_Load);
            this.btnPanel.ResumeLayout(false);
            this.yesPanel.ResumeLayout(false);
            this.noPanel.ResumeLayout(false);
            this.okPanel.ResumeLayout(false);
            this.cancelPanel.ResumeLayout(false);
            this.parentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Timer fadeout;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel okPanel;
        private Bunifu.Framework.UI.BunifuFlatButton ok;
        private System.Windows.Forms.Panel cancelPanel;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
        private System.Windows.Forms.Panel yesPanel;
        private Bunifu.Framework.UI.BunifuFlatButton yes;
        private System.Windows.Forms.Panel noPanel;
        private Bunifu.Framework.UI.BunifuFlatButton no;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel captionLbl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.RichTextBox msgLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}