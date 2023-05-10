
namespace ShoppingSystem
{
    partial class KassaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KassaForm));
            this.ListLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Add = new System.Windows.Forms.Button();
            this.KundKorgButton = new System.Windows.Forms.Button();
            this.productDatalistKassa = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.kassaHistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistKassa)).BeginInit();
            this.SuspendLayout();
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ListLabel.Location = new System.Drawing.Point(10, 11);
            this.ListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(69, 13);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 542);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KundKorgButton);
            this.splitContainer1.Size = new System.Drawing.Size(1113, 67);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Add.Image = global::ShoppingSystem.Properties.Resources.add;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(0, 0);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(210, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(528, 67);
            this.Add.TabIndex = 4;
            this.Add.Text = "  Köp";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // KundKorgButton
            // 
            this.KundKorgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundKorgButton.FlatAppearance.BorderSize = 0;
            this.KundKorgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundKorgButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KundKorgButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KundKorgButton.Image = global::ShoppingSystem.Properties.Resources.go;
            this.KundKorgButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KundKorgButton.Location = new System.Drawing.Point(0, 0);
            this.KundKorgButton.Margin = new System.Windows.Forms.Padding(2);
            this.KundKorgButton.Name = "KundKorgButton";
            this.KundKorgButton.Padding = new System.Windows.Forms.Padding(250, 0, 0, 0);
            this.KundKorgButton.Size = new System.Drawing.Size(582, 67);
            this.KundKorgButton.TabIndex = 4;
            this.KundKorgButton.Text = "  Kundkorg";
            this.KundKorgButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KundKorgButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KundKorgButton.UseVisualStyleBackColor = true;
            this.KundKorgButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // productDatalistKassa
            // 
            this.productDatalistKassa.AllowUserToAddRows = false;
            this.productDatalistKassa.AllowUserToDeleteRows = false;
            this.productDatalistKassa.AllowUserToResizeColumns = false;
            this.productDatalistKassa.AllowUserToResizeRows = false;
            this.productDatalistKassa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatalistKassa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.productDatalistKassa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDatalistKassa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDatalistKassa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productDatalistKassa.Location = new System.Drawing.Point(0, 27);
            this.productDatalistKassa.Margin = new System.Windows.Forms.Padding(2);
            this.productDatalistKassa.MultiSelect = false;
            this.productDatalistKassa.Name = "productDatalistKassa";
            this.productDatalistKassa.ReadOnly = true;
            this.productDatalistKassa.RowHeadersVisible = false;
            this.productDatalistKassa.RowHeadersWidth = 51;
            this.productDatalistKassa.RowTemplate.Height = 24;
            this.productDatalistKassa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDatalistKassa.Size = new System.Drawing.Size(1113, 515);
            this.productDatalistKassa.TabIndex = 4;
            this.productDatalistKassa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDatalistKassa_CellFormatting);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(231, 3);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(193, 20);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchComboBox
            // 
            this.searchComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "id",
            "name",
            "price",
            "type",
            "author",
            "genre",
            "format",
            "language",
            "platform",
            "playtime"});
            this.searchComboBox.Location = new System.Drawing.Point(95, 3);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1031, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Returlista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.returnButton.Location = new System.Drawing.Point(957, 0);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(70, 25);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Returnera";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // kassaHistoryButton
            // 
            this.kassaHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kassaHistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kassaHistoryButton.Location = new System.Drawing.Point(544, 0);
            this.kassaHistoryButton.Name = "kassaHistoryButton";
            this.kassaHistoryButton.Size = new System.Drawing.Size(104, 25);
            this.kassaHistoryButton.TabIndex = 8;
            this.kassaHistoryButton.Text = "Visa Historik";
            this.kassaHistoryButton.UseVisualStyleBackColor = true;
            this.kassaHistoryButton.Click += new System.EventHandler(this.kassaHistoryButton_Click_1);
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1113, 609);
            this.Controls.Add(this.kassaHistoryButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.productDatalistKassa);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(560, 482);
            this.Name = "KassaForm";
            this.Text = "Shewp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistKassa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button KundKorgButton;
        private System.Windows.Forms.DataGridView productDatalistKassa;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button kassaHistoryButton;
    }
}