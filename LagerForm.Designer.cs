
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ContinueButtton = new System.Windows.Forms.Button();
            this.GrossitButton = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.productDatalistLager = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.addToLagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistLager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 456);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(877, 83);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 6;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(171, 83);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Ta Bort";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ContinueButtton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GrossitButton);
            this.splitContainer2.Size = new System.Drawing.Size(534, 83);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 7;
            // 
            // ContinueButtton
            // 
            this.ContinueButtton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueButtton.Location = new System.Drawing.Point(0, 0);
            this.ContinueButtton.Name = "ContinueButtton";
            this.ContinueButtton.Size = new System.Drawing.Size(264, 83);
            this.ContinueButtton.TabIndex = 4;
            this.ContinueButtton.Text = "Visa Kundkorg";
            this.ContinueButtton.UseVisualStyleBackColor = true;
            this.ContinueButtton.Click += new System.EventHandler(this.ContinueButtton_Click);
            // 
            // GrossitButton
            // 
            this.GrossitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossitButton.Location = new System.Drawing.Point(0, 0);
            this.GrossitButton.Name = "GrossitButton";
            this.GrossitButton.Size = new System.Drawing.Size(266, 83);
            this.GrossitButton.TabIndex = 5;
            this.GrossitButton.Text = "Grossit";
            this.GrossitButton.UseVisualStyleBackColor = true;
            this.GrossitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(-2, 7);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // productDatalistLager
            // 
            this.productDatalistLager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatalistLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDatalistLager.Location = new System.Drawing.Point(0, 28);
            this.productDatalistLager.Name = "productDatalistLager";
            this.productDatalistLager.RowHeadersWidth = 51;
            this.productDatalistLager.RowTemplate.Height = 24;
            this.productDatalistLager.Size = new System.Drawing.Size(877, 422);
            this.productDatalistLager.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.addToLagerButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.RemoveButton);
            this.splitContainer3.Size = new System.Drawing.Size(339, 83);
            this.splitContainer3.SplitterDistance = 164;
            this.splitContainer3.TabIndex = 8;
            // 
            // addToLagerButton
            // 
            this.addToLagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addToLagerButton.Location = new System.Drawing.Point(0, 0);
            this.addToLagerButton.Name = "addToLagerButton";
            this.addToLagerButton.Size = new System.Drawing.Size(164, 83);
            this.addToLagerButton.TabIndex = 0;
            this.addToLagerButton.Text = "Lägg Ny Produkt";
            this.addToLagerButton.UseVisualStyleBackColor = true;
            this.addToLagerButton.Click += new System.EventHandler(this.addToLagerButton_Click);
            // 
            // LagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 539);
            this.Controls.Add(this.productDatalistLager);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ListLabel);
            this.MinimumSize = new System.Drawing.Size(895, 586);
            this.Name = "LagerForm";
            this.Text = "LagerForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDatalistLager)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
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
    }
}