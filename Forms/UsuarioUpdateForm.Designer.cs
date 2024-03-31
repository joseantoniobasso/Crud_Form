namespace Crud_Form.Forms
{
    partial class UsuarioUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioUpdateForm));
            this.UpdateLoginLabel = new System.Windows.Forms.Label();
            this.UpdateLoginTextBox = new System.Windows.Forms.TextBox();
            this.UpdateEmailTextBox = new System.Windows.Forms.TextBox();
            this.UpdateEmailLabel = new System.Windows.Forms.Label();
            this.UpdateNomeTextBox = new System.Windows.Forms.TextBox();
            this.UpdateNomeLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateCancelarButton = new System.Windows.Forms.Button();
            this.UpdateSenhaLabel = new System.Windows.Forms.Label();
            this.UpdateSenhaTextBox = new System.Windows.Forms.TextBox();
            this.UpdateAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UpdateLoginLabel
            // 
            this.UpdateLoginLabel.AutoSize = true;
            this.UpdateLoginLabel.Location = new System.Drawing.Point(48, 93);
            this.UpdateLoginLabel.Name = "UpdateLoginLabel";
            this.UpdateLoginLabel.Size = new System.Drawing.Size(58, 20);
            this.UpdateLoginLabel.TabIndex = 3;
            this.UpdateLoginLabel.Text = "Login:";
            // 
            // UpdateLoginTextBox
            // 
            this.UpdateLoginTextBox.Location = new System.Drawing.Point(224, 90);
            this.UpdateLoginTextBox.Name = "UpdateLoginTextBox";
            this.UpdateLoginTextBox.Size = new System.Drawing.Size(193, 26);
            this.UpdateLoginTextBox.TabIndex = 4;
            // 
            // UpdateEmailTextBox
            // 
            this.UpdateEmailTextBox.Location = new System.Drawing.Point(224, 192);
            this.UpdateEmailTextBox.Name = "UpdateEmailTextBox";
            this.UpdateEmailTextBox.Size = new System.Drawing.Size(394, 26);
            this.UpdateEmailTextBox.TabIndex = 8;
            // 
            // UpdateEmailLabel
            // 
            this.UpdateEmailLabel.AutoSize = true;
            this.UpdateEmailLabel.Location = new System.Drawing.Point(48, 198);
            this.UpdateEmailLabel.Name = "UpdateEmailLabel";
            this.UpdateEmailLabel.Size = new System.Drawing.Size(58, 20);
            this.UpdateEmailLabel.TabIndex = 7;
            this.UpdateEmailLabel.Text = "Email:";
            // 
            // UpdateNomeTextBox
            // 
            this.UpdateNomeTextBox.Location = new System.Drawing.Point(224, 39);
            this.UpdateNomeTextBox.Name = "UpdateNomeTextBox";
            this.UpdateNomeTextBox.Size = new System.Drawing.Size(394, 26);
            this.UpdateNomeTextBox.TabIndex = 2;
            // 
            // UpdateNomeLabel
            // 
            this.UpdateNomeLabel.AutoSize = true;
            this.UpdateNomeLabel.Location = new System.Drawing.Point(46, 39);
            this.UpdateNomeLabel.Name = "UpdateNomeLabel";
            this.UpdateNomeLabel.Size = new System.Drawing.Size(60, 20);
            this.UpdateNomeLabel.TabIndex = 1;
            this.UpdateNomeLabel.Text = "Nome:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(109, 310);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 61);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "&Atualizar";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateCancelarButton
            // 
            this.UpdateCancelarButton.Location = new System.Drawing.Point(275, 310);
            this.UpdateCancelarButton.Name = "UpdateCancelarButton";
            this.UpdateCancelarButton.Size = new System.Drawing.Size(112, 61);
            this.UpdateCancelarButton.TabIndex = 11;
            this.UpdateCancelarButton.Text = "&Cancelar";
            this.UpdateCancelarButton.UseVisualStyleBackColor = true;
            this.UpdateCancelarButton.Click += new System.EventHandler(this.UpdateCancelarButton_Click);
            // 
            // UpdateSenhaLabel
            // 
            this.UpdateSenhaLabel.AutoSize = true;
            this.UpdateSenhaLabel.Location = new System.Drawing.Point(48, 148);
            this.UpdateSenhaLabel.Name = "UpdateSenhaLabel";
            this.UpdateSenhaLabel.Size = new System.Drawing.Size(66, 20);
            this.UpdateSenhaLabel.TabIndex = 5;
            this.UpdateSenhaLabel.Text = "Senha:";
            // 
            // UpdateSenhaTextBox
            // 
            this.UpdateSenhaTextBox.Location = new System.Drawing.Point(224, 142);
            this.UpdateSenhaTextBox.Name = "UpdateSenhaTextBox";
            this.UpdateSenhaTextBox.Size = new System.Drawing.Size(176, 26);
            this.UpdateSenhaTextBox.TabIndex = 6;
            this.UpdateSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // UpdateAtivoCheckBox
            // 
            this.UpdateAtivoCheckBox.AutoSize = true;
            this.UpdateAtivoCheckBox.Location = new System.Drawing.Point(109, 264);
            this.UpdateAtivoCheckBox.Name = "UpdateAtivoCheckBox";
            this.UpdateAtivoCheckBox.Size = new System.Drawing.Size(68, 24);
            this.UpdateAtivoCheckBox.TabIndex = 9;
            this.UpdateAtivoCheckBox.Text = "Ativo";
            this.UpdateAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsuarioUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 383);
            this.Controls.Add(this.UpdateAtivoCheckBox);
            this.Controls.Add(this.UpdateSenhaTextBox);
            this.Controls.Add(this.UpdateSenhaLabel);
            this.Controls.Add(this.UpdateCancelarButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateNomeTextBox);
            this.Controls.Add(this.UpdateNomeLabel);
            this.Controls.Add(this.UpdateEmailTextBox);
            this.Controls.Add(this.UpdateEmailLabel);
            this.Controls.Add(this.UpdateLoginTextBox);
            this.Controls.Add(this.UpdateLoginLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UsuarioUpdateForm";
            this.Text = "Usuario Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UpdateLoginLabel;
        private System.Windows.Forms.TextBox UpdateLoginTextBox;
        private System.Windows.Forms.TextBox UpdateEmailTextBox;
        private System.Windows.Forms.Label UpdateEmailLabel;
        private System.Windows.Forms.TextBox UpdateNomeTextBox;
        private System.Windows.Forms.Label UpdateNomeLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UpdateCancelarButton;
        private System.Windows.Forms.Label UpdateSenhaLabel;
        private System.Windows.Forms.TextBox UpdateSenhaTextBox;
        private System.Windows.Forms.CheckBox UpdateAtivoCheckBox;
    }
}