namespace Ataseven_Optik.UI
{
    partial class Ürünler
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
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.btnÜrünDüzenle = new System.Windows.Forms.Button();
            this.btnÜrünSil = new System.Windows.Forms.Button();
            this.btnÜrünBul = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.Location = new System.Drawing.Point(84, 57);
            this.btnÜrünEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(144, 48);
            this.btnÜrünEkle.TabIndex = 0;
            this.btnÜrünEkle.Text = "Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = true;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnÜrünDüzenle
            // 
            this.btnÜrünDüzenle.Location = new System.Drawing.Point(290, 57);
            this.btnÜrünDüzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnÜrünDüzenle.Name = "btnÜrünDüzenle";
            this.btnÜrünDüzenle.Size = new System.Drawing.Size(144, 48);
            this.btnÜrünDüzenle.TabIndex = 1;
            this.btnÜrünDüzenle.Text = "Düzenle";
            this.btnÜrünDüzenle.UseVisualStyleBackColor = true;
            this.btnÜrünDüzenle.Click += new System.EventHandler(this.btnÜrünDüzenle_Click);
            // 
            // btnÜrünSil
            // 
            this.btnÜrünSil.Location = new System.Drawing.Point(488, 57);
            this.btnÜrünSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnÜrünSil.Name = "btnÜrünSil";
            this.btnÜrünSil.Size = new System.Drawing.Size(144, 48);
            this.btnÜrünSil.TabIndex = 2;
            this.btnÜrünSil.Text = "Sil";
            this.btnÜrünSil.UseVisualStyleBackColor = true;
            this.btnÜrünSil.Click += new System.EventHandler(this.btnÜrünSil_Click);
            // 
            // btnÜrünBul
            // 
            this.btnÜrünBul.Location = new System.Drawing.Point(837, 57);
            this.btnÜrünBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnÜrünBul.Name = "btnÜrünBul";
            this.btnÜrünBul.Size = new System.Drawing.Size(124, 48);
            this.btnÜrünBul.TabIndex = 3;
            this.btnÜrünBul.Text = "Ara";
            this.btnÜrünBul.UseVisualStyleBackColor = true;
            this.btnÜrünBul.Click += new System.EventHandler(this.btnÜrünBul_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(0, 133);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1204, 425);
            this.dataGridView2.TabIndex = 4;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(970, 69);
            this.txtBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(210, 22);
            this.txtBul.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 617);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(711, 617);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1206, 684);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnÜrünBul);
            this.Controls.Add(this.btnÜrünSil);
            this.Controls.Add(this.btnÜrünDüzenle);
            this.Controls.Add(this.btnÜrünEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ürünler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.Button btnÜrünDüzenle;
        private System.Windows.Forms.Button btnÜrünSil;
        private System.Windows.Forms.Button btnÜrünBul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}