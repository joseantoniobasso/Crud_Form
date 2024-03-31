using Crud_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Crud_Form.Forms
{
    public partial class UsuarioUpdateForm : Form
    {
        private readonly Usuario _usuario;

        public UsuarioUpdateForm(int usuarioId)
        {
            InitializeComponent();

            using(var updateUsuario = new UsuarioRepositorio())
            {
                _usuario = updateUsuario.Carregar(usuarioId);

                UpdateNomeTextBox.Text = _usuario.Nome;
                UpdateLoginTextBox.Text = _usuario.Login;
                UpdateEmailTextBox.Text = _usuario.Email;
                UpdateSenhaTextBox.Text = _usuario.Senha;
                UpdateAtivoCheckBox.Checked = _usuario.Ativo;
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var updateUsuario = new UsuarioRepositorio())
            {
                _usuario.Nome = UpdateNomeTextBox.Text;
                _usuario.Login = UpdateLoginTextBox.Text;
                _usuario.Email = UpdateEmailTextBox.Text;
                _usuario.Senha = UpdateSenhaTextBox.Text;
                _usuario.Ativo = UpdateAtivoCheckBox.Checked;

                updateUsuario.Salvar(_usuario);
            }

            Close();

        }

        private void UpdateCancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
