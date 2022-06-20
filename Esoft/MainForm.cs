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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
            ClientForm clientInfo = new ClientForm();
            clientInfo.Show();
            this.Hide();
        }

        private void Property_btn_Click(object sender, EventArgs e)
        {
            PropertyForm propertyForm = new PropertyForm();
            propertyForm.Show();
            this.Hide();
        }

        private void Agent_btn_Click(object sender, EventArgs e)
        {
            AgentForm agentForm = new AgentForm();
            agentForm.Show();
            this.Hide();
        }

        private void Supplies_btn_Click(object sender, EventArgs e)
        {
            SuppliesForm suppliesForm = new SuppliesForm();
            suppliesForm.Show();
            this.Hide();
        }

        private void Demands_btn_Click(object sender, EventArgs e)
        {
            DemandsForm suppliesForm = new DemandsForm();
            suppliesForm.Show();
            this.Hide();
        }
    }
}
