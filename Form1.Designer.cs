
namespace ShoppingSystem
{
    partial class MainShop
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
            this.KassaButton = new System.Windows.Forms.Button();
            this.LagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KassaButton
            // 
            this.KassaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KassaButton.Location = new System.Drawing.Point(176, 105);
            this.KassaButton.Name = "KassaButton";
            this.KassaButton.Size = new System.Drawing.Size(111, 100);
            this.KassaButton.TabIndex = 0;
            this.KassaButton.Text = "Till Kassa";
            this.KassaButton.UseVisualStyleBackColor = true;
            this.KassaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LagerButton
            // 
            this.LagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LagerButton.Location = new System.Drawing.Point(176, 330);
            this.LagerButton.Name = "LagerButton";
            this.LagerButton.Size = new System.Drawing.Size(111, 100);
            this.LagerButton.TabIndex = 0;
            this.LagerButton.Text = "Till Lager";
            this.LagerButton.UseVisualStyleBackColor = true;
            this.LagerButton.Click += new System.EventHandler(this.LagerButton_Click);
            // 
            // MainShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 596);
            this.Controls.Add(this.LagerButton);
            this.Controls.Add(this.KassaButton);
            this.MinimumSize = new System.Drawing.Size(517, 643);
            this.Name = "MainShop";
            this.Text = "MainShopForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KassaButton;
        private System.Windows.Forms.Button LagerButton;
    }
}

