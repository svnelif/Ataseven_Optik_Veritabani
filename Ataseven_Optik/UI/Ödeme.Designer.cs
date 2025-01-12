namespace Ataseven_Optik.UI
{
    partial class Ödeme
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
            this.btnOdemeBul = new System.Windows.Forms.Button();
            this.btnOdemeSil = new System.Windows.Forms.Button();
            this.btnOdemeDüzenle = new System.Windows.Forms.Button();
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(984, 43);
            this.txtBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(446, 22);
            this.txtBul.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 103);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1455, 513);
            this.dataGridView2.TabIndex = 17;
            // 
            // btnOdemeBul
            // 
            this.btnOdemeBul.Location = new System.Drawing.Point(850, 31);
            this.btnOdemeBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeBul.Name = "btnOdemeBul";
            this.btnOdemeBul.Size = new System.Drawing.Size(124, 48);
            this.btnOdemeBul.TabIndex = 16;
            this.btnOdemeBul.Text = "Ara";
            this.btnOdemeBul.UseVisualStyleBackColor = true;
            this.btnOdemeBul.Click += new System.EventHandler(this.btnOdemeBul_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Location = new System.Drawing.Point(496, 31);
            this.btnOdemeSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(144, 48);
            this.btnOdemeSil.TabIndex = 15;
            this.btnOdemeSil.Text = "Sil";
            this.btnOdemeSil.UseVisualStyleBackColor = true;
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // btnOdemeDüzenle
            // 
            this.btnOdemeDüzenle.Location = new System.Drawing.Point(285, 31);
            this.btnOdemeDüzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeDüzenle.Name = "btnOdemeDüzenle";
            this.btnOdemeDüzenle.Size = new System.Drawing.Size(144, 48);
            this.btnOdemeDüzenle.TabIndex = 14;
            this.btnOdemeDüzenle.Text = "Düzenle";
            this.btnOdemeDüzenle.UseVisualStyleBackColor = true;
            this.btnOdemeDüzenle.Click += new System.EventHandler(this.btnOdemeDüzenle_Click);
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Location = new System.Drawing.Point(70, 31);
            this.btnOdemeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(144, 48);
            this.btnOdemeEkle.TabIndex = 13;
            this.btnOdemeEkle.Text = "Ekle";
            this.btnOdemeEkle.UseVisualStyleBackColor = true;
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // Ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1450, 617);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnOdemeBul);
            this.Controls.Add(this.btnOdemeSil);
            this.Controls.Add(this.btnOdemeDüzenle);
            this.Controls.Add(this.btnOdemeEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ödeme";
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Ödeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnOdemeBul;
        private System.Windows.Forms.Button btnOdemeSil;
        private System.Windows.Forms.Button btnOdemeDüzenle;
        private System.Windows.Forms.Button btnOdemeEkle;
    }
}