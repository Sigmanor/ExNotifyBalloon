namespace ExNotifyBalloon
{
    partial class Demo
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
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.cbxIcon = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(5, 37);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 0;
            this.lblBody.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(58, 34);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(232, 20);
            this.txtBody.TabIndex = 2;
            this.txtBody.Text = "Make notifications great again!";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(58, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(232, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Attention";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(5, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titile";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(5, 63);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(45, 13);
            this.lblTimeout.TabIndex = 0;
            this.lblTimeout.Text = "Timeout";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(58, 60);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(232, 20);
            this.txtTimeout.TabIndex = 3;
            this.txtTimeout.Text = "5000";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(7, 89);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(28, 13);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "Icon";
            // 
            // cbxIcon
            // 
            this.cbxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIcon.FormattingEnabled = true;
            this.cbxIcon.Items.AddRange(new object[] {
            "Warning",
            "Error",
            "Info"});
            this.cbxIcon.Location = new System.Drawing.Point(58, 86);
            this.cbxIcon.Name = "cbxIcon";
            this.cbxIcon.Size = new System.Drawing.Size(232, 21);
            this.cbxIcon.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShow.Location = new System.Drawing.Point(0, 133);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(298, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 156);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxIcon);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lblBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo ExNotifyBalloon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.ComboBox cbxIcon;
        private System.Windows.Forms.Button btnShow;
    }
}