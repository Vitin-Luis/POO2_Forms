namespace Aula20240509
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
            this.textBoxEstados = new System.Windows.Forms.TextBox();
            this.btnAddEstados = new System.Windows.Forms.Button();
            this.comboBoxListaEstados = new System.Windows.Forms.ComboBox();
            this.listBoxEstados = new System.Windows.Forms.ListBox();
            this.btnCopiarEstados = new System.Windows.Forms.Button();
            this.btnCopiarSelecionados = new System.Windows.Forms.Button();
            this.listBoxEstadosSelecionados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxEstados
            // 
            this.textBoxEstados.Location = new System.Drawing.Point(179, 41);
            this.textBoxEstados.Name = "textBoxEstados";
            this.textBoxEstados.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstados.TabIndex = 0;
            this.textBoxEstados.TextChanged += new System.EventHandler(this.textBoxEstados_TextChanged);
            // 
            // btnAddEstados
            // 
            this.btnAddEstados.Location = new System.Drawing.Point(44, 38);
            this.btnAddEstados.Name = "btnAddEstados";
            this.btnAddEstados.Size = new System.Drawing.Size(75, 23);
            this.btnAddEstados.TabIndex = 1;
            this.btnAddEstados.Text = "Adicionar";
            this.btnAddEstados.UseVisualStyleBackColor = true;
            this.btnAddEstados.Click += new System.EventHandler(this.btnAddEstados_Click);
            // 
            // comboBoxListaEstados
            // 
            this.comboBoxListaEstados.FormattingEnabled = true;
            this.comboBoxListaEstados.Location = new System.Drawing.Point(44, 98);
            this.comboBoxListaEstados.Name = "comboBoxListaEstados";
            this.comboBoxListaEstados.Size = new System.Drawing.Size(235, 21);
            this.comboBoxListaEstados.TabIndex = 2;
            this.comboBoxListaEstados.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaEstados_SelectedIndexChanged);
            // 
            // listBoxEstados
            // 
            this.listBoxEstados.FormattingEnabled = true;
            this.listBoxEstados.Location = new System.Drawing.Point(44, 188);
            this.listBoxEstados.Name = "listBoxEstados";
            this.listBoxEstados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEstados.Size = new System.Drawing.Size(120, 95);
            this.listBoxEstados.TabIndex = 3;
            this.listBoxEstados.SelectedIndexChanged += new System.EventHandler(this.listBoxEstados_SelectedIndexChanged);
            // 
            // btnCopiarEstados
            // 
            this.btnCopiarEstados.Location = new System.Drawing.Point(44, 141);
            this.btnCopiarEstados.Name = "btnCopiarEstados";
            this.btnCopiarEstados.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarEstados.TabIndex = 4;
            this.btnCopiarEstados.Text = "Copiar";
            this.btnCopiarEstados.UseVisualStyleBackColor = true;
            this.btnCopiarEstados.Click += new System.EventHandler(this.btnCopiarEstados_Click);
            // 
            // btnCopiarSelecionados
            // 
            this.btnCopiarSelecionados.Location = new System.Drawing.Point(215, 141);
            this.btnCopiarSelecionados.Name = "btnCopiarSelecionados";
            this.btnCopiarSelecionados.Size = new System.Drawing.Size(138, 23);
            this.btnCopiarSelecionados.TabIndex = 5;
            this.btnCopiarSelecionados.Text = "Copiar Selecionados";
            this.btnCopiarSelecionados.UseVisualStyleBackColor = true;
            this.btnCopiarSelecionados.Click += new System.EventHandler(this.btnCopiarSelecionados_Click);
            // 
            // listBoxEstadosSelecionados
            // 
            this.listBoxEstadosSelecionados.FormattingEnabled = true;
            this.listBoxEstadosSelecionados.Location = new System.Drawing.Point(215, 188);
            this.listBoxEstadosSelecionados.Name = "listBoxEstadosSelecionados";
            this.listBoxEstadosSelecionados.Size = new System.Drawing.Size(138, 95);
            this.listBoxEstadosSelecionados.TabIndex = 6;
            this.listBoxEstadosSelecionados.SelectedIndexChanged += new System.EventHandler(this.listBoxEstadosSelecionados_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEstadosSelecionados);
            this.Controls.Add(this.btnCopiarSelecionados);
            this.Controls.Add(this.btnCopiarEstados);
            this.Controls.Add(this.listBoxEstados);
            this.Controls.Add(this.comboBoxListaEstados);
            this.Controls.Add(this.btnAddEstados);
            this.Controls.Add(this.textBoxEstados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEstados;
        private System.Windows.Forms.Button btnAddEstados;
        private System.Windows.Forms.ComboBox comboBoxListaEstados;
        private System.Windows.Forms.ListBox listBoxEstados;
        private System.Windows.Forms.Button btnCopiarEstados;
        private System.Windows.Forms.Button btnCopiarSelecionados;
        private System.Windows.Forms.ListBox listBoxEstadosSelecionados;
    }
}

