namespace parcial2MAVJ_AIPP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formularioClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeCálculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioClientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularioClientesToolStripMenuItem
            // 
            this.formularioClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeToolStripMenuItem,
            this.formularioDeCálculosToolStripMenuItem});
            this.formularioClientesToolStripMenuItem.Name = "formularioClientesToolStripMenuItem";
            this.formularioClientesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.formularioClientesToolStripMenuItem.Text = "Archivo";
            this.formularioClientesToolStripMenuItem.Click += new System.EventHandler(this.formularioClientesToolStripMenuItem_Click);
            // 
            // formularioDeToolStripMenuItem
            // 
            this.formularioDeToolStripMenuItem.Name = "formularioDeToolStripMenuItem";
            this.formularioDeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.formularioDeToolStripMenuItem.Text = "Formulario de clientes";
            this.formularioDeToolStripMenuItem.Click += new System.EventHandler(this.formularioDeToolStripMenuItem_Click);
            // 
            // formularioDeCálculosToolStripMenuItem
            // 
            this.formularioDeCálculosToolStripMenuItem.Name = "formularioDeCálculosToolStripMenuItem";
            this.formularioDeCálculosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.formularioDeCálculosToolStripMenuItem.Text = "Formulario de cálculos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularioClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeCálculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

