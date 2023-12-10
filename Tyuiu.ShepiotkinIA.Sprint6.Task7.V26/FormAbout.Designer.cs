
namespace Tyuiu.ShepiotkinIA.Sprint6.Task7.V26
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_SIA = new System.Windows.Forms.PictureBox();
            this.LabelInfo_SIA = new System.Windows.Forms.Label();
            this.buttonOk_SIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SIA
            // 
            this.pictureBoxAvatar_SIA.ErrorImage = null;
            this.pictureBoxAvatar_SIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SIA.Image")));
            this.pictureBoxAvatar_SIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SIA.Name = "pictureBoxAvatar_SIA";
            this.pictureBoxAvatar_SIA.Size = new System.Drawing.Size(141, 185);
            this.pictureBoxAvatar_SIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SIA.TabIndex = 1;
            this.pictureBoxAvatar_SIA.TabStop = false;
            // 
            // LabelInfo_SIA
            // 
            this.LabelInfo_SIA.AutoSize = true;
            this.LabelInfo_SIA.Location = new System.Drawing.Point(169, 12);
            this.LabelInfo_SIA.Name = "LabelInfo_SIA";
            this.LabelInfo_SIA.Size = new System.Drawing.Size(284, 117);
            this.LabelInfo_SIA.TabIndex = 2;
            this.LabelInfo_SIA.Text = resources.GetString("LabelInfo_SIA.Text");
            // 
            // buttonOk_SIA
            // 
            this.buttonOk_SIA.Location = new System.Drawing.Point(385, 172);
            this.buttonOk_SIA.Name = "buttonOk_SIA";
            this.buttonOk_SIA.Size = new System.Drawing.Size(84, 25);
            this.buttonOk_SIA.TabIndex = 3;
            this.buttonOk_SIA.Text = "Ок";
            this.buttonOk_SIA.UseVisualStyleBackColor = true;
            this.buttonOk_SIA.Click += new System.EventHandler(this.buttonOk_SIA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 209);
            this.Controls.Add(this.buttonOk_SIA);
            this.Controls.Add(this.LabelInfo_SIA);
            this.Controls.Add(this.pictureBoxAvatar_SIA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SIA;
        private System.Windows.Forms.Label LabelInfo_SIA;
        private System.Windows.Forms.Button buttonOk_SIA;
    }
}