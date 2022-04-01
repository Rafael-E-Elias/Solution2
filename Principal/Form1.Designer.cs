namespace Principal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.apellidoToolStripMenuItem,
            this.cerraSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            // 
            // apellidoToolStripMenuItem
            // 
            this.apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            this.apellidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apellidoToolStripMenuItem.Text = "Apellido";
            // 
            // cerraSesionToolStripMenuItem
            // 
            this.cerraSesionToolStripMenuItem.Name = "cerraSesionToolStripMenuItem";
            this.cerraSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerraSesionToolStripMenuItem.Text = "Cerra Sesion";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCajaToolStripMenuItem,
            this.cerrarCajaToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.facturacionToolStripMenuItem.Text = "facturacion";
            // 
            // abrirCajaToolStripMenuItem
            // 
            this.abrirCajaToolStripMenuItem.Name = "abrirCajaToolStripMenuItem";
            this.abrirCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirCajaToolStripMenuItem.Text = "Abrir Caja";
            this.abrirCajaToolStripMenuItem.Click += new System.EventHandler(this.abrirCajaToolStripMenuItem_Click);
            // 
            // cerrarCajaToolStripMenuItem
            // 
            this.cerrarCajaToolStripMenuItem.Name = "cerrarCajaToolStripMenuItem";
            this.cerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarCajaToolStripMenuItem.Text = "Cerrar Caja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
    }
}

