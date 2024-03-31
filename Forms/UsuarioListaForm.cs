using Crud_Form.Forms;
using Crud_Form.Models;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Crud_Form
{
    public partial class UsuarioListaForm : Form
    {
        private UsuarioRepositorio repositorio;

        public UsuarioListaForm()
        {
            InitializeComponent();

            ativoPesquisarComboBox.SelectedIndex = 0;

            UsuariosGridView.ClearSelection();

            repositorio = new UsuarioRepositorio();

            MostrarDataGrid();
        }

        private int GetUsuarioSelecionado()
        {
            var linhaSelecionada = UsuariosGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (linhaSelecionada != null && linhaSelecionada.Cells["Id"].Value != null)
            {
                return Convert.ToInt32(linhaSelecionada.Cells["Id"].Value);
            }

            return 0;
        }

        private void MostrarDataGrid()
        {
            var lista = repositorio.Listar();

            UsuariosGridView.DataSource = lista;
            UsuariosGridView.Columns[0].Visible = false;
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            var usuarioId = GetUsuarioSelecionado();

            if (usuarioId == 0) return;

            if (MessageBox.Show("Deseja realmente excluir este usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            repositorio.Excluir(usuarioId);

            MostrarDataGrid();
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            var usuarioId = GetUsuarioSelecionado();

            if (usuarioId == 0) return;

            var usuarioUpdate = new UsuarioUpdateForm(usuarioId);
            usuarioUpdate.ShowDialog();
            MostrarDataGrid();
        }

        private void IncluirToolStripButton_Click(object sender, EventArgs e)
        {
            var usuarioIncluir = new UsuarioIncluirForm();
            usuarioIncluir.ShowDialog();
            MostrarDataGrid();
        }

        private void SairToolStripButton_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show(this, "Tem Certeza Que Deseja Sair??", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (sair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void PesquisarButton_Click_1(object sender, EventArgs e)
        {
            var nome = nomePesquisarTextBox.Text;
            var login = loginPesquisarTextBox.Text;
            var email = emailPesquisarTextBox.Text;
            bool? ativo = null;

            if (ativoPesquisarComboBox.SelectedIndex == 1)
            {
                ativo = true;
            }
            else if (ativoPesquisarComboBox.SelectedIndex == 2)
            {
                ativo = false;
            }

            UsuariosGridView.DataSource = repositorio.PesquisarUsuarios(nome, login, email, ativo);

            UsuariosGridView.ClearSelection();
        }
    }
}
