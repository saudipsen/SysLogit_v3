using SysLogit.UI;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace SysLogit
{
    public partial class Main : Form
    {
        private readonly IUnityContainer _container;
        public Main(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Resolve the ManageInventory form with dependencies
                var manageInventoryForm = _container.Resolve<ManageInventory>();
                manageInventoryForm.Show();
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(viewProductsToolStripMenuItem_Click), ex);
                MessageBox.Show("An error occurred while opening the Manage Inventory form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manageShipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageShipmentForm = _container.Resolve<ManageShipment>();
            manageShipmentForm.Show();

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
