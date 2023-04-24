
namespace ShoppingSystem
{
    partial class returnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnForm));
            this.KVsplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RFExitButton = new System.Windows.Forms.Button();
            this.RFContinueButton = new System.Windows.Forms.Button();
            this.ProduktLista = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.returnFormGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).BeginInit();
            this.KVsplitContainer1.Panel1.SuspendLayout();
            this.KVsplitContainer1.Panel2.SuspendLayout();
            this.KVsplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KVsplitContainer1
            // 
            this.KVsplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.KVsplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KVsplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.KVsplitContainer1.Location = new System.Drawing.Point(0, 554);
            this.KVsplitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KVsplitContainer1.Name = "KVsplitContainer1";
            // 
            // KVsplitContainer1.Panel1
            // 
            this.KVsplitContainer1.Panel1.Controls.Add(this.RFExitButton);
            // 
            // KVsplitContainer1.Panel2
            // 
            this.KVsplitContainer1.Panel2.Controls.Add(this.RFContinueButton);
            this.KVsplitContainer1.Size = new System.Drawing.Size(1559, 74);
            this.KVsplitContainer1.SplitterDistance = 710;
            this.KVsplitContainer1.TabIndex = 6;
            // 
            // RFExitButton
            // 
            this.RFExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RFExitButton.FlatAppearance.BorderSize = 0;
            this.RFExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFExitButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RFExitButton.Image = global::ShoppingSystem.Properties.Resources.cancel;
            this.RFExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFExitButton.Location = new System.Drawing.Point(0, 0);
            this.RFExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RFExitButton.Name = "RFExitButton";
            this.RFExitButton.Padding = new System.Windows.Forms.Padding(280, 0, 0, 0);
            this.RFExitButton.Size = new System.Drawing.Size(710, 74);
            this.RFExitButton.TabIndex = 4;
            this.RFExitButton.Text = "    Avbryt";
            this.RFExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RFExitButton.UseVisualStyleBackColor = true;
            this.RFExitButton.Click += new System.EventHandler(this.KVRemoveButton_Click);
            // 
            // RFContinueButton
            // 
            this.RFContinueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RFContinueButton.FlatAppearance.BorderSize = 0;
            this.RFContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RFContinueButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFContinueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RFContinueButton.Image = global::ShoppingSystem.Properties.Resources.finish;
            this.RFContinueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFContinueButton.Location = new System.Drawing.Point(0, 0);
            this.RFContinueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RFContinueButton.Name = "RFContinueButton";
            this.RFContinueButton.Padding = new System.Windows.Forms.Padding(333, 0, 0, 0);
            this.RFContinueButton.Size = new System.Drawing.Size(845, 74);
            this.RFContinueButton.TabIndex = 4;
            this.RFContinueButton.Text = "    Visa kvitto och gå vidare";
            this.RFContinueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RFContinueButton.UseVisualStyleBackColor = true;
            this.RFContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ProduktLista
            // 
            this.ProduktLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduktLista.FormattingEnabled = true;
            this.ProduktLista.ItemHeight = 16;
            this.ProduktLista.Location = new System.Drawing.Point(0, 26);
            this.ProduktLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProduktLista.Name = "ProduktLista";
            this.ProduktLista.Size = new System.Drawing.Size(1557, 500);
            this.ProduktLista.TabIndex = 5;
            this.ProduktLista.SelectedIndexChanged += new System.EventHandler(this.ProduktLista_SelectedIndexChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // returnFormGridView
            // 
            this.returnFormGridView.AllowUserToAddRows = false;
            this.returnFormGridView.AllowUserToDeleteRows = false;
            this.returnFormGridView.AllowUserToResizeColumns = false;
            this.returnFormGridView.AllowUserToResizeRows = false;
            this.returnFormGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.returnFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnFormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnFormGridView.Location = new System.Drawing.Point(0, 17);
            this.returnFormGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnFormGridView.MultiSelect = false;
            this.returnFormGridView.Name = "returnFormGridView";
            this.returnFormGridView.ReadOnly = true;
            this.returnFormGridView.RowHeadersWidth = 51;
            this.returnFormGridView.RowTemplate.Height = 24;
            this.returnFormGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnFormGridView.Size = new System.Drawing.Size(1559, 537);
            this.returnFormGridView.StandardTab = true;
            this.returnFormGridView.TabIndex = 7;
            this.returnFormGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kundvagndataGridView_CellFormatting);
            // 
            // returnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1559, 628);
            this.Controls.Add(this.returnFormGridView);
            this.Controls.Add(this.KVsplitContainer1);
            this.Controls.Add(this.ProduktLista);
            this.Controls.Add(this.ListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1574, 603);
            this.Name = "returnForm";
            this.Text = "Shwep";
            this.KVsplitContainer1.Panel1.ResumeLayout(false);
            this.KVsplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).EndInit();
            this.KVsplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer KVsplitContainer1;
        private System.Windows.Forms.Button RFExitButton;
        private System.Windows.Forms.Button RFContinueButton;
        private System.Windows.Forms.ListBox ProduktLista;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.DataGridView returnFormGridView;
    }
}