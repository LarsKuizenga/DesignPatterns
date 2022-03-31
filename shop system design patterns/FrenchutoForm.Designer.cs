
namespace FrenchutoShop
{
    partial class FrenchutoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLogListBox = new System.Windows.Forms.ListBox();
            this.timeSkipButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.startNewStoreButton = new System.Windows.Forms.Button();
            this.shelvesListView = new System.Windows.Forms.ListView();
            this.shelveId = new System.Windows.Forms.ColumnHeader();
            this.shelveCategory = new System.Windows.Forms.ColumnHeader();
            this.amountOfItems = new System.Windows.Forms.ColumnHeader();
            this.storeStateLabel = new System.Windows.Forms.Label();
            this.storeStateTabControl = new System.Windows.Forms.TabControl();
            this.shelvesTab = new System.Windows.Forms.TabPage();
            this.stockersTab = new System.Windows.Forms.TabPage();
            this.stockersListView = new System.Windows.Forms.ListView();
            this.stockerName = new System.Windows.Forms.ColumnHeader();
            this.stockerTask = new System.Windows.Forms.ColumnHeader();
            this.stockerTimeLeft = new System.Windows.Forms.ColumnHeader();
            this.stockerShelveId = new System.Windows.Forms.ColumnHeader();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersListView = new System.Windows.Forms.ListView();
            this.customerName = new System.Windows.Forms.ColumnHeader();
            this.customerTask = new System.Windows.Forms.ColumnHeader();
            this.customerTaskLeft = new System.Windows.Forms.ColumnHeader();
            this.customerShelve = new System.Windows.Forms.ColumnHeader();
            this.warehouseTab = new System.Windows.Forms.TabPage();
            this.warehouseListView = new System.Windows.Forms.ListView();
            this.warehouseProductCategory = new System.Windows.Forms.ColumnHeader();
            this.warehouseProductAmount = new System.Windows.Forms.ColumnHeader();
            this.storeStateTabControl.SuspendLayout();
            this.shelvesTab.SuspendLayout();
            this.stockersTab.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.warehouseTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLogListBox
            // 
            this.eventLogListBox.FormattingEnabled = true;
            this.eventLogListBox.ItemHeight = 15;
            this.eventLogListBox.Location = new System.Drawing.Point(591, 95);
            this.eventLogListBox.Name = "eventLogListBox";
            this.eventLogListBox.Size = new System.Drawing.Size(561, 574);
            this.eventLogListBox.TabIndex = 0;
            // 
            // timeSkipButton
            // 
            this.timeSkipButton.BackColor = System.Drawing.Color.Teal;
            this.timeSkipButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeSkipButton.ForeColor = System.Drawing.SystemColors.Control;
            this.timeSkipButton.Location = new System.Drawing.Point(591, 11);
            this.timeSkipButton.Name = "timeSkipButton";
            this.timeSkipButton.Size = new System.Drawing.Size(293, 77);
            this.timeSkipButton.TabIndex = 1;
            this.timeSkipButton.Text = "Skip 1 hour";
            this.timeSkipButton.UseVisualStyleBackColor = false;
            this.timeSkipButton.Click += new System.EventHandler(this.TimeSkip_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.BackColor = System.Drawing.Color.SteelBlue;
            this.clearLogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLogButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearLogButton.Location = new System.Drawing.Point(890, 53);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(262, 36);
            this.clearLogButton.TabIndex = 2;
            this.clearLogButton.Text = "Clear eventlog";
            this.clearLogButton.UseVisualStyleBackColor = false;
            this.clearLogButton.Click += new System.EventHandler(this.ClearEventLog_Click);
            // 
            // startNewStoreButton
            // 
            this.startNewStoreButton.BackColor = System.Drawing.Color.SteelBlue;
            this.startNewStoreButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startNewStoreButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startNewStoreButton.Location = new System.Drawing.Point(890, 11);
            this.startNewStoreButton.Name = "startNewStoreButton";
            this.startNewStoreButton.Size = new System.Drawing.Size(262, 36);
            this.startNewStoreButton.TabIndex = 4;
            this.startNewStoreButton.Text = "Start new store";
            this.startNewStoreButton.UseVisualStyleBackColor = false;
            this.startNewStoreButton.Click += new System.EventHandler(this.StartNewStoreButton_Click);
            // 
            // shelvesListView
            // 
            this.shelvesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shelveId,
            this.shelveCategory,
            this.amountOfItems});
            this.shelvesListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shelvesListView.HideSelection = false;
            this.shelvesListView.Location = new System.Drawing.Point(6, 6);
            this.shelvesListView.Name = "shelvesListView";
            this.shelvesListView.Size = new System.Drawing.Size(541, 583);
            this.shelvesListView.TabIndex = 5;
            this.shelvesListView.UseCompatibleStateImageBehavior = false;
            this.shelvesListView.View = System.Windows.Forms.View.Details;
            // 
            // shelveId
            // 
            this.shelveId.Text = "ID";
            this.shelveId.Width = 120;
            // 
            // shelveCategory
            // 
            this.shelveCategory.Text = "Category";
            this.shelveCategory.Width = 240;
            // 
            // amountOfItems
            // 
            this.amountOfItems.Text = "Amount";
            this.amountOfItems.Width = 160;
            // 
            // storeStateLabel
            // 
            this.storeStateLabel.AutoSize = true;
            this.storeStateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storeStateLabel.Location = new System.Drawing.Point(12, 11);
            this.storeStateLabel.Name = "storeStateLabel";
            this.storeStateLabel.Size = new System.Drawing.Size(127, 32);
            this.storeStateLabel.TabIndex = 6;
            this.storeStateLabel.Text = "Store state";
            // 
            // storeStateTabControl
            // 
            this.storeStateTabControl.Controls.Add(this.shelvesTab);
            this.storeStateTabControl.Controls.Add(this.stockersTab);
            this.storeStateTabControl.Controls.Add(this.customersTab);
            this.storeStateTabControl.Controls.Add(this.warehouseTab);
            this.storeStateTabControl.Location = new System.Drawing.Point(12, 46);
            this.storeStateTabControl.Name = "storeStateTabControl";
            this.storeStateTabControl.SelectedIndex = 0;
            this.storeStateTabControl.Size = new System.Drawing.Size(561, 623);
            this.storeStateTabControl.TabIndex = 7;
            // 
            // shelvesTab
            // 
            this.shelvesTab.Controls.Add(this.shelvesListView);
            this.shelvesTab.Location = new System.Drawing.Point(4, 24);
            this.shelvesTab.Name = "shelvesTab";
            this.shelvesTab.Padding = new System.Windows.Forms.Padding(3);
            this.shelvesTab.Size = new System.Drawing.Size(553, 595);
            this.shelvesTab.TabIndex = 0;
            this.shelvesTab.Text = "Shelves";
            this.shelvesTab.UseVisualStyleBackColor = true;
            // 
            // stockersTab
            // 
            this.stockersTab.Controls.Add(this.stockersListView);
            this.stockersTab.Location = new System.Drawing.Point(4, 24);
            this.stockersTab.Name = "stockersTab";
            this.stockersTab.Padding = new System.Windows.Forms.Padding(3);
            this.stockersTab.Size = new System.Drawing.Size(553, 595);
            this.stockersTab.TabIndex = 1;
            this.stockersTab.Text = "Stockers";
            this.stockersTab.UseVisualStyleBackColor = true;
            // 
            // stockersListView
            // 
            this.stockersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stockerName,
            this.stockerTask,
            this.stockerTimeLeft,
            this.stockerShelveId});
            this.stockersListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockersListView.HideSelection = false;
            this.stockersListView.Location = new System.Drawing.Point(6, 6);
            this.stockersListView.Name = "stockersListView";
            this.stockersListView.Size = new System.Drawing.Size(541, 583);
            this.stockersListView.TabIndex = 8;
            this.stockersListView.UseCompatibleStateImageBehavior = false;
            this.stockersListView.View = System.Windows.Forms.View.Details;
            // 
            // stockerName
            // 
            this.stockerName.Text = "Name";
            this.stockerName.Width = 200;
            // 
            // stockerTask
            // 
            this.stockerTask.Text = "Task";
            this.stockerTask.Width = 80;
            // 
            // stockerTimeLeft
            // 
            this.stockerTimeLeft.Text = "Time left";
            this.stockerTimeLeft.Width = 80;
            // 
            // stockerShelveId
            // 
            this.stockerShelveId.Text = "Shelve ID";
            this.stockerShelveId.Width = 160;
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.customersListView);
            this.customersTab.Location = new System.Drawing.Point(4, 24);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(553, 595);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // customersListView
            // 
            this.customersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerName,
            this.customerTask,
            this.customerTaskLeft,
            this.customerShelve});
            this.customersListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersListView.HideSelection = false;
            this.customersListView.Location = new System.Drawing.Point(6, 6);
            this.customersListView.Name = "customersListView";
            this.customersListView.Size = new System.Drawing.Size(541, 583);
            this.customersListView.TabIndex = 9;
            this.customersListView.UseCompatibleStateImageBehavior = false;
            this.customersListView.View = System.Windows.Forms.View.Details;
            // 
            // customerName
            // 
            this.customerName.Text = "Name";
            this.customerName.Width = 200;
            // 
            // customerTask
            // 
            this.customerTask.Text = "Task";
            this.customerTask.Width = 80;
            // 
            // customerTaskLeft
            // 
            this.customerTaskLeft.Text = "Time left";
            this.customerTaskLeft.Width = 80;
            // 
            // customerShelve
            // 
            this.customerShelve.Text = "Shelve ID";
            this.customerShelve.Width = 160;
            // 
            // warehouseTab
            // 
            this.warehouseTab.Controls.Add(this.warehouseListView);
            this.warehouseTab.Location = new System.Drawing.Point(4, 24);
            this.warehouseTab.Name = "warehouseTab";
            this.warehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseTab.Size = new System.Drawing.Size(553, 595);
            this.warehouseTab.TabIndex = 3;
            this.warehouseTab.Text = "Warehouse";
            this.warehouseTab.UseVisualStyleBackColor = true;
            // 
            // warehouseListView
            // 
            this.warehouseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.warehouseProductCategory,
            this.warehouseProductAmount});
            this.warehouseListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warehouseListView.HideSelection = false;
            this.warehouseListView.Location = new System.Drawing.Point(6, 6);
            this.warehouseListView.Name = "warehouseListView";
            this.warehouseListView.Size = new System.Drawing.Size(541, 583);
            this.warehouseListView.TabIndex = 0;
            this.warehouseListView.UseCompatibleStateImageBehavior = false;
            this.warehouseListView.View = System.Windows.Forms.View.Details;
            // 
            // warehouseProductCategory
            // 
            this.warehouseProductCategory.Text = "Product category";
            this.warehouseProductCategory.Width = 320;
            // 
            // warehouseProductAmount
            // 
            this.warehouseProductAmount.Text = "Amount";
            this.warehouseProductAmount.Width = 200;
            // 
            // FrenchutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.storeStateTabControl);
            this.Controls.Add(this.storeStateLabel);
            this.Controls.Add(this.startNewStoreButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.timeSkipButton);
            this.Controls.Add(this.eventLogListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrenchutoForm";
            this.Text = "Frenchuto Store";
            this.storeStateTabControl.ResumeLayout(false);
            this.shelvesTab.ResumeLayout(false);
            this.stockersTab.ResumeLayout(false);
            this.customersTab.ResumeLayout(false);
            this.warehouseTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button timeSkipButton;
		private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Button startNewStoreButton;
        public System.Windows.Forms.ListView shelvesListView;
        private System.Windows.Forms.ColumnHeader shelveId;
        private System.Windows.Forms.ColumnHeader shelveCategory;
        private System.Windows.Forms.ColumnHeader amountOfItems;
        private System.Windows.Forms.Label storeStateLabel;
        private System.Windows.Forms.TabControl storeStateTabControl;
        private System.Windows.Forms.TabPage shelvesTab;
        private System.Windows.Forms.TabPage stockersTab;
        public System.Windows.Forms.ListView stockersListView;
        private System.Windows.Forms.ColumnHeader stockerName;
        private System.Windows.Forms.ColumnHeader stockerTask;
        private System.Windows.Forms.ColumnHeader stockerTimeLeft;
        private System.Windows.Forms.ColumnHeader stockerShelveId;
        private System.Windows.Forms.TabPage customersTab;
        public System.Windows.Forms.ListView customersListView;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader customerTask;
        private System.Windows.Forms.ColumnHeader customerTaskLeft;
        private System.Windows.Forms.ColumnHeader customerShelve;
        private System.Windows.Forms.TabPage warehouseTab;
        public System.Windows.Forms.ListView warehouseListView;
        private System.Windows.Forms.ColumnHeader warehouseProductCategory;
        private System.Windows.Forms.ColumnHeader warehouseProductAmount;
        public System.Windows.Forms.ListBox eventLogListBox;
    }
}

