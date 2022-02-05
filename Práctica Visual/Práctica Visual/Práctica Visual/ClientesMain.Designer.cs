
namespace Práctica_Visual
{
    partial class ClientesMain
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
            this.agregarButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.agregarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarButton
            // 
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.Image = global::Práctica_Visual.Properties.Resources.agregarButton;
            this.agregarButton.Location = new System.Drawing.Point(124, 111);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(120, 43);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.TabStop = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Práctica_Visual.Properties.Resources.ClientesView;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 598);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 559);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientesMain";
            this.Text = "ClientesMain";
            ((System.ComponentModel.ISupportInitialize)(this.agregarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox agregarButton;
    }
}