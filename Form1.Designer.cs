namespace CursorClip
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
            this.btntarget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btntoggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntarget
            // 
            this.btntarget.Location = new System.Drawing.Point(12, 25);
            this.btntarget.Name = "btntarget";
            this.btntarget.Size = new System.Drawing.Size(75, 23);
            this.btntarget.TabIndex = 0;
            this.btntarget.Text = "Select";
            this.btntarget.UseVisualStyleBackColor = true;
            this.btntarget.Click += new System.EventHandler(this.btntarget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target window";
            // 
            // btntoggle
            // 
            this.btntoggle.Location = new System.Drawing.Point(12, 54);
            this.btntoggle.Name = "btntoggle";
            this.btntoggle.Size = new System.Drawing.Size(75, 23);
            this.btntoggle.TabIndex = 2;
            this.btntoggle.Text = "Activate";
            this.btntoggle.UseVisualStyleBackColor = true;
            this.btntoggle.Click += new System.EventHandler(this.btntoggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 89);
            this.Controls.Add(this.btntoggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntarget);
            this.Name = "Form1";
            this.Text = "Cursor Clip";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntoggle;
    }
}

