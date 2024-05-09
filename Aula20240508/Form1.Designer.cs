namespace Aula20240508
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxNomesAdicionados = new System.Windows.Forms.ComboBox();
            this.listViewNomesCompletos = new System.Windows.Forms.ListView();
            this.lblNomeVerdadeiramenteCompleto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(25, 81);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome:";
            this.lblSobrenome.Click += new System.EventHandler(this.lblSobrenome_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(95, 40);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 2;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(95, 78);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(100, 20);
            this.textBoxSobrenome.TabIndex = 3;
            this.textBoxSobrenome.TextChanged += new System.EventHandler(this.textBoxSobrenome_TextChanged);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(18, 166);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(113, 13);
            this.lblNomeCompleto.TabIndex = 4;
            this.lblNomeCompleto.Text = "Seu nome completo é:";
            this.lblNomeCompleto.Click += new System.EventHandler(this.lblNomeCompleto_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(107, 104);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(75, 23);
            this.btnConcatenar.TabIndex = 5;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(296, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxNomesAdicionados
            // 
            this.cbxNomesAdicionados.FormattingEnabled = true;
            this.cbxNomesAdicionados.Location = new System.Drawing.Point(12, 284);
            this.cbxNomesAdicionados.Name = "cbxNomesAdicionados";
            this.cbxNomesAdicionados.Size = new System.Drawing.Size(645, 21);
            this.cbxNomesAdicionados.TabIndex = 7;
            this.cbxNomesAdicionados.SelectedIndexChanged += new System.EventHandler(this.cbxNomesAdicionados_SelectedIndexChanged);
            // 
            // listViewNomesCompletos
            // 
            this.listViewNomesCompletos.HideSelection = false;
            this.listViewNomesCompletos.Location = new System.Drawing.Point(73, 331);
            this.listViewNomesCompletos.Name = "listViewNomesCompletos";
            this.listViewNomesCompletos.Size = new System.Drawing.Size(524, 97);
            this.listViewNomesCompletos.TabIndex = 8;
            this.listViewNomesCompletos.UseCompatibleStateImageBehavior = false;
            this.listViewNomesCompletos.SelectedIndexChanged += new System.EventHandler(this.listViewNomesCompletos_SelectedIndexChanged);
            // 
            // lblNomeVerdadeiramenteCompleto
            // 
            this.lblNomeVerdadeiramenteCompleto.AutoSize = true;
            this.lblNomeVerdadeiramenteCompleto.Location = new System.Drawing.Point(131, 166);
            this.lblNomeVerdadeiramenteCompleto.Name = "lblNomeVerdadeiramenteCompleto";
            this.lblNomeVerdadeiramenteCompleto.Size = new System.Drawing.Size(0, 13);
            this.lblNomeVerdadeiramenteCompleto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 467);
            this.Controls.Add(this.lblNomeVerdadeiramenteCompleto);
            this.Controls.Add(this.listViewNomesCompletos);
            this.Controls.Add(this.cbxNomesAdicionados);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxNomesAdicionados;
        private System.Windows.Forms.ListView listViewNomesCompletos;
        private System.Windows.Forms.Label lblNomeVerdadeiramenteCompleto;
    }
}

