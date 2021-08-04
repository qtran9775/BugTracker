namespace BugTracker
{
    partial class mainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label bug_TypeLabel;
            System.Windows.Forms.Label prorityLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label statusLabel;
            this.issueDateDataSet = new BugTracker.issueDateDataSet();
            this.issueDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueDataTableAdapter = new BugTracker.issueDateDataSetTableAdapters.issueDataTableAdapter();
            this.tableAdapterManager = new BugTracker.issueDateDataSetTableAdapters.TableAdapterManager();
            this.issueDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.issueDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.bug_TypeTextBox = new System.Windows.Forms.TextBox();
            this.prorityTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            bug_TypeLabel = new System.Windows.Forms.Label();
            prorityLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataBindingNavigator)).BeginInit();
            this.issueDataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueDateDataSet
            // 
            this.issueDateDataSet.DataSetName = "issueDateDataSet";
            this.issueDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueDataBindingSource
            // 
            this.issueDataBindingSource.DataMember = "issueData";
            this.issueDataBindingSource.DataSource = this.issueDateDataSet;
            // 
            // issueDataTableAdapter
            // 
            this.issueDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.issueDataTableAdapter = this.issueDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = BugTracker.issueDateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issueDataBindingNavigator
            // 
            this.issueDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issueDataBindingNavigator.BindingSource = this.issueDataBindingSource;
            this.issueDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issueDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issueDataBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.issueDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.issueDataBindingNavigatorSaveItem});
            this.issueDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issueDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issueDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issueDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issueDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issueDataBindingNavigator.Name = "issueDataBindingNavigator";
            this.issueDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issueDataBindingNavigator.Size = new System.Drawing.Size(820, 31);
            this.issueDataBindingNavigator.TabIndex = 0;
            this.issueDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // issueDataBindingNavigatorSaveItem
            // 
            this.issueDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issueDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issueDataBindingNavigatorSaveItem.Image")));
            this.issueDataBindingNavigatorSaveItem.Name = "issueDataBindingNavigatorSaveItem";
            this.issueDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.issueDataBindingNavigatorSaveItem.Text = "Save Data";
            this.issueDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.issueDataBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(71, 153);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueDataBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(160, 150);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(603, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(71, 181);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(77, 17);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueDataBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(160, 178);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(603, 22);
            this.usernameTextBox.TabIndex = 5;
            // 
            // bug_TypeLabel
            // 
            bug_TypeLabel.AutoSize = true;
            bug_TypeLabel.Location = new System.Drawing.Point(71, 209);
            bug_TypeLabel.Name = "bug_TypeLabel";
            bug_TypeLabel.Size = new System.Drawing.Size(73, 17);
            bug_TypeLabel.TabIndex = 6;
            bug_TypeLabel.Text = "Bug Type:";
            // 
            // bug_TypeTextBox
            // 
            this.bug_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueDataBindingSource, "Bug Type", true));
            this.bug_TypeTextBox.Location = new System.Drawing.Point(160, 206);
            this.bug_TypeTextBox.Name = "bug_TypeTextBox";
            this.bug_TypeTextBox.Size = new System.Drawing.Size(603, 22);
            this.bug_TypeTextBox.TabIndex = 7;
            // 
            // prorityLabel
            // 
            prorityLabel.AutoSize = true;
            prorityLabel.Location = new System.Drawing.Point(71, 237);
            prorityLabel.Name = "prorityLabel";
            prorityLabel.Size = new System.Drawing.Size(53, 17);
            prorityLabel.TabIndex = 8;
            prorityLabel.Text = "Prority:";
            // 
            // prorityTextBox
            // 
            this.prorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueDataBindingSource, "Prority", true));
            this.prorityTextBox.Location = new System.Drawing.Point(160, 234);
            this.prorityTextBox.Name = "prorityTextBox";
            this.prorityTextBox.Size = new System.Drawing.Size(603, 22);
            this.prorityTextBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(71, 265);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueDataBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(160, 262);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(603, 22);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(71, 295);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.issueDataBindingSource, "Status", true));
            this.statusCheckBox.Location = new System.Drawing.Point(160, 290);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(603, 38);
            this.statusCheckBox.TabIndex = 13;
            this.statusCheckBox.Text = "checkBox1";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(347, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Issues";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Issues Lists";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(bug_TypeLabel);
            this.Controls.Add(this.bug_TypeTextBox);
            this.Controls.Add(prorityLabel);
            this.Controls.Add(this.prorityTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.issueDataBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainPage";
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataBindingNavigator)).EndInit();
            this.issueDataBindingNavigator.ResumeLayout(false);
            this.issueDataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private issueDateDataSet issueDateDataSet;
        private System.Windows.Forms.BindingSource issueDataBindingSource;
        private issueDateDataSetTableAdapters.issueDataTableAdapter issueDataTableAdapter;
        private issueDateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issueDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton issueDataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox bug_TypeTextBox;
        private System.Windows.Forms.TextBox prorityTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}