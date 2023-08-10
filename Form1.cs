using MySql.Data.MySqlClient;

namespace Crud_Adm_Root_C_
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;


        public Form1()
        {
            InitializeComponent();
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

                string data_source = "datasource=localhost;username=root;password=Bnas123!@#;database=NET";
                //Criar conexão Mysql
                conn = new MySqlConnection(data_source);

                string sql = "INSERT INTO Cadastro_teste (nome, telefone, email, senha) VALUES ('"  + textNome + "','" + textTelefone + "','" + textEmail + "','"  + textSenha +"')";


                //Executar Conexão
                MySqlCommand comando = new MySqlCommand(sql, conn);

                conn.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo Inserido!!!");


                

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}