
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
            this.ListLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Add = new System.Windows.Forms.Button();
            this.KundKorgButton = new System.Windows.Forms.Button();
            this.productDatalistKassa = new System.Windows.Forms.DataGridView();
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
            this.ListLabel.Location = new System.Drawing.Point(13, 13);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 0;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 455);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KundKorgButton);
            this.splitContainer1.Size = new System.Drawing.Size(724, 83);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(0, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(332, 83);
            this.Add.TabIndex = 4;
            this.Add.Text = "Lägg TIll";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // KundKorgButton
            // 
            this.KundKorgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KundKorgButton.Location = new System.Drawing.Point(0, 0);
            this.KundKorgButton.Name = "KundKorgButton";
            this.KundKorgButton.Size = new System.Drawing.Size(388, 83);
            this.KundKorgButton.TabIndex = 4;
            this.KundKorgButton.Text = "Visa Kundkorg";
            this.KundKorgButton.UseVisualStyleBackColor = true;
            this.KundKorgButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // productDatalistKassa
            // 
            this.productDatalistKassa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatalistKassa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDatalistKassa.Location = new System.Drawing.Point(0, 33);
            this.productDatalistKassa.Name = "productDatalistKassa";
            this.productDatalistKassa.RowHeadersWidth = 51;
            this.productDatalistKassa.RowTemplate.Height = 24;
            this.productDatalistKassa.Size = new System.Drawing.Size(724, 422);
            this.productDatalistKassa.TabIndex = 4;
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 538);
            this.Controls.Add(this.productDatalistKassa);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ListLabel);
            this.MinimumSize = new System.Drawing.Size(742, 585);
            this.Name = "KassaForm";
            this.Text = "KassaForm";
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
    }
}