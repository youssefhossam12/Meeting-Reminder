namespace MeetingTime {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dtTmPckrDate = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrTime = new System.Windows.Forms.DateTimePicker();
            this.lblEvaluate = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting date time:";
            // 
            // dtTmPckrDate
            // 
            this.dtTmPckrDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDate.Location = new System.Drawing.Point(99, 63);
            this.dtTmPckrDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtTmPckrDate.Name = "dtTmPckrDate";
            this.dtTmPckrDate.Size = new System.Drawing.Size(133, 22);
            this.dtTmPckrDate.TabIndex = 1;
            // 
            // dtTmPckrTime
            // 
            this.dtTmPckrTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrTime.Location = new System.Drawing.Point(241, 63);
            this.dtTmPckrTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtTmPckrTime.Name = "dtTmPckrTime";
            this.dtTmPckrTime.ShowUpDown = true;
            this.dtTmPckrTime.Size = new System.Drawing.Size(133, 22);
            this.dtTmPckrTime.TabIndex = 2;
            // 
            // lblEvaluate
            // 
            this.lblEvaluate.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluate.ForeColor = System.Drawing.Color.Maroon;
            this.lblEvaluate.Location = new System.Drawing.Point(-11, 162);
            this.lblEvaluate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaluate.Name = "lblEvaluate";
            this.lblEvaluate.Size = new System.Drawing.Size(473, 25);
            this.lblEvaluate.TabIndex = 3;
            this.lblEvaluate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(81, 217);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(93, 28);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(275, 217);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 263);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meeting time:";
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Location = new System.Drawing.Point(191, 100);
            this.lblMeeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(0, 17);
            this.lblMeeting.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current time:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(191, 127);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(0, 17);
            this.lblCurrent.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 366);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMeeting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblEvaluate);
            this.Controls.Add(this.dtTmPckrTime);
            this.Controls.Add(this.dtTmPckrDate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTmPckrDate;
        private System.Windows.Forms.DateTimePicker dtTmPckrTime;
        private System.Windows.Forms.Label lblEvaluate;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrent;
    }
}

