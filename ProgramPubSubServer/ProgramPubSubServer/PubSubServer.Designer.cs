namespace ProgramPubSubServer
{
    partial class PubSubServer
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
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.publicDate = new System.Windows.Forms.CheckBox();
            this.publicTime = new System.Windows.Forms.CheckBox();
            this.publicText = new System.Windows.Forms.CheckBox();
            this.textContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.windowLogs = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SettingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.btnStart);
            this.SettingBox.Controls.Add(this.label3);
            this.SettingBox.Controls.Add(this.timeText);
            this.SettingBox.Controls.Add(this.label2);
            this.SettingBox.Controls.Add(this.label1);
            this.SettingBox.Controls.Add(this.textContent);
            this.SettingBox.Controls.Add(this.publicText);
            this.SettingBox.Controls.Add(this.publicTime);
            this.SettingBox.Controls.Add(this.publicDate);
            this.SettingBox.Location = new System.Drawing.Point(12, 12);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(430, 155);
            this.SettingBox.TabIndex = 0;
            this.SettingBox.TabStop = false;
            this.SettingBox.Text = "Ustawienia";
            // 
            // publicDate
            // 
            this.publicDate.AutoSize = true;
            this.publicDate.Location = new System.Drawing.Point(6, 19);
            this.publicDate.Name = "publicDate";
            this.publicDate.Size = new System.Drawing.Size(87, 17);
            this.publicDate.TabIndex = 0;
            this.publicDate.Text = "Publikuj datę";
            this.publicDate.UseVisualStyleBackColor = true;
            // 
            // publicTime
            // 
            this.publicTime.AutoSize = true;
            this.publicTime.Location = new System.Drawing.Point(5, 42);
            this.publicTime.Name = "publicTime";
            this.publicTime.Size = new System.Drawing.Size(88, 17);
            this.publicTime.TabIndex = 1;
            this.publicTime.Text = "Publikuj czas";
            this.publicTime.UseVisualStyleBackColor = true;
            // 
            // publicText
            // 
            this.publicText.AutoSize = true;
            this.publicText.Location = new System.Drawing.Point(5, 65);
            this.publicText.Name = "publicText";
            this.publicText.Size = new System.Drawing.Size(89, 17);
            this.publicText.TabIndex = 2;
            this.publicText.Text = "Publikuj tekst";
            this.publicText.UseVisualStyleBackColor = true;
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(77, 94);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(125, 20);
            this.textContent.TabIndex = 3;
            this.textContent.Text = "Tekst do zmiany";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wpisz tekst: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publikuj informacje co:";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(255, 53);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(51, 20);
            this.timeText.TabIndex = 6;
            this.timeText.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "sekund";
            // 
            // windowLogs
            // 
            this.windowLogs.FormattingEnabled = true;
            this.windowLogs.Location = new System.Drawing.Point(12, 173);
            this.windowLogs.Name = "windowLogs";
            this.windowLogs.Size = new System.Drawing.Size(430, 290);
            this.windowLogs.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(418, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PubSubServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 488);
            this.Controls.Add(this.windowLogs);
            this.Controls.Add(this.SettingBox);
            this.Name = "PubSubServer";
            this.Text = "PubSerwer";
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.CheckBox publicText;
        private System.Windows.Forms.CheckBox publicTime;
        private System.Windows.Forms.CheckBox publicDate;
        private System.Windows.Forms.ListBox windowLogs;
        private System.Windows.Forms.Button btnStart;
    }
}

