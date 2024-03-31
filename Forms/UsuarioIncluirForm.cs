using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud_Form;

using Crud_Form.Models;

namespace Crud_Form.Forms
{
    public partial class UsuarioIncluirForm : Form
    {
        public UsuarioIncluirForm()
        {
            InitializeComponent();
        }


        private void IncluirButton_Click(object sender, EventArgs e)
        {
            var incluirUsuario = new Usuario()
            {
                Nome = IncluirNomeTextBox.Text,
                Login = IncluirLoginTextBox.Text,
                Email = IncluirEmailTextBox.Text,
                Senha = IncluirSenhaTextBox.Text,
                Ativo = checkBox1.Checked,
            };

            using (var repositorio = new UsuarioRepositorio())
            {
                repositorio.Salvar(incluirUsuario);
            }
            
            Close();

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
