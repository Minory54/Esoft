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
    public partial class EditDemandsForm : Form
    {

        EsoftEntities db = new EsoftEntities();
        int ID;
        demands demand;

        public EditDemandsForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            DemandsForm demandsForm = new DemandsForm();
            demandsForm.Show();
            this.Hide();
        }

        private void EditDemandsForm_Load(object sender, EventArgs e)
        {
            MinPrice_txt.Visible = false;
            MaxPrice_txt.Visible = false;
            MinArea_txt.Visible = false;
            MaxArea_txt.Visible = false;
            MinFloor_txt.Visible = false;
            MaxFloor_txt.Visible = false;
            MinRooms_txt.Visible = false;
            MaxRooms_txt.Visible = false;

            try
            {
                demand = db.demands.Where(p => p.Id == ID).FirstOrDefault();

                AddressCity_txt.Text = demand.Address_City;
                AddressStreet_txt.Text = demand.Address_Street;
                AddressHouse_txt.Text = demand.Address_House;
                AddressNumber_txt.Text = demand.Address_Number;
                MinPrice_txt.Text = Convert.ToString(demand.MinPrice);
                MaxPrice_txt.Text = Convert.ToString(demand.MaxPrice);

                MinArea_txt.Text = Convert.ToString(demand.MinArea);
                MaxArea_txt.Text = Convert.ToString(demand.MaxArea);

                MinFloor_txt.Text = Convert.ToString(demand.MinFloor);
                MaxFloor_txt.Text = Convert.ToString(demand.MaxFloor);

                MinRooms_txt.Text = Convert.ToString(demand.MinRooms);
                MaxRooms_txt.Text = Convert.ToString(demand.MaxRooms);


                var tableType1 = db.clients.ToList();
                Client_comboBox.DataSource = tableType1;
                Client_comboBox.DisplayMember = "FirstName";
                Client_comboBox.ValueMember = "Id";
                Client_comboBox.SelectedValue = demand.ClientId;

                var tableType2 = db.agents.ToList();
                Agent_comboBox.DataSource = tableType2;
                Agent_comboBox.DisplayMember = "FirstName";
                Agent_comboBox.ValueMember = "Id";
                Agent_comboBox.SelectedValue = demand.AgentId;

                var tableType3 = db.typeProperty.ToList();
                Type_comboBox.DataSource = tableType3;
                Type_comboBox.DisplayMember = "name";
                Type_comboBox.ValueMember = "Id";
                Type_comboBox.SelectedValue = demand.TypeId;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_comboBox.SelectedIndex == 0 || Type_comboBox.SelectedIndex == 1)
            {
                MinPrice_txt.Visible = true;
                MaxPrice_txt.Visible = true;
                MinArea_txt.Visible = true;
                MaxArea_txt.Visible = true;
                MinFloor_txt.Visible = true;
                MaxFloor_txt.Visible = true;
                MinRooms_txt.Visible = true;
                MaxRooms_txt.Visible = true;
            }
            else
            {
                MinPrice_txt.Visible = false;
                MaxPrice_txt.Visible = false;
                MinArea_txt.Visible = true;
                MaxArea_txt.Visible = true;
                MinFloor_txt.Visible = false;
                MaxFloor_txt.Visible = false;
                MinRooms_txt.Visible = false;
                MaxRooms_txt.Visible = false;
            };
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (MinPrice_txt.Text == "" || MaxPrice_txt.Text == "")
            {
                MessageBox.Show("Введите стоимость");
                return;
            }
            try
            {

                demands demand = db.demands.Where(p => p.Id == ID).FirstOrDefault();

                demand.Address_City = Convert.ToString(AddressCity_txt.Text);
                demand.Address_Street = Convert.ToString(AddressStreet_txt.Text);
                demand.Address_House = Convert.ToString(AddressHouse_txt.Text);
                demand.Address_Number = Convert.ToString(AddressNumber_txt.Text);

                demand.MinPrice = Convert.ToInt32(MinPrice_txt.Text);
                demand.MaxPrice = Convert.ToInt32(MaxPrice_txt.Text);

                demand.MinArea = Convert.ToString(MinArea_txt.Text);
                demand.MaxArea = Convert.ToString(MaxArea_txt.Text);

                demand.MinFloor = Convert.ToString(MinFloor_txt.Text);
                demand.MaxFloor = Convert.ToString(MaxFloor_txt.Text);

                demand.MinRooms = Convert.ToString(MinRooms_txt.Text);
                demand.MaxRooms = Convert.ToString(MaxRooms_txt.Text);

                demand.TypeId = Convert.ToInt32(Type_comboBox.SelectedValue);
                demand.ClientId = Convert.ToInt32(Client_comboBox.SelectedValue);
                demand.AgentId = Convert.ToInt32(Agent_comboBox.SelectedValue);

                db.SaveChanges();

                DemandsForm demandeForm = new DemandsForm();
                demandeForm.UpdateTable_Apartament();
                demandeForm.UpdateTable_House();
                demandeForm.UpdateTable_Lands();
                demandeForm.Show();
                this.Hide();

                MessageBox.Show("Изменение прошло успешно!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
