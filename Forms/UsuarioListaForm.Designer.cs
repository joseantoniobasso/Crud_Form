namespace Crud_Form
{
    partial class UsuarioListaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioListaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailPesquisarTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginPesquisarTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.ativoPesquisarComboBox = new System.Windows.Forms.ComboBox();
            this.ativoLabel = new System.Windows.Forms.Label();
            this.nomePesquisarTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.UsuariosGridView = new System.Windows.Forms.DataGridView();
            this.MostrarToolStrip = new System.Windows.Forms.ToolStrip();
            this.IncluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SairToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosGridView)).BeginInit();
            this.MostrarToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.emailPesquisarTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.loginPesquisarTextBox);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.ativoPesquisarComboBox);
            this.panel1.Controls.Add(this.ativoLabel);
            this.panel1.Controls.Add(this.nomePesquisarTextBox);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.PesquisarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 43);
            this.panel1.TabIndex = 0;
            // 
            // emailPesquisarTextBox
            // 
            this.emailPesquisarTextBox.Location = new System.Drawing.Point(428, 19);
            this.emailPesquisarTextBox.Name = "emailPesquisarTextBox";
            this.emailPesquisarTextBox.Size = new System.Drawing.Size(198, 20);
            this.emailPesquisarTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(425, 3);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail";
            // 
            // loginPesquisarTextBox
            // 
            this.loginPesquisarTextBox.Location = new System.Drawing.Point(272, 19);
            this.loginPesquisarTextBox.Name = "loginPesquisarTextBox";
            this.loginPesquisarTextBox.Size = new System.Drawing.Size(150, 20);
            this.loginPesquisarTextBox.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(269, 3);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // ativoPesquisarComboBox
            // 
            this.ativoPesquisarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ativoPesquisarComboBox.FormattingEnabled = true;
            this.ativoPesquisarComboBox.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.ativoPesquisarComboBox.Location = new System.Drawing.Point(632, 19);
            this.ativoPesquisarComboBox.Name = "ativoPesquisarComboBox";
            this.ativoPesquisarComboBox.Size = new System.Drawing.Size(121, 21);
            this.ativoPesquisarComboBox.TabIndex = 8;
            // 
            // ativoLabel
            // 
            this.ativoLabel.AutoSize = true;
            this.ativoLabel.Location = new System.Drawing.Point(629, 3);
            this.ativoLabel.Name = "ativoLabel";
            this.ativoLabel.Size = new System.Drawing.Size(31, 13);
            this.ativoLabel.TabIndex = 7;
            this.ativoLabel.Text = "Ativo";
            // 
            // nomePesquisarTextBox
            // 
            this.nomePesquisarTextBox.Location = new System.Drawing.Point(6, 19);
            this.nomePesquisarTextBox.Name = "nomePesquisarTextBox";
            this.nomePesquisarTextBox.Size = new System.Drawing.Size(260, 20);
            this.nomePesquisarTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(3, 3);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Location = new System.Drawing.Point(759, 17);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(113, 23);
            this.PesquisarButton.TabIndex = 9;
            this.PesquisarButton.Text = "&Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click_1);
            // 
            // UsuariosGridView
            // 
            this.UsuariosGridView.AllowUserToAddRows = false;
            this.UsuariosGridView.AllowUserToDeleteRows = false;
            this.UsuariosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuariosGridView.Location = new System.Drawing.Point(0, 74);
            this.UsuariosGridView.Name = "UsuariosGridView";
            this.UsuariosGridView.ReadOnly = true;
            this.UsuariosGridView.Size = new System.Drawing.Size(884, 487);
            this.UsuariosGridView.TabIndex = 3;
            // 
            // MostrarToolStrip
            // 
            this.MostrarToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MostrarToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MostrarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncluirToolStripButton,
            this.UpdateToolStripButton,
            this.ExcluirToolStripButton,
            this.SairToolStripButton});
            this.MostrarToolStrip.Location = new System.Drawing.Point(0, 43);
            this.MostrarToolStrip.Name = "MostrarToolStrip";
            this.MostrarToolStrip.Size = new System.Drawing.Size(884, 31);
            this.MostrarToolStrip.TabIndex = 2;
            // 
            // IncluirToolStripButton
            // 
            this.IncluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("IncluirToolStripButton.Image")));
            this.IncluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncluirToolStripButton.Name = "IncluirToolStripButton";
            this.IncluirToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.IncluirToolStripButton.Text = "Incluir";
            this.IncluirToolStripButton.Click += new System.EventHandler(this.IncluirToolStripButton_Click);
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateToolStripButton.Image")));
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.UpdateToolStripButton.Text = "Update";
            this.UpdateToolStripButton.Click += new System.EventHandler(this.UpdateToolStripButton_Click);
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirToolStripButton.Image")));
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ExcluirToolStripButton.Text = "Excluir";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // SairToolStripButton
            // 
            this.SairToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SairToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SairToolStripButton.Image")));
            this.SairToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SairToolStripButton.Name = "SairToolStripButton";
            this.SairToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.SairToolStripButton.Text = "Sair";
            this.SairToolStripButton.Click += new System.EventHandler(this.SairToolStripButton_Click);
            // 
            // UsuarioListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.UsuariosGridView);
            this.Controls.Add(this.MostrarToolStrip);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "UsuarioListaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosGridView)).EndInit();
            this.MostrarToolStrip.ResumeLayout(false);
            this.MostrarToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.DataGridView UsuariosGridView;
        private System.Windows.Forms.ToolStrip MostrarToolStrip;
        private System.Windows.Forms.ToolStripButton IncluirToolStripButton;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
        private System.Windows.Forms.ToolStripButton SairToolStripButton;
        private System.Windows.Forms.Label ativoLabel;
        private System.Windows.Forms.TextBox nomePesquisarTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.ComboBox ativoPesquisarComboBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox loginPesquisarTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox emailPesquisarTextBox;
    }
}

