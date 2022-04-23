
namespace ShoppingSystem
{
    partial class KundVagn
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
            this.KVsplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.KVRemoveButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ProduktLista = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).BeginInit();
            this.KVsplitContainer1.Panel1.SuspendLayout();
            this.KVsplitContainer1.Panel2.SuspendLayout();
            this.KVsplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KVsplitContainer1
            // 
            this.KVsplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KVsplitContainer1.Location = new System.Drawing.Point(0, 484);
            this.KVsplitContainer1.Name = "KVsplitContainer1";
            // 
            // KVsplitContainer1.Panel1
            // 
            this.KVsplitContainer1.Panel1.Controls.Add(this.KVRemoveButton);
            // 
            // KVsplitContainer1.Panel2
            // 
            this.KVsplitContainer1.Panel2.Controls.Add(this.ContinueButton);
            this.KVsplitContainer1.Size = new System.Drawing.Size(800, 74);
            this.KVsplitContainer1.SplitterDistance = 365;
            this.KVsplitContainer1.TabIndex = 6;
            // 
            // KVRemoveButton
            // 
            this.KVRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KVRemoveButton.Location = new System.Drawing.Point(0, 0);
            this.KVRemoveButton.Name = "KVRemoveButton";
            this.KVRemoveButton.Size = new System.Drawing.Size(365, 74);
            this.KVRemoveButton.TabIndex = 4;
            this.KVRemoveButton.Text = "Ta Bort";
            this.KVRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueButton.Location = new System.Drawing.Point(0, 0);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(431, 74);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Försätt Vidare";
            this.ContinueButton.UseVisualStyleBackColor = true;
            // 
            // ProduktLista
            // 
            this.ProduktLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduktLista.FormattingEnabled = true;
            this.ProduktLista.ItemHeight = 16;
            this.ProduktLista.Location = new System.Drawing.Point(0, 26);
            this.ProduktLista.Name = "ProduktLista";
            this.ProduktLista.Size = new System.Drawing.Size(800, 452);
            this.ProduktLista.TabIndex = 5;
            this.ProduktLista.SelectedIndexChanged += new System.EventHandler(this.ProduktLista_SelectedIndexChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(91, 17);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // KundVagn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.KVsplitContainer1);
            this.Controls.Add(this.ProduktLista);
            this.Controls.Add(this.ListLabel);
            this.MinimumSize = new System.Drawing.Size(818, 605);
            this.Name = "KundVagn";
            this.Text = "KundVagn";
            this.KVsplitContainer1.Panel1.ResumeLayout(false);
            this.KVsplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).EndInit();
            this.KVsplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer KVsplitContainer1;
        private System.Windows.Forms.Button KVRemoveButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.ListBox ProduktLista;
        private System.Windows.Forms.Label ListLabel;
    }
}