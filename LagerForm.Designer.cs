
namespace ShoppingSystem
{
    partial class LagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.addToLagerButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ContinueButtton = new System.Windows.Forms.Button();
            this.GrossitButton = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.productDatalistLager = new System.Windows.Forms.DataGridView();
            this.LagerFormbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistLager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LagerFormbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 668);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 82);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.addToLagerButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.RemoveButton);
            this.splitContainer3.Size = new System.Drawing.Size(570, 82);
            this.splitContainer3.SplitterDistance = 272;
            this.splitContainer3.TabIndex = 8;
            // 
            // addToLagerButton
            // 
            this.addToLagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addToLagerButton.Location = new System.Drawing.Point(0, 0);
            this.addToLagerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToLagerButton.Name = "addToLagerButton";
            this.addToLagerButton.Size = new System.Drawing.Size(272, 82);
            this.addToLagerButton.TabIndex = 0;
            this.addToLagerButton.Text = "Lägg Ny Produkt";
            this.addToLagerButton.UseVisualStyleBackColor = true;
            this.addToLagerButton.Click += new System.EventHandler(this.addToLagerButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(294, 82);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Ta Bort";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GrossitButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ContinueButtton);
            this.splitContainer2.Size = new System.Drawing.Size(910, 82);
            this.splitContainer2.SplitterDistance = 447;
            this.splitContainer2.TabIndex = 7;
            // 
            // ContinueButtton
            // 
            this.ContinueButtton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueButtton.Location = new System.Drawing.Point(0, 0);
            this.ContinueButtton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContinueButtton.Name = "ContinueButtton";
            this.ContinueButtton.Size = new System.Drawing.Size(459, 82);
            this.ContinueButtton.TabIndex = 4;
            this.ContinueButtton.Text = "Stäng";
            this.ContinueButtton.UseVisualStyleBackColor = true;
            this.ContinueButtton.Click += new System.EventHandler(this.ContinueButtton_Click);
            // 
            // GrossitButton
            // 
            this.GrossitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossitButton.Location = new System.Drawing.Point(0, 0);
            this.GrossitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrossitButton.Name = "GrossitButton";
            this.GrossitButton.Size = new System.Drawing.Size(447, 82);
            this.GrossitButton.TabIndex = 5;
            this.GrossitButton.Text = "Grossit";
            this.GrossitButton.UseVisualStyleBackColor = true;
            this.GrossitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(-3, 7);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // productDatalistLager
            // 
            this.productDatalistLager.AllowUserToAddRows = false;
            this.productDatalistLager.AllowUserToDeleteRows = false;
            this.productDatalistLager.AllowUserToResizeColumns = false;
            this.productDatalistLager.AllowUserToResizeRows = false;
            this.productDatalistLager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatalistLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDatalistLager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDatalistLager.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productDatalistLager.Location = new System.Drawing.Point(0, 28);
            this.productDatalistLager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDatalistLager.MultiSelect = false;
            this.productDatalistLager.Name = "productDatalistLager";
            this.productDatalistLager.ReadOnly = true;
            this.productDatalistLager.RowHeadersVisible = false;
            this.productDatalistLager.RowHeadersWidth = 51;
            this.productDatalistLager.RowTemplate.Height = 24;
            this.productDatalistLager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDatalistLager.ShowCellErrors = false;
            this.productDatalistLager.ShowCellToolTips = false;
            this.productDatalistLager.ShowEditingIcon = false;
            this.productDatalistLager.ShowRowErrors = false;
            this.productDatalistLager.Size = new System.Drawing.Size(1484, 626);
            this.productDatalistLager.TabIndex = 7;
            this.productDatalistLager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDatalistLager_CellContentClick);
            // 
            // LagerFormbindingSource
            // 
            this.LagerFormbindingSource.CurrentChanged += new System.EventHandler(this.LagerFormbindingSource_CurrentChanged);
            // 
            // LagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 750);
            this.Controls.Add(this.productDatalistLager);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1439, 600);
            this.Name = "LagerForm";
            this.Text = "LagerForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistLager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LagerFormbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ContinueButtton;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button GrossitButton;
        private System.Windows.Forms.DataGridView productDatalistLager;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button addToLagerButton;
        private System.Windows.Forms.BindingSource LagerFormbindingSource;
    }
}