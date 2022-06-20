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
    public partial class SuppliesForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int id;

        public SuppliesForm()
        {
            InitializeComponent();
        }

        private void SuppliesForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable() // Этот метод нужен для обновления данных в таблице после после манипуляций
        {
            try
            {
                var supplies = from sup in db.supplies
                              join agent in db.agents on sup.AgentId equals agent.Id
                              join clients in db.clients on sup.ClientId equals clients.Id
                              join property in db.property on sup.RealEstateId equals property.Id
                               select new
                              {
                                  Id = sup.Id,
                                  RealEstateId = property.Address_Street,
                                  AgentId = agent.FirstName,
                                  ClientId = clients.FirstName,
                                  Price = sup.Price,
                              };

                Supplies_table.DataSource = supplies.ToList();

                if (Supplies_table.Rows.Count > 0)
                {
                    Supplies_table.Columns[0].HeaderText = "№";
                    Supplies_table.Columns[0].Width = 25;
                    Supplies_table.Columns[4].HeaderText = "Цена";
                    Supplies_table.Columns[2].HeaderText = "Риэлтор";
                    Supplies_table.Columns[3].HeaderText = "Клиент";
                    Supplies_table.Columns[1].HeaderText = "Недвижимость";

                    id = Convert.ToInt32(Supplies_table[0, 0].Value);

                }
                else
                {
                    Supplies_table.Columns[0].HeaderText = "№";
                    Supplies_table.Columns[0].Width = 25;
                    Supplies_table.Columns[4].HeaderText = "Цена";
                    Supplies_table.Columns[2].HeaderText = "Риэлтор";
                    Supplies_table.Columns[3].HeaderText = "Клиент";
                    Supplies_table.Columns[1].HeaderText = "Недвижимость";
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

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreateSuppliesForm createSuppliesForm = new CreateSuppliesForm();
            createSuppliesForm.Show();
            this.Hide();
        }

        private void Supplies_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(Supplies_table[0, e.RowIndex].Value);
        }

        private void Supplies_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            EditSuppliesForm editSuppliesForm = new EditSuppliesForm(id);
            editSuppliesForm.Visible = true;
            editSuppliesForm.ShowInTaskbar = true;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить это предложение?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    supplies supplie = db.supplies.Where(p => p.Id == id).FirstOrDefault();
                    db.supplies.Remove(supplie);
                    db.SaveChanges();
                    UpdateTable();

                    MessageBox.Show("Удаление прошло успешно!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
