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
    public partial class EditSuppliesForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int ID;
        supplies supplie;

        public EditSuppliesForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            SuppliesForm suppliesForm = new SuppliesForm();
            suppliesForm.ShowDialog();
            this.Close();
        }

        private void EditSuppliesForm_Load(object sender, EventArgs e)
        {
            try
            {
                supplie = db.supplies.Where(p => p.Id == ID).FirstOrDefault();

                Price_txt.Text = Convert.ToString(supplie.Price);

                var tableType1 = db.property.ToList();
                RealEstate_comboBox.DataSource = tableType1;
                RealEstate_comboBox.DisplayMember = "Address_Street";
                RealEstate_comboBox.ValueMember = "Id";
                RealEstate_comboBox.SelectedValue = supplie.RealEstateId;

                var tableType2 = db.agents.ToList();
                Agent_comboBox.DataSource = tableType2;
                Agent_comboBox.DisplayMember = "FirstName";
                Agent_comboBox.ValueMember = "Id";
                Agent_comboBox.SelectedValue = supplie.AgentId;

                var tableType3 = db.clients.ToList();
                Client_comboBox.DataSource = tableType3;
                Client_comboBox.DisplayMember = "FirstName";
                Client_comboBox.ValueMember = "Id";
                Client_comboBox.SelectedValue = supplie.ClientId;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Price_txt.Text == "")
            {
                MessageBox.Show("Введите цену!");
                return;
            }
            try
            {
                supplies supplie = db.supplies.Where(p => p.Id == ID).FirstOrDefault();

                supplie.RealEstateId = Convert.ToInt32(RealEstate_comboBox.SelectedValue);
                supplie.AgentId = Convert.ToInt32(Agent_comboBox.SelectedValue);
                supplie.ClientId = Convert.ToInt32(Client_comboBox.SelectedValue);
                supplie.Price = Convert.ToInt32(Price_txt.Text);

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
    }
}
