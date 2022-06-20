using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft
{
    public partial class ClientForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int id_client;

        public ClientForm()
        {
            InitializeComponent();
        }

		public void UpdateTable()
		{
			try
			{
                var clients = from cli in db.clients
                              select new
                              {
                                  Id = cli.Id,
                                  FirstName = cli.FirstName,
                                  MiddleName = cli.MiddleName,
                                  LastName = cli.LastName, 
                                  Phone = cli.Phone,
                                  Email = cli.Email
                              };
                
                Client_table.DataSource = clients.ToList();

                if (Client_table.Rows.Count > 0)
                {
                    Client_table.Columns[0].HeaderText = "№";
                    Client_table.Columns[0].Width = 25;
                    Client_table.Columns[1].HeaderText = "Имя";
                    Client_table.Columns[2].HeaderText = "Фамилия";
                    Client_table.Columns[3].HeaderText = "Отчество";
                    Client_table.Columns[4].HeaderText = "Номер телефона";
                    Client_table.Columns[5].HeaderText = "Почта";

                    id_client = Convert.ToInt32(Client_table[0, 0].Value);

                }
                else
                {
                    Client_table.Columns[0].HeaderText = "№";
                    Client_table.Columns[0].Width = 25;
                    Client_table.Columns[1].HeaderText = "Имя";
                    Client_table.Columns[2].HeaderText = "Фамилия";
                    Client_table.Columns[3].HeaderText = "Отчество";
                    Client_table.Columns[4].HeaderText = "Номер телефона";
                    Client_table.Columns[5].HeaderText = "Почта";
                }
                    

            }

			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Back_btn_Click(object sender, EventArgs e)
        {

            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
            mainForm.ShowInTaskbar = true;
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreateClientForm createClientForm = new CreateClientForm();
            createClientForm.Show();
            this.Hide();
        }
        private void Client_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_client = Convert.ToInt32(Client_table[0, e.RowIndex].Value);
        }
        private void Client_table_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            EditClientForm editClientForm = new EditClientForm(id_client);
            editClientForm.Visible = true;
            editClientForm.ShowInTaskbar = true;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try 
                {
                    var clientSup = db.supplies.FirstOrDefault(a => a.ClientId == id_client);
                    var clientDem = db.demands.FirstOrDefault(b => b.ClientId == id_client);
                    if (clientSup == null || clientDem == null)
                    {
                        clients client = db.clients.Where(p => p.Id == id_client).FirstOrDefault();
                        db.clients.Remove(client);
                        db.SaveChanges();
                        UpdateTable();

                        MessageBox.Show("Удаление прошло успешно!");

                    }
                    else 
                    {
                        MessageBox.Show("Данный клиент не может быть удалён!");
                    };

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
 
            }

        }
    }
}
