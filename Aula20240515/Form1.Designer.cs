namespace Aula20240515
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.btnEnfiarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(217, 84);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(166, 21);
            this.comboBoxItem.TabIndex = 0;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // btnItem
            // 
            this.btnItem.AutoSize = true;
            this.btnItem.Location = new System.Drawing.Point(107, 82);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(84, 23);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Adicionar Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Location = new System.Drawing.Point(88, 190);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItem.Size = new System.Drawing.Size(295, 150);
            this.dataGridViewItem.TabIndex = 2;
            this.dataGridViewItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItem_CellContentClick);
            // 
            // btnEnfiarLista
            // 
            this.btnEnfiarLista.Location = new System.Drawing.Point(217, 140);
            this.btnEnfiarLista.Name = "btnEnfiarLista";
            this.btnEnfiarLista.Size = new System.Drawing.Size(75, 23);
            this.btnEnfiarLista.TabIndex = 3;
            this.btnEnfiarLista.Text = "Jogar lista";
            this.btnEnfiarLista.UseVisualStyleBackColor = true;
            this.btnEnfiarLista.Click += new System.EventHandler(this.btnEnfiarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btnEnfiarLista);
            this.Controls.Add(this.dataGridViewItem);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.comboBoxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.Button btnEnfiarLista;
    }
}

