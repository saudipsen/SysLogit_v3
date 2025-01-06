using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Models;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SysLogit.UI
{
    public partial class ManageInventory : Form
    {
        private readonly IProductService _productService;
        
        public ManageInventory(IProductService productService)
        {
            InitializeComponent();
            _productService = productService ?? throw new ArgumentNullException(nameof(productService)); 
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            panelProductEntry.Visible = true;
            lblProductId.Visible = false;
            txtProductId.Visible = false;



        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            
        }

        private void PopulateDataGrid()
        {
            try
            {
                // Call the business layer method to get data
                var response = _productService.GetAllProducts();

                if (response.Data != null)
                {
                    // Bind the data to the DataGridView
                    dgInventory.DataSource = response.Data.ToList();
                    
                }
                else
                {
                    MessageBox.Show(response.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(PopulateDataGrid), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductLoadData_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            int productId = 0;
            productId=Convert.ToInt32(txtProductSearch.Text);
            try
            {
                if(productId == 0)
                {
                    MessageBox.Show("Please enter a valid product ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Call the business layer method to get data
                var response = _productService.GetProductById(productId);
                if (response.Data != null)
                {
                    // Bind the data to the DataGridView
                    // dgInventory.DataSource = response.Data.ToString();
                    dgInventory.DataSource = new List<Product> { response.Data };
                }
                else
                {
                    MessageBox.Show(response.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(btnProductSearch_Click), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           switch(btnProductSave.Text)
            {
                case "Save":

                    SaveProduct();
                    break;
                case "Update":
                    UpdateProduct();
                    break;
                case "Delete":
                    DeleteProduct();
                    break;
            }
            
        }

        private void SaveProduct()
        {
            btnProductSave.Enabled = true;
            try
            {
                var productsToAdd = new Product()
                {
                    ProductName = txtProductName.Text,
                    Price = decimal.TryParse(txtProductPrice.Text, out var price) ? price : 0,
                    AddedBy = "Admin", //TODO: Get the logged in user
                    UpdatedOn = null,
                    UpdatedBy = null,
                    IsAvail = true,
                    UsedInShipmentId = null
                };
                if (productsToAdd.ProductName != null)
                {
                    _productService.AddProduct(productsToAdd);
                    MessageBox.Show("Product saved successfully!");
                    panelProductEntry.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter data");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(button1_Click), ex);
                MessageBox.Show("An error occurred while adding the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProduct()
        {
           btnProductUpdate.Enabled= true;
            try
            { 
                var productsToUpdate = new Product()
                {
                    ProductId = int.TryParse(txtProductId.Text, out var id) ? id : 0,
                    ProductName = txtProductName.Text,
                    Price = decimal.TryParse(txtProductPrice.Text, out var price) ? price : 0,
                    AddedBy= "Admin",
                    UpdatedOn = DateTime.Now,
                    UpdatedBy = "Admin", //TODO: Get the logged in user
                    IsAvail = true,
                    UsedInShipmentId = null
                };
                if (productsToUpdate.ProductId != 0)
                {
                    _productService.UpdateProduct(productsToUpdate);
                    MessageBox.Show("Product updated successfully!");
                    panelProductEntry.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter data");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(button1_Click), ex);
                MessageBox.Show("An error occurred while updating the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnProductSave.Enabled = true;
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            panelProductEntry.Visible=true;
            btnProductSave.Text = "Update";
            btnProductSave.Enabled=true;

            if(dgInventory.SelectedRows.Count > 0)
            {
                var selectedProduct = dgInventory.SelectedRows[0].DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    txtProductId.Text = selectedProduct.ProductId.ToString();
                    txtProductName.Text = selectedProduct.ProductName;
                    txtProductPrice.Text = selectedProduct.Price.ToString();
                }
                //nProductSave.Text = "Update";
            }
            else
            {
                 MessageBox.Show("Please select a product to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelProductEntry.Visible = false;
            }
        }
        private void DeleteProduct()
        {
            
            try
            {
                var productsToDelete = new Product()
                {
                    ProductId = int.TryParse(txtProductId.Text, out var id) ? id : 0,
                    //ProductName = txtProductName.Text,
                    //Price = decimal.TryParse(txtProductPrice.Text, out var price) ? price : 0,
                    //UpdatedOn = DateTime.Now,
                    //UpdatedBy = "Admin",
                    //IsAvail = true,
                    //UsedInShipmentId = null
                };
                if (productsToDelete.ProductId != 0)
                {
                    _productService.DeleteProduct(productsToDelete.ProductId);
                    MessageBox.Show("Product deleted successfully!");
                    panelProductEntry.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter data");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(button1_Click), ex);
                MessageBox.Show("An error occurred while deleting the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            panelProductEntry.Visible = true;
            btnProductSave.Text = "Delete";
            btnProductSave.Enabled = true;

            if (dgInventory.SelectedRows.Count > 0)
            {
                var selectedProduct = dgInventory.SelectedRows[0].DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    txtProductId.Text = selectedProduct.ProductId.ToString();
                    txtProductName.Text = selectedProduct.ProductName;
                    txtProductPrice.Text = selectedProduct.Price.ToString();

                    txtProductId.Enabled = false;
                    txtProductName.Visible=false;
                    txtProductPrice.Visible=false;

                    lblProductName.Visible = false;
                    lblProductPrice.Visible = false;    
                }
                //nProductSave.Text = "Update";
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelProductEntry.Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            GenerateReports generateReports = new GenerateReports();
            if (dgInventory.Rows.Count > 0)
            {
                try
                {
                    // Check if there is data in the DataGridView
                    if (dgInventory.Rows.Count == 0)
                    {
                        MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Create a SaveFileDialog to specify the file name and path
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Save Excel File";
                        saveFileDialog.FileName = "InventoryReport_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture);

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Generate the Excel file
                            generateReports.GenerateExcelFile(saveFileDialog.FileName, dgInventory);
                            MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no data to Export. Please load data in the grid!");
            }
            
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
