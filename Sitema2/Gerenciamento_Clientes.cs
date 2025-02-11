using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sitema2
{
    public partial class Gerenciamento_Clientes : Form
    {
        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {

            //Defina sua string de conexão com o banco
            string conectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {

                    consulta.Open();
                    string listagem = "SELECT Id_Cliente , NomeCompleto, Telefone FROM tb_clientes";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        dgvClientes.DataSource = dadosClientes;
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes " + ex.Message);
            }

        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {

                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente? ", "confirmar excluxão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {


                    string conectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(conectionString))
                        {

                            consulta.Open();
                            string listagem = "DELETE FROM tb_clientes WHERE Id_Cliente = @Id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {

                                cmd.Parameters.AddWithValue("Id_cliente", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("cliente excluido");
                                }
                                else
                                {
                                    MessageBox.Show("falha ao excluir o cliente");
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os clientes " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("por favor selecione um cliente para excluir");
                }

            }

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}