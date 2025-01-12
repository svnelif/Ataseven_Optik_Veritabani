namespace Ataseven_Optik.UI
{
    partial class Siparişler
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
            this.txtBul = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSiparişBul = new System.Windows.Forms.Button();
            this.btnSiparişSil = new System.Windows.Forms.Button();
            this.btnSiparişDüzenle = new System.Windows.Forms.Button();
            this.btnSiparişEkle = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(954, 65);
            this.txtBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(412, 22);
            this.txtBul.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(-16, 129);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1402, 518);
            this.dataGridView2.TabIndex = 10;
            // 
            // btnSiparişBul
            // 
            this.btnSiparişBul.Location = new System.Drawing.Point(820, 53);
            this.btnSiparişBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparişBul.Name = "btnSiparişBul";
            this.btnSiparişBul.Size = new System.Drawing.Size(124, 48);
            this.btnSiparişBul.TabIndex = 9;
            this.btnSiparişBul.Text = "Ara";
            this.btnSiparişBul.UseVisualStyleBackColor = true;
            this.btnSiparişBul.Click += new System.EventHandler(this.btnSiparişBul_Click);
            // 
            // btnSiparişSil
            // 
            this.btnSiparişSil.Location = new System.Drawing.Point(471, 53);
            this.btnSiparişSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparişSil.Name = "btnSiparişSil";
            this.btnSiparişSil.Size = new System.Drawing.Size(144, 48);
            this.btnSiparişSil.TabIndex = 8;
            this.btnSiparişSil.Text = "Sil";
            this.btnSiparişSil.UseVisualStyleBackColor = true;
            this.btnSiparişSil.Click += new System.EventHandler(this.btnSiparişSil_Click);
            // 
            // btnSiparişDüzenle
            // 
            this.btnSiparişDüzenle.Location = new System.Drawing.Point(273, 53);
            this.btnSiparişDüzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparişDüzenle.Name = "btnSiparişDüzenle";
            this.btnSiparişDüzenle.Size = new System.Drawing.Size(144, 48);
            this.btnSiparişDüzenle.TabIndex = 7;
            this.btnSiparişDüzenle.Text = "Düzenle";
            this.btnSiparişDüzenle.UseVisualStyleBackColor = true;
            this.btnSiparişDüzenle.Click += new System.EventHandler(this.btnSiparişDüzenle_Click);
            // 
            // btnSiparişEkle
            // 
            this.btnSiparişEkle.Location = new System.Drawing.Point(68, 53);
            this.btnSiparişEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparişEkle.Name = "btnSiparişEkle";
            this.btnSiparişEkle.Size = new System.Drawing.Size(144, 48);
            this.btnSiparişEkle.TabIndex = 6;
            this.btnSiparişEkle.Text = "Ekle";
            this.btnSiparişEkle.UseVisualStyleBackColor = true;
            this.btnSiparişEkle.Click += new System.EventHandler(this.btnSiparişEkle_Click);
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(585, 665);
            this.btnOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(255, 64);
            this.btnOde.TabIndex = 12;
            this.btnOde.Text = "Ödeme Yap";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // Siparişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1386, 751);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSiparişBul);
            this.Controls.Add(this.btnSiparişSil);
            this.Controls.Add(this.btnSiparişDüzenle);
            this.Controls.Add(this.btnSiparişEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Siparişler";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Siparişler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSiparişBul;
        private System.Windows.Forms.Button btnSiparişSil;
        private System.Windows.Forms.Button btnSiparişDüzenle;
        private System.Windows.Forms.Button btnSiparişEkle;
        private System.Windows.Forms.Button btnOde;
    }
}