namespace WF20230110
{
    partial class FormColorCha
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
            this.tBRed = new System.Windows.Forms.TrackBar();
            this.tBGreen = new System.Windows.Forms.TrackBar();
            this.tBBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tBRed
            // 
            this.tBRed.Location = new System.Drawing.Point(159, 9);
            this.tBRed.Maximum = 255;
            this.tBRed.Name = "tBRed";
            this.tBRed.Size = new System.Drawing.Size(104, 45);
            this.tBRed.TabIndex = 0;
            // 
            // tBGreen
            // 
            this.tBGreen.Location = new System.Drawing.Point(159, 116);
            this.tBGreen.Maximum = 255;
            this.tBGreen.Name = "tBGreen";
            this.tBGreen.Size = new System.Drawing.Size(104, 45);
            this.tBGreen.TabIndex = 1;
            // 
            // tBBlue
            // 
            this.tBBlue.Location = new System.Drawing.Point(159, 215);
            this.tBBlue.Maximum = 255;
            this.tBBlue.Name = "tBBlue";
            this.tBBlue.Size = new System.Drawing.Size(104, 45);
            this.tBBlue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(56, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(105, 287);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 6;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // FormColorCha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 352);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBBlue);
            this.Controls.Add(this.tBGreen);
            this.Controls.Add(this.tBRed);
            this.Name = "FormColorCha";
            this.Text = "FormColorCha";
            ((System.ComponentModel.ISupportInitialize)(this.tBRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar tBRed;
        private TrackBar tBGreen;
        private TrackBar tBBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btApply;
    }
}