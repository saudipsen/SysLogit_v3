using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Models;
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

namespace SysLogit.UI
{
    public partial class ManageShipment : Form
    {
        private readonly IShipmentService _service;
        private readonly IProductService _productService;
        public ManageShipment(IShipmentService service, IProductService productService)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _productService = productService ?? throw new ArgumentNullException(nameof(service));
        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {
            panelShipment.Visible = true;
        }

        private void panelShipment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShipmentSearch_Click(object sender, EventArgs e)
        {
            var ShipmentID=txtShipmentSearch.Text;
            try
            {
                if (string.IsNullOrEmpty(ShipmentID))
                {
                    MessageBox.Show("Please enter a Shipment Id");
                }
                var response= _service.GetShipmentById(Convert.ToInt32(ShipmentID));
                if (response.Data != null)
                {
                    dgShipment.DataSource= new List<Shipment>{response.Data };
                }
                else
                {
                    MessageBox.Show(response.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            catch(Exception ex) 
            {
                Logger.LogError(nameof(btnShipmentSearch_Click), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnSearchProduct_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(txtSearchProductId.Text);
            try
            {
                if (ProductID == 0)
                {
                    MessageBox.Show("Please enter a Product Id");
                }
                var response = _productService.GetProductById(ProductID);
                if (response.Data ==null)
                {
                    MessageBox.Show(response.Message+"Product not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product found", "Info. Please proceed by adding the product to shipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(tbtnSearchProduct_Click), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProductId_Click(object sender, EventArgs e)
        {
            txtProductIdAssigned.Text = txtSearchProductId.Text;
        }

        private void cmbShipmentConsignment_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSubmitShipment.Enabled = true;
        }

        private void btnSubmitShipment_Click(object sender, EventArgs e)
        {
            try
            {
                var shipment = new Shipment
                {
                    ConsignmentId = cmbShipmentConsignment.Text,
                    ProductId = Convert.ToInt32(txtProductIdAssigned.Text),
                    ProductQnty = Convert.ToInt32(txtQuantity.Text),
                    ShipmentDescription = txtShipmentDesc.Text,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Admin"

                };
                var response = _service.AddShipment(shipment);
                if (response.IsSuccess)
                {
                    MessageBox.Show(response.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelShipment.Visible = false;
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(btnSubmitShipment_Click), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
