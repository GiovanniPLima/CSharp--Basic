
namespace Agenda
{
    partial class formAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAgenda));
            this.lbxContatos = new System.Windows.Forms.ListBox();
            this.lNome = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lTeleofne = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEmal = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxContatos
            // 
            this.lbxContatos.FormattingEnabled = true;
            this.lbxContatos.ItemHeight = 15;
            this.lbxContatos.Location = new System.Drawing.Point(6, 10);
            this.lbxContatos.Name = "lbxContatos";
            this.lbxContatos.Size = new System.Drawing.Size(346, 424);
            this.lbxContatos.TabIndex = 0;
            this.lbxContatos.SelectedIndexChanged += new System.EventHandler(this.lbxContatos_SelectedIndexChanged);
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(362, 19);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(43, 15);
            this.lNome.TabIndex = 1;
            this.lNome.Text = "Nome:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(362, 57);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(30, 15);
            this.lEmail.TabIndex = 1;
            this.lEmail.Text = "Dev:";
            // 
            // lTeleofne
            // 
            this.lTeleofne.AutoSize = true;
            this.lTeleofne.Location = new System.Drawing.Point(358, 95);
            this.lTeleofne.Name = "lTeleofne";
            this.lTeleofne.Size = new System.Drawing.Size(54, 15);
            this.lTeleofne.TabIndex = 1;
            this.lTeleofne.Text = "Telefone:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(418, 19);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(370, 23);
            this.tbxNome.TabIndex = 2;
            // 
            // tbxEmal
            // 
            this.tbxEmal.Location = new System.Drawing.Point(418, 54);
            this.tbxEmal.Name = "tbxEmal";
            this.tbxEmal.Size = new System.Drawing.Size(370, 23);
            this.tbxEmal.TabIndex = 2;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(418, 92);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(370, 23);
            this.tbxTelefone.TabIndex = 2;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(371, 152);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(81, 34);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(475, 152);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 34);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(575, 152);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 34);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(371, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 34);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.tbxEmal);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lTeleofne);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.lbxContatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.formAgenda_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxContatos;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lTeleofne;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEmal;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

