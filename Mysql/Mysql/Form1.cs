using MySql.Data.MySqlClient;
namespace Mysql
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_souce = "datasource=localhost;username=root;password=;database=teste";
                //criar a conexão com o Mysql
                conexao = new MySqlConnection(data_souce);
                //Executar Comando Insert

                string sql = "INSERT INTO contato (nome, email, telefone) " + 
                    "VALUES" +
                    "('" + textBox1.Text +"','" + textBox2.Text + "','"  + textBox3.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql,conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo, Inserido");
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}