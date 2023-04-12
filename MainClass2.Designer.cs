namespace ShoppingSystem
{
    partial class Shwep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shwep));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.KassaButton = new System.Windows.Forms.Button();
            this.LagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.KassaButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LagerButton);
            this.splitContainer1.Size = new System.Drawing.Size(396, 510);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // KassaButton
            // 
            this.KassaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.KassaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KassaButton.FlatAppearance.BorderSize = 0;
            this.KassaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KassaButton.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KassaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KassaButton.Image = global::ShoppingSystem.Properties.Resources.right;
            this.KassaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KassaButton.Location = new System.Drawing.Point(0, 0);
            this.KassaButton.Name = "KassaButton";
            this.KassaButton.Size = new System.Drawing.Size(396, 261);
            this.KassaButton.TabIndex = 0;
            this.KassaButton.Text = "Kassa";
            this.KassaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.KassaButton.UseVisualStyleBackColor = false;
            this.KassaButton.Click += new System.EventHandler(this.KassaButton_Click);
            // 
            // LagerButton
            // 
            this.LagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LagerButton.FlatAppearance.BorderSize = 0;
            this.LagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LagerButton.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LagerButton.Image = global::ShoppingSystem.Properties.Resources.left;
            this.LagerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LagerButton.Location = new System.Drawing.Point(0, 0);
            this.LagerButton.Name = "LagerButton";
            this.LagerButton.Size = new System.Drawing.Size(396, 245);
            this.LagerButton.TabIndex = 0;
            this.LagerButton.Text = "Lager";
            this.LagerButton.UseVisualStyleBackColor = true;
            this.LagerButton.Click += new System.EventHandler(this.LagerButton_Click);
            // 
            // Shwep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(396, 510);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(412, 549);
            this.Name = "Shwep";
            this.Text = "Shwep";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button KassaButton;
        private System.Windows.Forms.Button LagerButton;
    }
}