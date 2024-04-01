namespace gruposInvestigacion
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            this.navBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.itemPersonas = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.itemGrupos = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.panel1 = new Wisej.Web.Panel();
            this.btnNavBar = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.CompactView = true;
            this.navBar.Dock = Wisej.Web.DockStyle.Left;
            this.navBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.itemPersonas,
            this.itemGrupos});
            this.navBar.Logo = "icon-exit";
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(70, 669);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "navigationBar1";
            this.navBar.ItemClick += new Wisej.Web.Ext.NavigationBar.NavigationBarItemClickEventHandler(this.navBar_ItemClick_1);
            this.navBar.PanelCollapsed += new System.EventHandler(this.navBar_PanelCollapsed);
            // 
            // itemPersonas
            // 
            this.itemPersonas.Icon = "icon-right";
            this.itemPersonas.Name = "itemPersonas";
            this.itemPersonas.Text = "Personas";
            // 
            // itemGrupos
            // 
            this.itemGrupos.Icon = "spinner-plus";
            this.itemGrupos.Name = "itemGrupos";
            this.itemGrupos.Text = "Grupos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNavBar);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 56);
            this.panel1.TabIndex = 2;
            this.panel1.PanelCollapsed += new System.EventHandler(this.panel1_PanelCollapsed);
            // 
            // btnNavBar
            // 
            this.btnNavBar.Image = ((System.Drawing.Image)(resources.GetObject("btnNavBar.Image")));
            this.btnNavBar.Location = new System.Drawing.Point(6, 3);
            this.btnNavBar.Name = "btnNavBar";
            this.btnNavBar.Size = new System.Drawing.Size(51, 37);
            this.btnNavBar.TabIndex = 0;
            this.btnNavBar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Window1";
            this.Text = "Grupos y personas";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Ext.NavigationBar.NavigationBar navBar;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnNavBar;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem itemPersonas;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem itemGrupos;
    }
}

