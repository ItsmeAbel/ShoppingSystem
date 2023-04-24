
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
            this.productDatalistKassa = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.KundKorgButton = new System.Windows.Forms.Button();
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
            this.ListLabel.Location = new System.Drawing.Point(13, 14);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 668);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KundKorgButton);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 82);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 3;
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
            this.productDatalistKassa.Location = new System.Drawing.Point(0, 33);
            this.productDatalistKassa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDatalistKassa.MultiSelect = false;
            this.productDatalistKassa.Name = "productDatalistKassa";
            this.productDatalistKassa.ReadOnly = true;
            this.productDatalistKassa.RowHeadersVisible = false;
            this.productDatalistKassa.RowHeadersWidth = 51;
            this.productDatalistKassa.RowTemplate.Height = 24;
            this.productDatalistKassa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDatalistKassa.Size = new System.Drawing.Size(1484, 634);
            this.productDatalistKassa.TabIndex = 4;
            this.productDatalistKassa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDatalistKassa_CellFormatting);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(308, 4);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(256, 22);
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
            this.searchComboBox.Location = new System.Drawing.Point(127, 4);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(160, 24);
            this.searchComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1375, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Returlista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.returnButton.Location = new System.Drawing.Point(1276, 0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(93, 31);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Returnera";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
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
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(280, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(704, 82);
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
            this.KundKorgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KundKorgButton.Name = "KundKorgButton";
            this.KundKorgButton.Padding = new System.Windows.Forms.Padding(333, 0, 0, 0);
            this.KundKorgButton.Size = new System.Drawing.Size(776, 82);
            this.KundKorgButton.TabIndex = 4;
            this.KundKorgButton.Text = "  Kundkorg";
            this.KundKorgButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KundKorgButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KundKorgButton.UseVisualStyleBackColor = true;
            this.KundKorgButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1484, 750);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.productDatalistKassa);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(741, 584);
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
    }
}