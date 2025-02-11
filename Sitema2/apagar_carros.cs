using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sitema2
{
    public partial class apagar_carros : Form
    {
        public apagar_carros()
        {
            InitializeComponent();
        }

        private void buttonPesquisarcarros_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string conectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(conectionString))
                {

                    consulta.Open();
                    string listagem = "SELECT id_carros, Proprietario, Telefone FROM tb_carros";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        dgvCarros.DataSource = dadosClientes;
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

            if (dgvCarros.SelectedRows.Count > 0)
            {

                int carroID = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells["id_carros"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este carro? ", "confirmar excluxão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {


                    string conectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(conectionString))
                        {

                            consulta.Open();
                            string listagem = "DELETE FROM tb_carros WHERE id_carros = @id_carros";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {

                                cmd.Parameters.AddWithValue("id", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("carro excluido");
                                }
                                else
                                {
                                    MessageBox.Show("falha ao excluir o carro");
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os carros " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("por favor selecione um carro para excluir");
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

        private void buttonRemoverCarros_Click(object sender, EventArgs e)
        {

            if (dgvCarros.SelectedRows.Count > 0)
            {

                int carroID = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells["id_carros"].Value);
                //id_carros  tb_carros

               DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este carro? ", "confirmar excluxão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {


                    string conectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {

                        using (MySqlConnection consulta = new MySqlConnection(conectionString))
                        {

                            consulta.Open();
                            string listagem = "DELETE FROM tb_carros WHERE id_carros = @id_carros";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {

                                cmd.Parameters.AddWithValue("id_carros", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("carro excluido");
                                }
                                else
                                {
                                    MessageBox.Show("falha ao excluir o carro");
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os carro " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("por favor selecione um carro para excluir");
                }

            }

        }

        private void dgvCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFechar_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

    
