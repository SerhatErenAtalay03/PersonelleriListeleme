namespace PersonelleriListeleme
{
    partial class SplashEkranics
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
            this.yukleniyor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yukleniyor
            // 
            this.yukleniyor.AutoSize = true;
            this.yukleniyor.BackColor = System.Drawing.Color.Yellow;
            this.yukleniyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yukleniyor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.yukleniyor.Location = new System.Drawing.Point(295, 203);
            this.yukleniyor.Name = "yukleniyor";
            this.yukleniyor.Size = new System.Drawing.Size(421, 42);
            this.yukleniyor.TabIndex = 2;
            this.yukleniyor.Text = "SAYFA YÜKLENİYOR...";
            // 
            // SplashEkranics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(971, 553);
            this.Controls.Add(this.yukleniyor);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SplashEkranics";
            this.Text = "SplashEkranics";
            this.Load += new System.EventHandler(this.SplashEkranics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yukleniyor;
    }
}