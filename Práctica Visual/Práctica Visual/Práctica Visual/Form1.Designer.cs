
namespace Práctica_Visual
{
    partial class Visual
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visual));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.salirButton = new System.Windows.Forms.PictureBox();
            this.proveedoresButton = new System.Windows.Forms.PictureBox();
            this.comprasButton = new System.Windows.Forms.PictureBox();
            this.clientesButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.logoButton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salirButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.panelContenedor.Location = new System.Drawing.Point(219, 61);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(938, 593);
            this.panelContenedor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.salirButton);
            this.panel2.Controls.Add(this.proveedoresButton);
            this.panel2.Controls.Add(this.comprasButton);
            this.panel2.Controls.Add(this.clientesButton);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.logoButton);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 653);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicaciones Empresariales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salirButton
            // 
            this.salirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirButton.Image = global::Práctica_Visual.Properties.Resources.SalirButton;
            this.salirButton.Location = new System.Drawing.Point(15, 394);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(181, 47);
            this.salirButton.TabIndex = 5;
            this.salirButton.TabStop = false;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proveedoresButton.Image = global::Práctica_Visual.Properties.Resources.ProveedoresButton;
            this.proveedoresButton.Location = new System.Drawing.Point(15, 324);
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.Size = new System.Drawing.Size(181, 47);
            this.proveedoresButton.TabIndex = 4;
            this.proveedoresButton.TabStop = false;
            // 
            // comprasButton
            // 
            this.comprasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comprasButton.Image = global::Práctica_Visual.Properties.Resources.ComprasButton;
            this.comprasButton.Location = new System.Drawing.Point(15, 254);
            this.comprasButton.Name = "comprasButton";
            this.comprasButton.Size = new System.Drawing.Size(181, 47);
            this.comprasButton.TabIndex = 3;
            this.comprasButton.TabStop = false;
            // 
            // clientesButton
            // 
            this.clientesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientesButton.Image = global::Práctica_Visual.Properties.Resources.ClientesButton;
            this.clientesButton.Location = new System.Drawing.Point(15, 184);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(181, 47);
            this.clientesButton.TabIndex = 2;
            this.clientesButton.TabStop = false;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Image = global::Práctica_Visual.Properties.Resources.HomeButton;
            this.homeButton.Location = new System.Drawing.Point(15, 114);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(181, 47);
            this.homeButton.TabIndex = 1;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoButton
            // 
            this.logoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoButton.Image = global::Práctica_Visual.Properties.Resources.Logo;
            this.logoButton.Location = new System.Drawing.Point(66, 11);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(67, 78);
            this.logoButton.TabIndex = 0;
            this.logoButton.TabStop = false;
            this.logoButton.Click += new System.EventHandler(this.logoButton_Click);
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1158, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica Visual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salirButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox clientesButton;
        private System.Windows.Forms.PictureBox comprasButton;
        private System.Windows.Forms.PictureBox proveedoresButton;
        private System.Windows.Forms.PictureBox salirButton;
        private System.Windows.Forms.Label label1;
    }
}

