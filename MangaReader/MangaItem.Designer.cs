namespace MangaReader
{
    partial class MangaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDescreption = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictur)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescreption
            // 
            this.lbDescreption.AutoSize = true;
            this.lbDescreption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbDescreption.Location = new System.Drawing.Point(155, 60);
            this.lbDescreption.Name = "lbDescreption";
            this.lbDescreption.Size = new System.Drawing.Size(128, 26);
            this.lbDescreption.TabIndex = 1;
            this.lbDescreption.Text = "Descreption";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbTitle.Location = new System.Drawing.Point(155, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(52, 26);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // pictur
            // 
            this.pictur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictur.Location = new System.Drawing.Point(0, 0);
            this.pictur.Name = "pictur";
            this.pictur.Size = new System.Drawing.Size(101, 112);
            this.pictur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictur.TabIndex = 0;
            this.pictur.TabStop = false;
            // 
            // MangaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(141)))));
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDescreption);
            this.Controls.Add(this.pictur);
            this.Name = "MangaItem";
            this.Size = new System.Drawing.Size(442, 112);
            this.Load += new System.EventHandler(this.MangaItem_Load);
            this.Click += new System.EventHandler(this.MangaItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictur;
        private System.Windows.Forms.Label lbDescreption;
        private System.Windows.Forms.Label lbTitle;
    }
}
