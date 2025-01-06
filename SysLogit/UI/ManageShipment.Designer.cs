namespace SysLogit.UI
{
    partial class ManageShipment
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
            this.btnShipmentSearch = new System.Windows.Forms.Button();
            this.txtShipmentSearch = new System.Windows.Forms.TextBox();
            this.lblShipmentSearch = new System.Windows.Forms.Label();
            this.dgShipment = new System.Windows.Forms.DataGridView();
            this.panelShipment = new System.Windows.Forms.Panel();
            this.btnSubmitShipment = new System.Windows.Forms.Button();
            this.lblShipmentConsignment = new System.Windows.Forms.Label();
            this.cmbShipmentConsignment = new System.Windows.Forms.ComboBox();
            this.txtShipmentDesc = new System.Windows.Forms.TextBox();
            this.lblShipmentDesc = new System.Windows.Forms.Label();
            this.btnAddProductId = new System.Windows.Forms.Button();
            this.txtProductIdAssigned = new System.Windows.Forms.TextBox();
            this.lblProductAssigned = new System.Windows.Forms.Label();
            this.tbtnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProductId = new System.Windows.Forms.TextBox();
            this.lblProductIdLookup = new System.Windows.Forms.Label();
            this.lblShipmentAssign = new System.Windows.Forms.Label();
            this.btnCreateShipment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgShipment)).BeginInit();
            this.panelShipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShipmentSearch
            // 
            this.btnShipmentSearch.BackColor = System.Drawing.Color.LightCyan;
            this.btnShipmentSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipmentSearch.Location = new System.Drawing.Point(481, 74);
            this.btnShipmentSearch.Name = "btnShipmentSearch";
            this.btnShipmentSearch.Size = new System.Drawing.Size(172, 38);
            this.btnShipmentSearch.TabIndex = 7;
            this.btnShipmentSearch.Text = "Search";
            this.btnShipmentSearch.UseVisualStyleBackColor = false;
            this.btnShipmentSearch.Click += new System.EventHandler(this.btnShipmentSearch_Click);
            // 
            // txtShipmentSearch
            // 
            this.txtShipmentSearch.Location = new System.Drawing.Point(202, 83);
            this.txtShipmentSearch.Name = "txtShipmentSearch";
            this.txtShipmentSearch.Size = new System.Drawing.Size(273, 22);
            this.txtShipmentSearch.TabIndex = 6;
            // 
            // lblShipmentSearch
            // 
            this.lblShipmentSearch.AutoSize = true;
            this.lblShipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentSearch.ForeColor = System.Drawing.Color.Black;
            this.lblShipmentSearch.Location = new System.Drawing.Point(39, 83);
            this.lblShipmentSearch.Name = "lblShipmentSearch";
            this.lblShipmentSearch.Size = new System.Drawing.Size(159, 20);
            this.lblShipmentSearch.TabIndex = 5;
            this.lblShipmentSearch.Text = "Enter Shipment Id";
            // 
            // dgShipment
            // 
            this.dgShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShipment.Location = new System.Drawing.Point(25, 141);
            this.dgShipment.Name = "dgShipment";
            this.dgShipment.RowHeadersWidth = 51;
            this.dgShipment.RowTemplate.Height = 24;
            this.dgShipment.Size = new System.Drawing.Size(806, 137);
            this.dgShipment.TabIndex = 4;
            // 
            // panelShipment
            // 
            this.panelShipment.Controls.Add(this.txtQuantity);
            this.panelShipment.Controls.Add(this.label1);
            this.panelShipment.Controls.Add(this.btnSubmitShipment);
            this.panelShipment.Controls.Add(this.lblShipmentConsignment);
            this.panelShipment.Controls.Add(this.cmbShipmentConsignment);
            this.panelShipment.Controls.Add(this.txtShipmentDesc);
            this.panelShipment.Controls.Add(this.lblShipmentDesc);
            this.panelShipment.Controls.Add(this.btnAddProductId);
            this.panelShipment.Controls.Add(this.txtProductIdAssigned);
            this.panelShipment.Controls.Add(this.lblProductAssigned);
            this.panelShipment.Controls.Add(this.tbtnSearchProduct);
            this.panelShipment.Controls.Add(this.txtSearchProductId);
            this.panelShipment.Controls.Add(this.lblProductIdLookup);
            this.panelShipment.Controls.Add(this.lblShipmentAssign);
            this.panelShipment.Location = new System.Drawing.Point(857, 141);
            this.panelShipment.Name = "panelShipment";
            this.panelShipment.Size = new System.Drawing.Size(400, 522);
            this.panelShipment.TabIndex = 8;
            this.panelShipment.Visible = false;
            this.panelShipment.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShipment_Paint);
            // 
            // btnSubmitShipment
            // 
            this.btnSubmitShipment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmitShipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitShipment.Enabled = false;
            this.btnSubmitShipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitShipment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitShipment.Location = new System.Drawing.Point(248, 461);
            this.btnSubmitShipment.Name = "btnSubmitShipment";
            this.btnSubmitShipment.Size = new System.Drawing.Size(129, 38);
            this.btnSubmitShipment.TabIndex = 12;
            this.btnSubmitShipment.Text = "Save";
            this.btnSubmitShipment.UseVisualStyleBackColor = false;
            this.btnSubmitShipment.Click += new System.EventHandler(this.btnSubmitShipment_Click);
            // 
            // lblShipmentConsignment
            // 
            this.lblShipmentConsignment.AutoSize = true;
            this.lblShipmentConsignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentConsignment.Location = new System.Drawing.Point(29, 386);
            this.lblShipmentConsignment.Name = "lblShipmentConsignment";
            this.lblShipmentConsignment.Size = new System.Drawing.Size(152, 18);
            this.lblShipmentConsignment.TabIndex = 11;
            this.lblShipmentConsignment.Text = "Enter Consignment";
            // 
            // cmbShipmentConsignment
            // 
            this.cmbShipmentConsignment.FormattingEnabled = true;
            this.cmbShipmentConsignment.Items.AddRange(new object[] {
            "CNSMNT001",
            "CNSMNT002",
            "CNSMNT003",
            "CNSMNT004",
            "CNSMNT005"});
            this.cmbShipmentConsignment.Location = new System.Drawing.Point(32, 416);
            this.cmbShipmentConsignment.Name = "cmbShipmentConsignment";
            this.cmbShipmentConsignment.Size = new System.Drawing.Size(345, 24);
            this.cmbShipmentConsignment.TabIndex = 10;
            this.cmbShipmentConsignment.SelectedValueChanged += new System.EventHandler(this.cmbShipmentConsignment_SelectedValueChanged);
            // 
            // txtShipmentDesc
            // 
            this.txtShipmentDesc.Location = new System.Drawing.Point(32, 335);
            this.txtShipmentDesc.Name = "txtShipmentDesc";
            this.txtShipmentDesc.Size = new System.Drawing.Size(345, 22);
            this.txtShipmentDesc.TabIndex = 8;
            // 
            // lblShipmentDesc
            // 
            this.lblShipmentDesc.AutoSize = true;
            this.lblShipmentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentDesc.Location = new System.Drawing.Point(29, 301);
            this.lblShipmentDesc.Name = "lblShipmentDesc";
            this.lblShipmentDesc.Size = new System.Drawing.Size(169, 18);
            this.lblShipmentDesc.TabIndex = 7;
            this.lblShipmentDesc.Text = "Shipment Description";
            // 
            // btnAddProductId
            // 
            this.btnAddProductId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProductId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProductId.Location = new System.Drawing.Point(298, 122);
            this.btnAddProductId.Name = "btnAddProductId";
            this.btnAddProductId.Size = new System.Drawing.Size(79, 38);
            this.btnAddProductId.TabIndex = 6;
            this.btnAddProductId.Text = "Add";
            this.btnAddProductId.UseVisualStyleBackColor = false;
            this.btnAddProductId.Click += new System.EventHandler(this.btnAddProductId_Click);
            // 
            // txtProductIdAssigned
            // 
            this.txtProductIdAssigned.Enabled = false;
            this.txtProductIdAssigned.Location = new System.Drawing.Point(32, 220);
            this.txtProductIdAssigned.Name = "txtProductIdAssigned";
            this.txtProductIdAssigned.Size = new System.Drawing.Size(221, 22);
            this.txtProductIdAssigned.TabIndex = 5;
            // 
            // lblProductAssigned
            // 
            this.lblProductAssigned.AutoSize = true;
            this.lblProductAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAssigned.Location = new System.Drawing.Point(29, 188);
            this.lblProductAssigned.Name = "lblProductAssigned";
            this.lblProductAssigned.Size = new System.Drawing.Size(168, 18);
            this.lblProductAssigned.TabIndex = 4;
            this.lblProductAssigned.Text = "Assigned Product Id: ";
            // 
            // tbtnSearchProduct
            // 
            this.tbtnSearchProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbtnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbtnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnSearchProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbtnSearchProduct.Location = new System.Drawing.Point(195, 122);
            this.tbtnSearchProduct.Name = "tbtnSearchProduct";
            this.tbtnSearchProduct.Size = new System.Drawing.Size(84, 38);
            this.tbtnSearchProduct.TabIndex = 3;
            this.tbtnSearchProduct.Text = "Search";
            this.tbtnSearchProduct.UseVisualStyleBackColor = false;
            this.tbtnSearchProduct.Click += new System.EventHandler(this.tbtnSearchProduct_Click);
            // 
            // txtSearchProductId
            // 
            this.txtSearchProductId.Location = new System.Drawing.Point(195, 81);
            this.txtSearchProductId.Name = "txtSearchProductId";
            this.txtSearchProductId.Size = new System.Drawing.Size(182, 22);
            this.txtSearchProductId.TabIndex = 2;
            // 
            // lblProductIdLookup
            // 
            this.lblProductIdLookup.AutoSize = true;
            this.lblProductIdLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIdLookup.Location = new System.Drawing.Point(29, 85);
            this.lblProductIdLookup.Name = "lblProductIdLookup";
            this.lblProductIdLookup.Size = new System.Drawing.Size(140, 18);
            this.lblProductIdLookup.TabIndex = 1;
            this.lblProductIdLookup.Text = "Enter Product Id: ";
            // 
            // lblShipmentAssign
            // 
            this.lblShipmentAssign.AutoSize = true;
            this.lblShipmentAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentAssign.Location = new System.Drawing.Point(124, 22);
            this.lblShipmentAssign.Name = "lblShipmentAssign";
            this.lblShipmentAssign.Size = new System.Drawing.Size(150, 20);
            this.lblShipmentAssign.TabIndex = 0;
            this.lblShipmentAssign.Text = "Assign Shipment";
            // 
            // btnCreateShipment
            // 
            this.btnCreateShipment.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCreateShipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateShipment.Location = new System.Drawing.Point(659, 74);
            this.btnCreateShipment.Name = "btnCreateShipment";
            this.btnCreateShipment.Size = new System.Drawing.Size(172, 38);
            this.btnCreateShipment.TabIndex = 9;
            this.btnCreateShipment.Text = "Create Shipment";
            this.btnCreateShipment.UseVisualStyleBackColor = false;
            this.btnCreateShipment.Click += new System.EventHandler(this.btnCreateShipment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(170, 266);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(83, 22);
            this.txtQuantity.TabIndex = 14;
            // 
            // ManageShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 724);
            this.Controls.Add(this.btnCreateShipment);
            this.Controls.Add(this.panelShipment);
            this.Controls.Add(this.btnShipmentSearch);
            this.Controls.Add(this.txtShipmentSearch);
            this.Controls.Add(this.lblShipmentSearch);
            this.Controls.Add(this.dgShipment);
            this.Name = "ManageShipment";
            this.Text = "Manage Shipment";
            ((System.ComponentModel.ISupportInitialize)(this.dgShipment)).EndInit();
            this.panelShipment.ResumeLayout(false);
            this.panelShipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShipmentSearch;
        private System.Windows.Forms.TextBox txtShipmentSearch;
        private System.Windows.Forms.Label lblShipmentSearch;
        private System.Windows.Forms.DataGridView dgShipment;
        private System.Windows.Forms.Panel panelShipment;
        private System.Windows.Forms.Label lblProductIdLookup;
        private System.Windows.Forms.Label lblShipmentAssign;
        private System.Windows.Forms.Button tbtnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProductId;
        private System.Windows.Forms.TextBox txtProductIdAssigned;
        private System.Windows.Forms.Label lblProductAssigned;
        private System.Windows.Forms.Button btnAddProductId;
        private System.Windows.Forms.ComboBox cmbShipmentConsignment;
        private System.Windows.Forms.TextBox txtShipmentDesc;
        private System.Windows.Forms.Label lblShipmentDesc;
        private System.Windows.Forms.Label lblShipmentConsignment;
        private System.Windows.Forms.Button btnSubmitShipment;
        private System.Windows.Forms.Button btnCreateShipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}