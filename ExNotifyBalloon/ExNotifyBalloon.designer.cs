namespace ExNotifyBalloon
{
    partial class ExNotifyBalloon
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
            this.labelApp = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApp.ForeColor = System.Drawing.Color.DimGray;
            this.labelApp.Location = new System.Drawing.Point(78, 82);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(100, 13);
            this.labelApp.TabIndex = 6;
            this.labelApp.Text = "App located name";
            this.labelApp.Click += new System.EventHandler(this.LabelApp_Click);
            this.labelApp.MouseEnter += new System.EventHandler(this.LabelApp_MouseEnter);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Location = new System.Drawing.Point(20, 30);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 5;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.PictureBoxIcon_Click);
            this.pictureBoxIcon.MouseEnter += new System.EventHandler(this.PictureBoxIcon_MouseEnter);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoEllipsis = true;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle.Location = new System.Drawing.Point(76, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 23);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title located here";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
            this.labelTitle.MouseEnter += new System.EventHandler(this.LabelTitle_MouseEnter);
            // 
            // labelBody
            // 
            this.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBody.AutoEllipsis = true;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBody.ForeColor = System.Drawing.Color.DarkGray;
            this.labelBody.Location = new System.Drawing.Point(77, 49);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(262, 29);
            this.labelBody.TabIndex = 4;
            this.labelBody.Text = "Body located here";
            this.labelBody.Click += new System.EventHandler(this.LabelBody_Click);
            this.labelBody.MouseEnter += new System.EventHandler(this.LabelBody_MouseEnter);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Tick += new System.EventHandler(this.NotifyTimer_Tick);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.DimGray;
            this.labelClose.Location = new System.Drawing.Point(338, 3);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 18);
            this.labelClose.TabIndex = 8;
            this.labelClose.Text = "x";
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.LabelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.LabelClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxIcon);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.labelApp);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.labelBody);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 100);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.Panel1_MouseLeave);
            // 
            // ExNotifyBalloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(360, 100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExNotifyBalloon";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExNotify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExNotifyBalloon_FormClosed);
            this.Load += new System.EventHandler(this.ExNotifyBalloon_Load);
            this.Click += new System.EventHandler(this.ExNotifyBalloon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Timer notifyTimer;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
    }
}