
namespace APP_WindowsForms_RelationalDataBase_and_stored_procedure
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionTS = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosTS = new System.Windows.Forms.ToolStripMenuItem();
            this.pesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spinningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTS = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesTS = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionTS,
            this.serviciosTS,
            this.mantenimientoTS,
            this.clientesTS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionTS
            // 
            this.administracionTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.administracionTS.Name = "administracionTS";
            this.administracionTS.Size = new System.Drawing.Size(48, 20);
            this.administracionTS.Text = "Inicio";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sociosToolStripMenuItem.Tag = "1";
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Tag = "2";
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Tag = "3";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // serviciosTS
            // 
            this.serviciosTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesasToolStripMenuItem,
            this.spinningToolStripMenuItem,
            this.pilatesToolStripMenuItem});
            this.serviciosTS.Name = "serviciosTS";
            this.serviciosTS.Size = new System.Drawing.Size(65, 20);
            this.serviciosTS.Text = "Servicios";
            // 
            // pesasToolStripMenuItem
            // 
            this.pesasToolStripMenuItem.Name = "pesasToolStripMenuItem";
            this.pesasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesasToolStripMenuItem.Tag = "4";
            this.pesasToolStripMenuItem.Text = "Pesas";
            // 
            // spinningToolStripMenuItem
            // 
            this.spinningToolStripMenuItem.Name = "spinningToolStripMenuItem";
            this.spinningToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spinningToolStripMenuItem.Tag = "5";
            this.spinningToolStripMenuItem.Text = "Spinning";
            // 
            // pilatesToolStripMenuItem
            // 
            this.pilatesToolStripMenuItem.Name = "pilatesToolStripMenuItem";
            this.pilatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilatesToolStripMenuItem.Tag = "6";
            this.pilatesToolStripMenuItem.Text = "Pilates";
            // 
            // mantenimientoTS
            // 
            this.mantenimientoTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem1,
            this.membresiasToolStripMenuItem,
            this.lockerToolStripMenuItem,
            this.rolUsuarioToolStripMenuItem});
            this.mantenimientoTS.Name = "mantenimientoTS";
            this.mantenimientoTS.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoTS.Tag = "";
            this.mantenimientoTS.Text = "Mantenimiento";
            // 
            // serviciosToolStripMenuItem1
            // 
            this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serviciosToolStripMenuItem1.Tag = "7";
            this.serviciosToolStripMenuItem1.Text = "Servicios";
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.membresiasToolStripMenuItem.Tag = "8";
            this.membresiasToolStripMenuItem.Text = "Membresias";
            // 
            // lockerToolStripMenuItem
            // 
            this.lockerToolStripMenuItem.Name = "lockerToolStripMenuItem";
            this.lockerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockerToolStripMenuItem.Tag = "9";
            this.lockerToolStripMenuItem.Text = "Locker";
            // 
            // rolUsuarioToolStripMenuItem
            // 
            this.rolUsuarioToolStripMenuItem.Name = "rolUsuarioToolStripMenuItem";
            this.rolUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolUsuarioToolStripMenuItem.Tag = "10";
            this.rolUsuarioToolStripMenuItem.Text = "Rol Usuario";
            this.rolUsuarioToolStripMenuItem.Click += new System.EventHandler(this.rolUsuarioToolStripMenuItem_Click);
            // 
            // clientesTS
            // 
            this.clientesTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.clientesTS.Name = "clientesTS";
            this.clientesTS.Size = new System.Drawing.Size(61, 20);
            this.clientesTS.Text = "Clientes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaToolStripMenuItem.Tag = "11";
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaToolStripMenuItem.Tag = "12";
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaToolStripMenuItem.Tag = "13";
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Menu Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionTS;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosTS;
        private System.Windows.Forms.ToolStripMenuItem pesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spinningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTS;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesTS;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
    }
}

