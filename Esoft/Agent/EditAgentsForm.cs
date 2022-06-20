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
    public partial class EditAgentsForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int ID;
        agents agent;

        public EditAgentsForm(int id_agent)
        {
            InitializeComponent();
            ID = id_agent;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (FirstName_txt.Text == "" || MiddleName_txt.Text == "" || LastName_txt.Text == "")
            {
                MessageBox.Show("Введите ФИО полностью!");
                return;
            }
            try
            {
                agents agent = db.agents.Where(i => i.Id == ID).FirstOrDefault();

                agent.FirstName = FirstName_txt.Text;
                agent.MiddleName = MiddleName_txt.Text;
                agent.LastName = LastName_txt.Text;
                agent.DealShare = Convert.ToInt32(Deal_txt.Text);

                db.SaveChanges();
                this.Close();

                MessageBox.Show("Изменение прошло успешно!");
                AgentForm agentForm = new AgentForm();
                agentForm.Show();
                this.Hide();
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

        private void EditAgentsForm_Load(object sender, EventArgs e)
        {
            agent = db.agents.Where(i => i.Id == ID).FirstOrDefault();

            FirstName_txt.Text = agent.FirstName;
            MiddleName_txt.Text = agent.MiddleName;
            LastName_txt.Text = agent.LastName;
            Deal_txt.Text = Convert.ToString(agent.DealShare);
        }
    }
}
