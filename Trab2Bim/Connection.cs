using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Trab2Bim
{
	class Connection
	{
		private NpgsqlConnection c;
		private string sql;

        //construtor
        public Connection()
		{
			c = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=periodic; User Id=postgres; " +
									 "Password=postgres");
		}

        //INSERIR usuários
		public bool insertUser(string nome, string senha, string email)
		{
			string sql = "INSERT INTO usuarios (nome, senha, email, vitorias, excluido) VALUES (@n,  @s, @e,  @v, FALSE)";

			c.Open();
			NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
			cmd.Parameters.AddWithValue("n", nome);
			cmd.Parameters.AddWithValue("s", senha);
			cmd.Parameters.AddWithValue("e", email);
			cmd.Parameters.AddWithValue("v", 0);

            int a = cmd.ExecuteNonQuery();

            c.Close();

            if (a == 0)
			{
				return false;
			}
			return true;
		}
        
        //LOGIN
		public bool login(string nome, string senha)
		{
			string sql = "SELECT * FROM usuarios  WHERE excluido = FALSE AND nome = @n AND senha = @s";

			c.Open();

			NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
			cmd.Parameters.AddWithValue("n", nome);
			cmd.Parameters.AddWithValue("s", senha);
			NpgsqlDataReader dr = cmd.ExecuteReader();
			
			if (dr.Read())
			{
				c.Close();
				return true;
			}

            c.Close();
			return false;
		}

        //checar se o usuário é ADMINISTRADOR
		public bool IsAdm(string nome)
		{
			if (nome == "ADM")
				return true;

			return false;
		}

        //INSERIR cartas
		public bool insertCard(string elemento, int raio, int num)
		{
			string sql = "INSERT INTO cartas (elemento, numero_at, raio_at, excluido) VALUES (@el,  @n, @r, FALSE)";

			c.Open();
			NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
			cmd.Parameters.AddWithValue("el", elemento);
			cmd.Parameters.AddWithValue("n", num);
			cmd.Parameters.AddWithValue("r", raio);

			int a = cmd.ExecuteNonQuery();

			c.Close();

			if (a == 0)
			{
				return false;
			}
			return true;
		}

		//CONSULTAR todas as cartas
		public DataTable searchAllCards()
		{
			string sql = "SELECT * FROM cartas WHERE excluido = false";

			c.Open();

			NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
			NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			ds.Clear();
			da.Fill(ds);

			c.Close();

			return ds.Tables[0];
		}

        //CONSULTAR carta
		public string[] searchCard(string elemento)
		{
			string[] a = new string[4];
			string sql = "SELECT * FROM cartas WHERE elemento = @v AND excluido = false";

			c.Open();
			NpgsqlCommand cmd = new NpgsqlCommand(sql,c);
			cmd.Parameters.AddWithValue("v", elemento);
			NpgsqlDataReader dr = cmd.ExecuteReader();

			if (dr.Read())
			{

				for (int i = 0; i < 4; i++)
				{
					a[i] = dr[i].ToString();
				}

				c.Close();
				return a;
			}

			c.Close();
			return null;

		}

        //ALTERAR cartas
        public bool alterCard(int id, string elemento, int num, int raio)
        {
            string sql = "UPDATE cartas SET elemento=@el, numero_at=@n, raio_at=@r WHERE id_card=@id";

            c.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("el", elemento);
            cmd.Parameters.AddWithValue("n", num);
            cmd.Parameters.AddWithValue("r", raio);

            int a = cmd.ExecuteNonQuery();

            c.Close();

            if (a <= 0) return false;

			return true;
        }

        //EXCLUIR cartas
        public bool deleteCard(int id)
        {
            string sql = "UPDATE cartas SET excluido=TRUE WHERE id_card=@id";

            c.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(sql, c);
            cmd.Parameters.AddWithValue("id", id);

            int a = cmd.ExecuteNonQuery();

            c.Close();

            if (a <= 0) return false;

            return true;
        }
    }
}
