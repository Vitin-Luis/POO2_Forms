namespace Aula20240509_pt2
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxNomeDigitar = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneDigitar = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.checkBoxAceitarTermos = new System.Windows.Forms.CheckBox();
            this.listBoxContato = new System.Windows.Forms.ListBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(123, 72);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(104, 117);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 1;
            this.labelTelefone.Text = "Telefone";
            this.labelTelefone.Click += new System.EventHandler(this.labelTelefone_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(123, 168);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            this.labelTipo.Click += new System.EventHandler(this.labelTipo_Click);
            // 
            // textBoxNomeDigitar
            // 
            this.textBoxNomeDigitar.Location = new System.Drawing.Point(190, 65);
            this.textBoxNomeDigitar.Name = "textBoxNomeDigitar";
            this.textBoxNomeDigitar.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomeDigitar.TabIndex = 3;
            this.textBoxNomeDigitar.TextChanged += new System.EventHandler(this.textBoxNomeDigitar_TextChanged);
            // 
            // textBoxTelefoneDigitar
            // 
            this.textBoxTelefoneDigitar.Location = new System.Drawing.Point(190, 110);
            this.textBoxTelefoneDigitar.Name = "textBoxTelefoneDigitar";
            this.textBoxTelefoneDigitar.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelefoneDigitar.TabIndex = 4;
            this.textBoxTelefoneDigitar.TextChanged += new System.EventHandler(this.textBoxTelefoneDigitar_TextChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(190, 160);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 5;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Location = new System.Drawing.Point(211, 252);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // checkBoxAceitarTermos
            // 
            this.checkBoxAceitarTermos.AutoSize = true;
            this.checkBoxAceitarTermos.Location = new System.Drawing.Point(201, 208);
            this.checkBoxAceitarTermos.Name = "checkBoxAceitarTermos";
            this.checkBoxAceitarTermos.Size = new System.Drawing.Size(98, 17);
            this.checkBoxAceitarTermos.TabIndex = 7;
            this.checkBoxAceitarTermos.Text = "Aceitar o pacto";
            this.checkBoxAceitarTermos.UseVisualStyleBackColor = true;
            this.checkBoxAceitarTermos.CheckedChanged += new System.EventHandler(this.checkBoxAceitarTermos_CheckedChanged);
            // 
            // listBoxContato
            // 
            this.listBoxContato.FormattingEnabled = true;
            this.listBoxContato.Location = new System.Drawing.Point(190, 295);
            this.listBoxContato.Name = "listBoxContato";
            this.listBoxContato.Size = new System.Drawing.Size(120, 95);
            this.listBoxContato.TabIndex = 8;
            this.listBoxContato.SelectedIndexChanged += new System.EventHandler(this.listBoxContato_SelectedIndexChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(367, 295);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(196, 20);
            this.textBoxNome.TabIndex = 9;
            this.textBoxNome.Visible = false;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(367, 334);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.ReadOnly = true;
            this.textBoxTelefone.Size = new System.Drawing.Size(196, 20);
            this.textBoxTelefone.TabIndex = 10;
            this.textBoxTelefone.Visible = false;
            this.textBoxTelefone.TextChanged += new System.EventHandler(this.textBoxTelefone_TextChanged);
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(367, 371);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.ReadOnly = true;
            this.textBoxTipo.Size = new System.Drawing.Size(196, 20);
            this.textBoxTipo.TabIndex = 11;
            this.textBoxTipo.Visible = false;
            this.textBoxTipo.TextChanged += new System.EventHandler(this.textBoxTipo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 460);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listBoxContato);
            this.Controls.Add(this.checkBoxAceitarTermos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxTelefoneDigitar);
            this.Controls.Add(this.textBoxNomeDigitar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxNomeDigitar;
        private System.Windows.Forms.TextBox textBoxTelefoneDigitar;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox checkBoxAceitarTermos;
        private System.Windows.Forms.ListBox listBoxContato;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxTipo;
    }
}

