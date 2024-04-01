
using System;
using Wisej.Web;

namespace gruposInvestigacion
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            navBar.CompactView = !navBar.CompactView;

        }

        private void navBar_PanelCollapsed(object sender, EventArgs e)
        {

        }



        private void Window1_Load(object sender, EventArgs e)
        {

        }

        private void navBar_ItemClick_1(object sender, Wisej.Web.Ext.NavigationBar.NavigationBarItemClickEventArgs e)
        {
            if (e.Item.Name != null)
            {
                switch (e.Item.Name)
                {
                    case "itemPersonas":
                        var form = new ventanaPersonas();
                        form.MdiParent = this;
                        form.Show();
                        break;
                    case "itemGrupos":
                        var form2 = new ventanaGrupos();
                        form2.MdiParent = this;
                        form2.Show();
                        break;
                }
            }
        }

        private void panel1_PanelCollapsed(object sender, EventArgs e)
        {

        }
    }
}
