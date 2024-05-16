namespace Aula20240509_pt2
{
    partial class Form2
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.textBoxTelefoneDigitar = new System.Windows.Forms.TextBox();
            this.textBoxNomeDigitar = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(297, 39);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 23;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Location = new System.Drawing.Point(119, 137);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContato.TabIndex = 22;
            this.comboBoxContato.SelectedIndexChanged += new System.EventHandler(this.comboBoxContato_SelectedIndexChanged);
            // 
            // textBoxTelefoneDigitar
            // 
            this.textBoxTelefoneDigitar.Location = new System.Drawing.Point(119, 82);
            this.textBoxTelefoneDigitar.Name = "textBoxTelefoneDigitar";
            this.textBoxTelefoneDigitar.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelefoneDigitar.TabIndex = 20;
            // 
            // textBoxNomeDigitar
            // 
            this.textBoxNomeDigitar.Location = new System.Drawing.Point(119, 37);
            this.textBoxNomeDigitar.Name = "textBoxNomeDigitar";
            this.textBoxNomeDigitar.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomeDigitar.TabIndex = 19;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(52, 140);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 18;
            this.labelTipo.Text = "Tipo";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(33, 89);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 17;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(52, 44);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 235);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.comboBoxContato);
            this.Controls.Add(this.textBoxTelefoneDigitar);
            this.Controls.Add(this.textBoxNomeDigitar);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.TextBox textBoxTelefoneDigitar;
        private System.Windows.Forms.TextBox textBoxNomeDigitar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelNome;
    }
}