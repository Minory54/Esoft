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
    public partial class CreateSuppliesForm : Form
    {
        EsoftEntities db = new EsoftEntities();

        public CreateSuppliesForm()
        {
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (Price_txt.Text == "")
            {
                MessageBox.Show("Введите цену!");
                return;
            }
            try
            {
                supplies supplie = new supplies
                {
                    RealEstateId = Convert.ToInt32(RealEstate_comboBox.SelectedValue),
                    AgentId = Convert.ToInt32(Agent_comboBox.SelectedValue),
                    ClientId = Convert.ToInt32(Client_comboBox.SelectedValue),
                    Price = Convert.ToInt32(Price_txt.Text)
                    
                };

                db.supplies.Add(supplie);
                db.SaveChanges();

                SuppliesForm suppliesForm = new SuppliesForm();
                suppliesForm.UpdateTable();
                suppliesForm.Show();
                this.Hide();

                MessageBox.Show("Добавление прошло успешно!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            SuppliesForm suppliesForm = new SuppliesForm();
            suppliesForm.Show();
            this.Hide();
        }

        private void CreateSuppliesForm_Load(object sender, EventArgs e)
        {
            try
            {
                var tableType1 = db.property.ToList();
                RealEstate_comboBox.DataSource = tableType1;
                RealEstate_comboBox.DisplayMember = "Address_Street";
                RealEstate_comboBox.ValueMember = "Id";

                var tableType2 = db.agents.ToList();
                Agent_comboBox.DataSource = tableType2;
                Agent_comboBox.DisplayMember = "FirstName";
                Agent_comboBox.ValueMember = "Id";

                var tableType3 = db.clients.ToList();
                Client_comboBox.DataSource = tableType3;
                Client_comboBox.DisplayMember = "FirstName";
                Client_comboBox.ValueMember = "Id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
