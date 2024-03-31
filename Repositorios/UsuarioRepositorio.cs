using Crud_Form.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace Crud_Form
{
    public class UsuarioRepositorio : IDisposable
    {
        private MySqlConnection _conexao;

        public UsuarioRepositorio()
        {
            _conexao = new MySqlConnection("server=localhost; database=crud_form; user id=root; password=123456");
            _conexao.Open();
        }

        public void Dispose()
        {
            _conexao.Close();
            _conexao.Dispose();
        }

        public List<Usuario> PesquisarUsuarios(string nome, string login, string email, bool? ativo)
        {
            var lista = new List<Usuario>();

            string codigo = "SELECT * FROM usuario WHERE 1 = 1";

            if (!string.IsNullOrEmpty(nome))
            {
                codigo += " AND nome LIKE @nome";
            }

            if (!string.IsNullOrEmpty(login))
            {
                codigo += " AND login LIKE @login";
            }

            if (!string.IsNullOrEmpty(email))
            {
                codigo += " AND email LIKE @email";
            }

            if (ativo.HasValue)
            {
                codigo += " AND ativo = @ativo";
            }

            using (var comando = new MySqlCommand(codigo, _conexao))
            {
                comando.Parameters.AddWithValue("nome", $"%{nome}%");
                comando.Parameters.AddWithValue("login", $"%{login}%");
                comando.Parameters.AddWithValue("email", $"%{email}%");
                comando.Parameters.AddWithValue("ativo", ativo);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Login = reader.GetString("login"),
                            Email = reader.GetString("email"),
                            Senha = reader.GetString("senha"),
                            Ativo = reader.GetBoolean("Ativo"),
                        };
                        lista.Add(usuario);
                    }
                }
            }
            return lista;
        }

        public List<Usuario> Listar()
        {
            var lista = new List<Usuario>();

            string codigo = "SELECT * FROM usuario";

            using (var comando = new MySqlCommand(codigo, _conexao))
            {
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Login = reader.GetString("login"),
                            Email = reader.GetString("email"),
                            Senha = reader.GetString("senha"),
                            Ativo = reader.GetBoolean("Ativo"),
                        };

                        lista.Add(usuario);
                    }
                }
            }
            return lista;
        }

        public Usuario Carregar(int id)
        {
            string codigo = "SELECT * FROM usuario WHERE id = @id";

            using (var comando = new MySqlCommand(codigo, _conexao))
            {
                comando.Parameters.AddWithValue("id", id);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = id,
                            Nome = reader.GetString("nome"),
                            Login = reader.GetString("login"),
                            Email = reader.GetString("email"),
                            Senha = reader.GetString("senha"),
                            Ativo = reader.GetBoolean("ativo"),
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void Salvar(Usuario usuario)
        {
            if (usuario.Id <= 0)
            {
                string codigo = "INSERT INTO usuario (nome, login, email, senha, ativo) VALUES (@nome, @login, @email, @senha, @ativo)";

                using (var comando = new MySqlCommand(codigo, _conexao))
                {
                    comando.Parameters.AddWithValue("nome", usuario.Nome);
                    comando.Parameters.AddWithValue("login", usuario.Login);
                    comando.Parameters.AddWithValue("email", usuario.Email);
                    comando.Parameters.AddWithValue("senha", usuario.Senha);
                    comando.Parameters.AddWithValue("ativo", usuario.Ativo);
                    comando.ExecuteNonQuery();
                }
            }
            else
            {
                string codigo = "UPDATE usuario SET nome = @nome, email = @email, login = @login, senha = @senha, ativo = @ativo WHERE id = @id";

                using (var comando = new MySqlCommand(codigo, _conexao))
                {
                    comando.Parameters.AddWithValue("nome", usuario.Nome);
                    comando.Parameters.AddWithValue("login", usuario.Login);
                    comando.Parameters.AddWithValue("email", usuario.Email);
                    comando.Parameters.AddWithValue("senha", usuario.Senha);
                    comando.Parameters.AddWithValue("ativo", usuario.Ativo);
                    comando.Parameters.AddWithValue("id", usuario.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int usuarioId)
        {
            string codigo = "DELETE FROM usuario WHERE id = @id";

            using (var comando = new MySqlCommand(codigo, _conexao))
            {
                comando.Parameters.AddWithValue("id", usuarioId);
                comando.ExecuteNonQuery();
            }
        }
    }
}
