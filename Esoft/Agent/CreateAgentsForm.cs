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
    public partial class CreateAgentsForm : Form
    {
        EsoftEntities db = new EsoftEntities();

        public CreateAgentsForm()
        {
            InitializeComponent();
        }

        private void Create_btn_Click_1(object sender, EventArgs e)
        {
            if (FirstName_txt.Text == "" || MiddleName_txt.Text == "" || LastName_txt.Text == "")
            {
                MessageBox.Show("Введите ФИО полностью!");
                return;
            }
            try
            {
                agents agent = new agents
                {
                    FirstName = Convert.ToString(FirstName_txt.Text),
                    MiddleName = Convert.ToString(MiddleName_txt.Text),
                    LastName = Convert.ToString(LastName_txt.Text),
                    DealShare = Convert.ToInt32(Deal_txt.Text),
                };

                db.agents.Add(agent);
                db.SaveChanges();
                AgentForm agentForm = new AgentForm();
                agentForm.Show();
                this.Hide();

                MessageBox.Show("Добавление прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Back_btn_Click_1(object sender, EventArgs e)
        {
            AgentForm agentForm = new AgentForm();
            agentForm.Show();
            this.Hide();
        }
    }
}
