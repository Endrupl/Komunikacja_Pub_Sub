namespace ProgramPubSubKlient
{
    partial class PubSubKlient
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
            this.subSettings = new System.Windows.Forms.GroupBox();
            this.windowLogs = new System.Windows.Forms.ListBox();
            this.subDate = new System.Windows.Forms.CheckBox();
            this.subTime = new System.Windows.Forms.CheckBox();
            this.subText = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.subSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // subSettings
            // 
            this.subSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.subSettings.Controls.Add(this.btnStop);
            this.subSettings.Controls.Add(this.btnStart);
            this.subSettings.Controls.Add(this.subText);
            this.subSettings.Controls.Add(this.subTime);
            this.subSettings.Controls.Add(this.subDate);
            this.subSettings.Location = new System.Drawing.Point(12, 12);
            this.subSettings.Name = "subSettings";
            this.subSettings.Size = new System.Drawing.Size(426, 95);
            this.subSettings.TabIndex = 0;
            this.subSettings.TabStop = false;
            this.subSettings.Text = "Ustawienia";
            // 
            // windowLogs
            // 
            this.windowLogs.BackColor = System.Drawing.Color.Tan;
            this.windowLogs.FormattingEnabled = true;
            this.windowLogs.Location = new System.Drawing.Point(12, 118);
            this.windowLogs.Name = "windowLogs";
            this.windowLogs.Size = new System.Drawing.Size(426, 212);
            this.windowLogs.TabIndex = 1;
            // 
            // subDate
            // 
            this.subDate.AutoSize = true;
            this.subDate.Location = new System.Drawing.Point(7, 20);
            this.subDate.Name = "subDate";
            this.subDate.Size = new System.Drawing.Size(102, 17);
            this.subDate.TabIndex = 0;
            this.subDate.Text = "Subskrybuj datę";
            this.subDate.UseVisualStyleBackColor = true;
            // 
            // subTime
            // 
            this.subTime.AutoSize = true;
            this.subTime.Location = new System.Drawing.Point(7, 44);
            this.subTime.Name = "subTime";
            this.subTime.Size = new System.Drawing.Size(103, 17);
            this.subTime.TabIndex = 1;
            this.subTime.Text = "Subskrybuj czas";
            this.subTime.UseVisualStyleBackColor = true;
            // 
            // subText
            // 
            this.subText.AutoSize = true;
            this.subText.Location = new System.Drawing.Point(7, 68);
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(104, 17);
            this.subText.TabIndex = 2;
            this.subText.Text = "Subskrybuj tekst";
            this.subText.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(224, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Subskrybuj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(224, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Zatrzymaj subskrypcję";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // PubSubKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 342);
            this.Controls.Add(this.windowLogs);
            this.Controls.Add(this.subSettings);
            this.Name = "PubSubKlient";
            this.Text = "SubKlient";
            this.subSettings.ResumeLayout(false);
            this.subSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox subSettings;
        private System.Windows.Forms.CheckBox subText;
        private System.Windows.Forms.CheckBox subTime;
        private System.Windows.Forms.CheckBox subDate;
        private System.Windows.Forms.ListBox windowLogs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

