
namespace StockManagement.UIForms
{
    partial class FrmProducts
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
            this.lblUnitsOnOrderUpdate = new System.Windows.Forms.Label();
            this.lblSupplierIdUpdate = new System.Windows.Forms.Label();
            this.tbxUnitsOnOrderUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbxDiscontinuedAdd = new System.Windows.Forms.CheckBox();
            this.lblDiscontinuedAdd = new System.Windows.Forms.Label();
            this.lblUnitsOnOrderAdd = new System.Windows.Forms.Label();
            this.lblSupplierIdAdd = new System.Windows.Forms.Label();
            this.tbxUnitsOnOrderAdd = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxSupplierNameAdd = new System.Windows.Forms.ComboBox();
            this.cbxCategoryNameAdd = new System.Windows.Forms.ComboBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.cbxCategoryNameUpdate = new System.Windows.Forms.ComboBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxSearchProductName = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblListByCategory = new System.Windows.Forms.Label();
            this.lblDiscontinuedUpdate = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbcProduct = new System.Windows.Forms.TabControl();
            this.tbpAddProduct = new System.Windows.Forms.TabPage();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.tbpUpdateProduct = new System.Windows.Forms.TabPage();
            this.cbxDiscontinuedUpdate = new System.Windows.Forms.CheckBox();
            this.cbxSupplierNameUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxReorderLevelAdd = new System.Windows.Forms.TextBox();
            this.lblReorderLevelAdd = new System.Windows.Forms.Label();
            this.tbxReorderLevelUpdate = new System.Windows.Forms.TextBox();
            this.lblReorderLevelUpdate = new System.Windows.Forms.Label();
            this.tbcProduct.SuspendLayout();
            this.tbpAddProduct.SuspendLayout();
            this.tbpUpdateProduct.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitsOnOrderUpdate
            // 
            this.lblUnitsOnOrderUpdate.AutoSize = true;
            this.lblUnitsOnOrderUpdate.Location = new System.Drawing.Point(500, 44);
            this.lblUnitsOnOrderUpdate.Name = "lblUnitsOnOrderUpdate";
            this.lblUnitsOnOrderUpdate.Size = new System.Drawing.Size(81, 13);
            this.lblUnitsOnOrderUpdate.TabIndex = 29;
            this.lblUnitsOnOrderUpdate.Text = "Sipariş Miktarı : ";
            // 
            // lblSupplierIdUpdate
            // 
            this.lblSupplierIdUpdate.AutoSize = true;
            this.lblSupplierIdUpdate.Location = new System.Drawing.Point(493, 17);
            this.lblSupplierIdUpdate.Name = "lblSupplierIdUpdate";
            this.lblSupplierIdUpdate.Size = new System.Drawing.Size(88, 13);
            this.lblSupplierIdUpdate.TabIndex = 30;
            this.lblSupplierIdUpdate.Text = "Tedarikçi Firma : ";
            // 
            // tbxUnitsOnOrderUpdate
            // 
            this.tbxUnitsOnOrderUpdate.Location = new System.Drawing.Point(587, 41);
            this.tbxUnitsOnOrderUpdate.Name = "tbxUnitsOnOrderUpdate";
            this.tbxUnitsOnOrderUpdate.Size = new System.Drawing.Size(350, 20);
            this.tbxUnitsOnOrderUpdate.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(963, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 44);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseMnemonic = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Location = new System.Drawing.Point(963, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 44);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbxDiscontinuedAdd
            // 
            this.cbxDiscontinuedAdd.AutoSize = true;
            this.cbxDiscontinuedAdd.Location = new System.Drawing.Point(587, 97);
            this.cbxDiscontinuedAdd.Name = "cbxDiscontinuedAdd";
            this.cbxDiscontinuedAdd.Size = new System.Drawing.Size(15, 14);
            this.cbxDiscontinuedAdd.TabIndex = 57;
            this.cbxDiscontinuedAdd.UseVisualStyleBackColor = true;
            // 
            // lblDiscontinuedAdd
            // 
            this.lblDiscontinuedAdd.AutoSize = true;
            this.lblDiscontinuedAdd.Location = new System.Drawing.Point(480, 97);
            this.lblDiscontinuedAdd.Name = "lblDiscontinuedAdd";
            this.lblDiscontinuedAdd.Size = new System.Drawing.Size(101, 13);
            this.lblDiscontinuedAdd.TabIndex = 54;
            this.lblDiscontinuedAdd.Text = "Üretim Durduruldu : ";
            // 
            // lblUnitsOnOrderAdd
            // 
            this.lblUnitsOnOrderAdd.AutoSize = true;
            this.lblUnitsOnOrderAdd.Location = new System.Drawing.Point(500, 45);
            this.lblUnitsOnOrderAdd.Name = "lblUnitsOnOrderAdd";
            this.lblUnitsOnOrderAdd.Size = new System.Drawing.Size(81, 13);
            this.lblUnitsOnOrderAdd.TabIndex = 50;
            this.lblUnitsOnOrderAdd.Text = "Sipariş Miktarı : ";
            // 
            // lblSupplierIdAdd
            // 
            this.lblSupplierIdAdd.AutoSize = true;
            this.lblSupplierIdAdd.Location = new System.Drawing.Point(493, 18);
            this.lblSupplierIdAdd.Name = "lblSupplierIdAdd";
            this.lblSupplierIdAdd.Size = new System.Drawing.Size(88, 13);
            this.lblSupplierIdAdd.TabIndex = 51;
            this.lblSupplierIdAdd.Text = "Tedarikçi Firma : ";
            // 
            // tbxUnitsOnOrderAdd
            // 
            this.tbxUnitsOnOrderAdd.Location = new System.Drawing.Point(587, 42);
            this.tbxUnitsOnOrderAdd.Name = "tbxUnitsOnOrderAdd";
            this.tbxUnitsOnOrderAdd.Size = new System.Drawing.Size(351, 20);
            this.tbxUnitsOnOrderAdd.TabIndex = 56;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(90, 93);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(364, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 23;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(90, 14);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(364, 20);
            this.tbxProductNameUpdate.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(963, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 44);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxSupplierNameAdd
            // 
            this.cbxSupplierNameAdd.BackColor = System.Drawing.Color.White;
            this.cbxSupplierNameAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplierNameAdd.FormattingEnabled = true;
            this.cbxSupplierNameAdd.Location = new System.Drawing.Point(587, 15);
            this.cbxSupplierNameAdd.Name = "cbxSupplierNameAdd";
            this.cbxSupplierNameAdd.Size = new System.Drawing.Size(351, 21);
            this.cbxSupplierNameAdd.TabIndex = 44;
            // 
            // cbxCategoryNameAdd
            // 
            this.cbxCategoryNameAdd.BackColor = System.Drawing.Color.White;
            this.cbxCategoryNameAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoryNameAdd.FormattingEnabled = true;
            this.cbxCategoryNameAdd.Location = new System.Drawing.Point(90, 41);
            this.cbxCategoryNameAdd.Name = "cbxCategoryNameAdd";
            this.cbxCategoryNameAdd.Size = new System.Drawing.Size(364, 21);
            this.cbxCategoryNameAdd.TabIndex = 44;
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(16, 124);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(68, 13);
            this.lblStockAmountAdd.TabIndex = 38;
            this.lblStockAmountAdd.Text = "Stok Adedi : ";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(12, 99);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(72, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 39;
            this.lblQuantityPerUnitAdd.Text = "Birim Miktarı : ";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(29, 45);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(55, 13);
            this.lblCategoryIdAdd.TabIndex = 40;
            this.lblCategoryIdAdd.Text = "Kategori : ";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(18, 71);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(66, 13);
            this.lblUnitPriceUpdate.TabIndex = 18;
            this.lblUnitPriceUpdate.Text = "Ürün Fiyatı : ";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(27, 17);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(57, 13);
            this.lblProductNameUpdate.TabIndex = 19;
            this.lblProductNameUpdate.Text = "Ürün Adı : ";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(90, 119);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(364, 20);
            this.tbxStockAmountUpdate.TabIndex = 24;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(18, 72);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(66, 13);
            this.lblUnitPriceAdd.TabIndex = 41;
            this.lblUnitPriceAdd.Text = "Ürün Fiyatı : ";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(27, 18);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(57, 13);
            this.lblProductNameAdd.TabIndex = 42;
            this.lblProductNameAdd.Text = "Ürün Adı : ";
            // 
            // cbxCategoryNameUpdate
            // 
            this.cbxCategoryNameUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoryNameUpdate.FormattingEnabled = true;
            this.cbxCategoryNameUpdate.Location = new System.Drawing.Point(90, 40);
            this.cbxCategoryNameUpdate.Name = "cbxCategoryNameUpdate";
            this.cbxCategoryNameUpdate.Size = new System.Drawing.Size(364, 21);
            this.cbxCategoryNameUpdate.TabIndex = 21;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(16, 123);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(68, 13);
            this.lblStockAmountUpdate.TabIndex = 15;
            this.lblStockAmountUpdate.Text = "Stok Adedi : ";
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(12, 98);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(72, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 16;
            this.lblQuantityPerUnitUpdate.Text = "Birim Miktarı : ";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(29, 44);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(55, 13);
            this.lblCategoryUpdate.TabIndex = 17;
            this.lblCategoryUpdate.Text = "Kategori : ";
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(90, 120);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(364, 20);
            this.tbxStockAmountAdd.TabIndex = 47;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(90, 68);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(364, 20);
            this.tbxUnitPriceAdd.TabIndex = 45;
            // 
            // tbxSearchProductName
            // 
            this.tbxSearchProductName.Location = new System.Drawing.Point(71, 22);
            this.tbxSearchProductName.Name = "tbxSearchProductName";
            this.tbxSearchProductName.Size = new System.Drawing.Size(338, 20);
            this.tbxSearchProductName.TabIndex = 0;
            this.tbxSearchProductName.TextChanged += new System.EventHandler(this.tbxSearchProductName_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(57, 20);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(344, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblListByCategory
            // 
            this.lblListByCategory.AutoSize = true;
            this.lblListByCategory.Location = new System.Drawing.Point(6, 23);
            this.lblListByCategory.Name = "lblListByCategory";
            this.lblListByCategory.Size = new System.Drawing.Size(55, 13);
            this.lblListByCategory.TabIndex = 2;
            this.lblListByCategory.Text = "Kategori : ";
            // 
            // lblDiscontinuedUpdate
            // 
            this.lblDiscontinuedUpdate.AutoSize = true;
            this.lblDiscontinuedUpdate.Location = new System.Drawing.Point(482, 96);
            this.lblDiscontinuedUpdate.Name = "lblDiscontinuedUpdate";
            this.lblDiscontinuedUpdate.Size = new System.Drawing.Size(101, 13);
            this.lblDiscontinuedUpdate.TabIndex = 33;
            this.lblDiscontinuedUpdate.Text = "Üretim Durduruldu : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(7, 25);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(57, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ürün Adı : ";
            // 
            // tbcProduct
            // 
            this.tbcProduct.Controls.Add(this.tbpAddProduct);
            this.tbcProduct.Controls.Add(this.tbpUpdateProduct);
            this.tbcProduct.Location = new System.Drawing.Point(12, 444);
            this.tbcProduct.Name = "tbcProduct";
            this.tbcProduct.SelectedIndex = 0;
            this.tbcProduct.Size = new System.Drawing.Size(1068, 204);
            this.tbcProduct.TabIndex = 19;
            // 
            // tbpAddProduct
            // 
            this.tbpAddProduct.Controls.Add(this.cbxDiscontinuedAdd);
            this.tbpAddProduct.Controls.Add(this.lblDiscontinuedAdd);
            this.tbpAddProduct.Controls.Add(this.lblReorderLevelAdd);
            this.tbpAddProduct.Controls.Add(this.lblUnitsOnOrderAdd);
            this.tbpAddProduct.Controls.Add(this.lblSupplierIdAdd);
            this.tbpAddProduct.Controls.Add(this.tbxReorderLevelAdd);
            this.tbpAddProduct.Controls.Add(this.tbxUnitsOnOrderAdd);
            this.tbpAddProduct.Controls.Add(this.btnAdd);
            this.tbpAddProduct.Controls.Add(this.cbxSupplierNameAdd);
            this.tbpAddProduct.Controls.Add(this.cbxCategoryNameAdd);
            this.tbpAddProduct.Controls.Add(this.lblStockAmountAdd);
            this.tbpAddProduct.Controls.Add(this.lblQuantityPerUnitAdd);
            this.tbpAddProduct.Controls.Add(this.lblCategoryIdAdd);
            this.tbpAddProduct.Controls.Add(this.lblUnitPriceAdd);
            this.tbpAddProduct.Controls.Add(this.lblProductNameAdd);
            this.tbpAddProduct.Controls.Add(this.tbxStockAmountAdd);
            this.tbpAddProduct.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.tbpAddProduct.Controls.Add(this.tbxUnitPriceAdd);
            this.tbpAddProduct.Controls.Add(this.tbxProductNameAdd);
            this.tbpAddProduct.Location = new System.Drawing.Point(4, 22);
            this.tbpAddProduct.Name = "tbpAddProduct";
            this.tbpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddProduct.Size = new System.Drawing.Size(1060, 178);
            this.tbpAddProduct.TabIndex = 0;
            this.tbpAddProduct.Text = "Ürün Ekle";
            this.tbpAddProduct.UseVisualStyleBackColor = true;
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(90, 94);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(364, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 46;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(90, 15);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(364, 20);
            this.tbxProductNameAdd.TabIndex = 43;
            // 
            // tbpUpdateProduct
            // 
            this.tbpUpdateProduct.Controls.Add(this.cbxDiscontinuedUpdate);
            this.tbpUpdateProduct.Controls.Add(this.cbxSupplierNameUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblDiscontinuedUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblReorderLevelUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblUnitsOnOrderUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblSupplierIdUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxReorderLevelUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxUnitsOnOrderUpdate);
            this.tbpUpdateProduct.Controls.Add(this.btnUpdate);
            this.tbpUpdateProduct.Controls.Add(this.btnRemove);
            this.tbpUpdateProduct.Controls.Add(this.cbxCategoryNameUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblStockAmountUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblCategoryUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblUnitPriceUpdate);
            this.tbpUpdateProduct.Controls.Add(this.lblProductNameUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxStockAmountUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
            this.tbpUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
            this.tbpUpdateProduct.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdateProduct.Name = "tbpUpdateProduct";
            this.tbpUpdateProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdateProduct.Size = new System.Drawing.Size(1060, 178);
            this.tbpUpdateProduct.TabIndex = 1;
            this.tbpUpdateProduct.Text = "Ürün Güncelle";
            this.tbpUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // cbxDiscontinuedUpdate
            // 
            this.cbxDiscontinuedUpdate.AutoSize = true;
            this.cbxDiscontinuedUpdate.Location = new System.Drawing.Point(587, 96);
            this.cbxDiscontinuedUpdate.Name = "cbxDiscontinuedUpdate";
            this.cbxDiscontinuedUpdate.Size = new System.Drawing.Size(15, 14);
            this.cbxDiscontinuedUpdate.TabIndex = 46;
            this.cbxDiscontinuedUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxSupplierNameUpdate
            // 
            this.cbxSupplierNameUpdate.BackColor = System.Drawing.Color.White;
            this.cbxSupplierNameUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplierNameUpdate.FormattingEnabled = true;
            this.cbxSupplierNameUpdate.Location = new System.Drawing.Point(587, 14);
            this.cbxSupplierNameUpdate.Name = "cbxSupplierNameUpdate";
            this.cbxSupplierNameUpdate.Size = new System.Drawing.Size(349, 21);
            this.cbxSupplierNameUpdate.TabIndex = 45;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(90, 67);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(364, 20);
            this.tbxUnitPriceUpdate.TabIndex = 22;
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Controls.Add(this.tbxSearchProductName);
            this.gbxProductName.Location = new System.Drawing.Point(103, 10);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(415, 49);
            this.gbxProductName.TabIndex = 20;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Ara";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblListByCategory);
            this.gbxCategory.Location = new System.Drawing.Point(524, 11);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(407, 48);
            this.gbxCategory.TabIndex = 18;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategori";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(16, 67);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.Size = new System.Drawing.Size(1064, 371);
            this.dgwProducts.TabIndex = 21;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxReorderLevelAdd
            // 
            this.tbxReorderLevelAdd.Location = new System.Drawing.Point(587, 69);
            this.tbxReorderLevelAdd.Name = "tbxReorderLevelAdd";
            this.tbxReorderLevelAdd.Size = new System.Drawing.Size(351, 20);
            this.tbxReorderLevelAdd.TabIndex = 56;
            // 
            // lblReorderLevelAdd
            // 
            this.lblReorderLevelAdd.AutoSize = true;
            this.lblReorderLevelAdd.Location = new System.Drawing.Point(469, 72);
            this.lblReorderLevelAdd.Name = "lblReorderLevelAdd";
            this.lblReorderLevelAdd.Size = new System.Drawing.Size(112, 13);
            this.lblReorderLevelAdd.TabIndex = 50;
            this.lblReorderLevelAdd.Text = "Minimum Stok Adedi : ";
            // 
            // tbxReorderLevelUpdate
            // 
            this.tbxReorderLevelUpdate.Location = new System.Drawing.Point(587, 67);
            this.tbxReorderLevelUpdate.Name = "tbxReorderLevelUpdate";
            this.tbxReorderLevelUpdate.Size = new System.Drawing.Size(350, 20);
            this.tbxReorderLevelUpdate.TabIndex = 35;
            // 
            // lblReorderLevelUpdate
            // 
            this.lblReorderLevelUpdate.AutoSize = true;
            this.lblReorderLevelUpdate.Location = new System.Drawing.Point(469, 70);
            this.lblReorderLevelUpdate.Name = "lblReorderLevelUpdate";
            this.lblReorderLevelUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblReorderLevelUpdate.TabIndex = 29;
            this.lblReorderLevelUpdate.Text = "Minimum Stok Adedi : ";
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 652);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.tbcProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProducts_FormClosing);
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.tbcProduct.ResumeLayout(false);
            this.tbpAddProduct.ResumeLayout(false);
            this.tbpAddProduct.PerformLayout();
            this.tbpUpdateProduct.ResumeLayout(false);
            this.tbpUpdateProduct.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUnitsOnOrderUpdate;
        private System.Windows.Forms.Label lblSupplierIdUpdate;
        private System.Windows.Forms.TextBox tbxUnitsOnOrderUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbxDiscontinuedAdd;
        private System.Windows.Forms.Label lblDiscontinuedAdd;
        private System.Windows.Forms.Label lblUnitsOnOrderAdd;
        private System.Windows.Forms.Label lblSupplierIdAdd;
        private System.Windows.Forms.TextBox tbxUnitsOnOrderAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxSupplierNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryNameAdd;
        private System.Windows.Forms.Label lblStockAmountAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxSearchProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblListByCategory;
        private System.Windows.Forms.Label lblDiscontinuedUpdate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TabControl tbcProduct;
        private System.Windows.Forms.TabPage tbpAddProduct;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.TabPage tbpUpdateProduct;
        private System.Windows.Forms.ComboBox cbxSupplierNameUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.CheckBox cbxDiscontinuedUpdate;
        private System.Windows.Forms.Label lblReorderLevelAdd;
        private System.Windows.Forms.TextBox tbxReorderLevelAdd;
        private System.Windows.Forms.Label lblReorderLevelUpdate;
        private System.Windows.Forms.TextBox tbxReorderLevelUpdate;
    }
}