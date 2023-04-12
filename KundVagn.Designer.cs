
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundVagn));
            this.KVsplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.KVRemoveButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ProduktLista = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.kundvagndataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).BeginInit();
            this.KVsplitContainer1.Panel1.SuspendLayout();
            this.KVsplitContainer1.Panel2.SuspendLayout();
            this.KVsplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundvagndataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KVsplitContainer1
            // 
            this.KVsplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.KVsplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KVsplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.KVsplitContainer1.Location = new System.Drawing.Point(0, 400);
            this.KVsplitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.KVsplitContainer1.Name = "KVsplitContainer1";
            // 
            // KVsplitContainer1.Panel1
            // 
            this.KVsplitContainer1.Panel1.Controls.Add(this.KVRemoveButton);
            // 
            // KVsplitContainer1.Panel2
            // 
            this.KVsplitContainer1.Panel2.Controls.Add(this.ContinueButton);
            this.KVsplitContainer1.Size = new System.Drawing.Size(1169, 60);
            this.KVsplitContainer1.SplitterDistance = 533;
            this.KVsplitContainer1.SplitterWidth = 3;
            this.KVsplitContainer1.TabIndex = 6;
            // 
            // KVRemoveButton
            // 
            this.KVRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KVRemoveButton.FlatAppearance.BorderSize = 0;
            this.KVRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KVRemoveButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KVRemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KVRemoveButton.Image = global::ShoppingSystem.Properties.Resources.cancel;
            this.KVRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KVRemoveButton.Location = new System.Drawing.Point(0, 0);
            this.KVRemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.KVRemoveButton.Name = "KVRemoveButton";
            this.KVRemoveButton.Padding = new System.Windows.Forms.Padding(210, 0, 0, 0);
            this.KVRemoveButton.Size = new System.Drawing.Size(533, 60);
            this.KVRemoveButton.TabIndex = 4;
            this.KVRemoveButton.Text = "    Avbryt Köp";
            this.KVRemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KVRemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KVRemoveButton.UseVisualStyleBackColor = true;
            this.KVRemoveButton.Click += new System.EventHandler(this.KVRemoveButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ContinueButton.Image = global::ShoppingSystem.Properties.Resources.finish;
            this.ContinueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContinueButton.Location = new System.Drawing.Point(0, 0);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(2);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Padding = new System.Windows.Forms.Padding(250, 0, 0, 0);
            this.ContinueButton.Size = new System.Drawing.Size(633, 60);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "    Försätt Vidare";
            this.ContinueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContinueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ProduktLista
            // 
            this.ProduktLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduktLista.FormattingEnabled = true;
            this.ProduktLista.Location = new System.Drawing.Point(0, 21);
            this.ProduktLista.Margin = new System.Windows.Forms.Padding(2);
            this.ProduktLista.Name = "ProduktLista";
            this.ProduktLista.Size = new System.Drawing.Size(1169, 368);
            this.ProduktLista.TabIndex = 5;
            this.ProduktLista.SelectedIndexChanged += new System.EventHandler(this.ProduktLista_SelectedIndexChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(69, 13);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Produkt Lista";
            // 
            // kundvagndataGridView
            // 
            this.kundvagndataGridView.AllowUserToAddRows = false;
            this.kundvagndataGridView.AllowUserToDeleteRows = false;
            this.kundvagndataGridView.AllowUserToResizeColumns = false;
            this.kundvagndataGridView.AllowUserToResizeRows = false;
            this.kundvagndataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kundvagndataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundvagndataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kundvagndataGridView.Location = new System.Drawing.Point(0, 13);
            this.kundvagndataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.kundvagndataGridView.MultiSelect = false;
            this.kundvagndataGridView.Name = "kundvagndataGridView";
            this.kundvagndataGridView.ReadOnly = true;
            this.kundvagndataGridView.RowHeadersWidth = 51;
            this.kundvagndataGridView.RowTemplate.Height = 24;
            this.kundvagndataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kundvagndataGridView.Size = new System.Drawing.Size(1169, 387);
            this.kundvagndataGridView.StandardTab = true;
            this.kundvagndataGridView.TabIndex = 7;
            this.kundvagndataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kundvagndataGridView_CellFormatting);
            // 
            // KundVagn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1169, 460);
            this.Controls.Add(this.kundvagndataGridView);
            this.Controls.Add(this.KVsplitContainer1);
            this.Controls.Add(this.ProduktLista);
            this.Controls.Add(this.ListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1185, 499);
            this.Name = "KundVagn";
            this.Text = "KundVagn";
            this.KVsplitContainer1.Panel1.ResumeLayout(false);
            this.KVsplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KVsplitContainer1)).EndInit();
            this.KVsplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kundvagndataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer KVsplitContainer1;
        private System.Windows.Forms.Button KVRemoveButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.ListBox ProduktLista;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.DataGridView kundvagndataGridView;
    }
}