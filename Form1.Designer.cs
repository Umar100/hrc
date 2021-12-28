namespace hrc
{
    partial class Form1
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
            this.nametxtbx = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametxtbx
            // 
            this.nametxtbx.Location = new System.Drawing.Point(326, 130);
            this.nametxtbx.Multiline = true;
            this.nametxtbx.Name = "nametxtbx";
            this.nametxtbx.Size = new System.Drawing.Size(226, 30);
            this.nametxtbx.TabIndex = 0;
            // 
            // dob
            // 
            this.dob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(326, 178);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(226, 20);
            this.dob.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(375, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Heart Rate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.BackColor = System.Drawing.Color.Peru;
            this.resultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlbl.Location = new System.Drawing.Point(30, 307);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(844, 113);
            this.resultlbl.TabIndex = 3;
            this.resultlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Know the state of your heart!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.nametxtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxtbx;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label label1;
    }
}

