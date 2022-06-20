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
    public partial class AgentForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int id_agent;

        public AgentForm()
        {
            InitializeComponent();
        }

        public void UpdateTable() // Этот метод нужен для обновления данных в таблице после после манипуляций
        {
            try
            {
                var agents = from ag in db.agents
                              select new
                              {
                                  Id = ag.Id,
                                  FirstName = ag.FirstName,
                                  MiddleName = ag.MiddleName,
                                  LastName = ag.LastName,
                                  DealShare = ag.DealShare,
                              };

                Agents_table.DataSource = agents.ToList();

                if (Agents_table.Rows.Count > 0)
                {
                    Agents_table.Columns[0].HeaderText = "№";
                    Agents_table.Columns[0].Width = 25;
                    Agents_table.Columns[1].HeaderText = "Имя";
                    Agents_table.Columns[2].HeaderText = "Фамилия";
                    Agents_table.Columns[3].HeaderText = "Отчество";
                    Agents_table.Columns[4].HeaderText = "Доля";

                    id_agent = Convert.ToInt32(Agents_table[0, 0].Value);

                }
                else
                {
                    Agents_table.Columns[0].HeaderText = "№";
                    Agents_table.Columns[0].Width = 25;
                    Agents_table.Columns[1].HeaderText = "Имя";
                    Agents_table.Columns[2].HeaderText = "Фамилия";
                    Agents_table.Columns[3].HeaderText = "Отчество";
                    Agents_table.Columns[4].HeaderText = "Доля";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void Create_btn_Click(object sender, EventArgs e)
        //{
        //    CreateAgentsForm createAgentsForm = new CreateAgentsForm();
        //    createAgentsForm.Show();
        //    this.Hide();
        //}

        private void AgentForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void Agents_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_agent = Convert.ToInt32(Agents_table[0, e.RowIndex].Value);
        }

        private void Back_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
            mainForm.ShowInTaskbar = true;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreateAgentsForm createAgentsForm = new CreateAgentsForm();
            createAgentsForm.Show();
            this.Hide();
        }

        private void Agents_table_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            EditAgentsForm editAgentsForm = new EditAgentsForm(id_agent);
            editAgentsForm.Visible = true;
            editAgentsForm.ShowInTaskbar = true;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого риэлтора?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var agentSup = db.supplies.FirstOrDefault(a => a.AgentId == id_agent);
                    var agentDem = db.demands.FirstOrDefault(b => b.AgentId == id_agent);
                    if (agentSup == null || agentDem == null)
                    {
                        agents agent = db.agents.Where(p => p.Id == id_agent).FirstOrDefault();
                        db.agents.Remove(agent);
                        db.SaveChanges();
                        UpdateTable();

                        MessageBox.Show("Удаление прошло успешно!");

                    }
                    else
                    {
                        MessageBox.Show("Данный риэлтор не может быть удалён!");
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
