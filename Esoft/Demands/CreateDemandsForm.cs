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
    public partial class CreateDemandsForm : Form
    {
        EsoftEntities db = new EsoftEntities();

        public CreateDemandsForm()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            DemandsForm demandsForm = new DemandsForm();
            demandsForm.Visible = true;
            demandsForm.ShowInTaskbar = true;
        }

        private void CreateDemandsForm_Load(object sender, EventArgs e)
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
                var tableType1 = db.clients.ToList();
                Client_comboBox.DataSource = tableType1;
                Client_comboBox.DisplayMember = "FirstName";
                Client_comboBox.ValueMember = "Id";

                var tableType2 = db.agents.ToList();
                Agent_comboBox.DataSource = tableType2;
                Agent_comboBox.DisplayMember = "FirstName";
                Agent_comboBox.ValueMember = "Id";

                var tableType3 = db.typeProperty.ToList();
                Type_comboBox.DataSource = tableType3;
                Type_comboBox.DisplayMember = "name";
                Type_comboBox.ValueMember = "Id";
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

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (MinPrice_txt.Text == "" || MaxPrice_txt.Text == "")
            {
                MessageBox.Show("Введите стоимость");
                return;
            }
            try
            {

                demands demand = new demands
                {
                    Address_City = Convert.ToString(AddressCity_txt.Text),
                    Address_Street = Convert.ToString(AddressStreet_txt.Text),
                    Address_House = Convert.ToString(AddressHouse_txt.Text),
                    Address_Number = Convert.ToString(AddressNumber_txt.Text),

                    MinPrice = Convert.ToInt32(MinPrice_txt.Text),
                    MaxPrice = Convert.ToInt32(MaxPrice_txt.Text),

                    MinArea = Convert.ToString(MinArea_txt.Text),
                    MaxArea = Convert.ToString(MaxArea_txt.Text),

                    MinFloor = Convert.ToString(MinFloor_txt.Text),
                    MaxFloor = Convert.ToString(MaxFloor_txt.Text),

                    MinRooms = Convert.ToString(MinRooms_txt.Text),
                    MaxRooms = Convert.ToString(MaxRooms_txt.Text),

                    TypeId = Convert.ToInt32(Type_comboBox.SelectedValue),
                    ClientId = Convert.ToInt32(Client_comboBox.SelectedValue),
                    AgentId = Convert.ToInt32(Agent_comboBox.SelectedValue),
                };

                db.demands.Add(demand);
                db.SaveChanges();

                DemandsForm demandsForm = new DemandsForm();
                demandsForm.UpdateTable_Apartament();
                demandsForm.UpdateTable_House();
                demandsForm.UpdateTable_Lands();
                demandsForm.Show();
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
