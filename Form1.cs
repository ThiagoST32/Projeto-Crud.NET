using MySql.Data.MySqlClient;

namespace Crud_Adm_Root_C_
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string data_source = "datasource=localhost;username=root;password=Bnas123!@#;database=NET;";

        public Form1()
        {
            InitializeComponent();

            ListViewBuscarDados.View = View.Details;
            ListViewBuscarDados.LabelEdit = true;
            ListViewBuscarDados.AllowColumnReorder = false;
            ListViewBuscarDados.FullRowSelect = true;
            ListViewBuscarDados.GridLines = true;


            ListViewBuscarDados.Columns.Add("Id", 30, HorizontalAlignment.Left);
            ListViewBuscarDados.Columns.Add("Nome", 75, HorizontalAlignment.Left);
            ListViewBuscarDados.Columns.Add("Telefone", 75, HorizontalAlignment.Left);
            ListViewBuscarDados.Columns.Add("Email", 75, HorizontalAlignment.Left);
            ListViewBuscarDados.Columns.Add("Senha", 75, HorizontalAlignment.Left);

            carregarContatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexão Mysql
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Cadastro_teste (nome, telefone, email, senha) VALUES (@nome,@telefone, @email, @senha)";

                cmd.Parameters.AddWithValue("@nome", textNome.Text);
                cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@senha", textSenha.Text);
                cmd.ExecuteNonQuery();

                cmd.Prepare();

                MessageBox.Show("Deu tudo certo Inserido!!!");

                textNome.Text = string.Empty;
                textEmail.Text = string.Empty;
                textTelefone.Text = string.Empty;
                textSenha.Text = string.Empty;

                carregarContatos();

                conn.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBuscarDados_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM Cadastro_teste WHERE nome LIKE @SelectBusca OR email LIKE @SelectBusca";

                cmd.Parameters.AddWithValue("@SelectBusca", "'%" + textBuscarDados.Text + "%'");

                cmd.Prepare();

                conn.Close();


                string buscar = "'%" + textBuscarDados.Text + "%'";

                string buscarDados = "SELECT * FROM Cadastro_teste WHERE nome LIKE " + buscar + "";

                MySqlCommand comando = new MySqlCommand(buscarDados, conn);

                conn.Open();

                MySqlDataReader readder = comando.ExecuteReader();

                ListViewBuscarDados.Items.Clear();

                while (readder.Read())
                {

                    string[] row =
                    {
                        readder.GetString(0),
                        readder.GetString(1),
                        readder.GetString(2),
                        readder.GetString(3),
                        readder.GetString(4),
                    };


                    ListViewBuscarDados.Items.Add(new ListViewItem(row));
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO " + ex.Number + " ocorreu " + ex.Message,
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        private void carregarContatos()
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM Cadastro_teste ORDER BY idCadastro_teste";

                cmd.Prepare();

                conn.Close();


                string buscar = "'%" + textBuscarDados.Text + "%'";

                string buscarDados = "SELECT * FROM Cadastro_teste WHERE nome LIKE " + buscar + "";

                MySqlCommand comando = new MySqlCommand(buscarDados, conn);

                conn.Open();

                MySqlDataReader readder = comando.ExecuteReader();

                ListViewBuscarDados.Items.Clear();

                while (readder.Read())
                {

                    string[] row =
                    {
                        readder.GetString(0),
                        readder.GetString(1),
                        readder.GetString(2),
                        readder.GetString(3),
                        readder.GetString(4),
                    };


                    ListViewBuscarDados.Items.Add(new ListViewItem(row));
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO " + ex.Number + " ocorreu " + ex.Message,
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}