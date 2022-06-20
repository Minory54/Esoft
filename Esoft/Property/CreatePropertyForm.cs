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
    public partial class CreatePropertyForm : Form
    {
        EsoftEntities db = new EsoftEntities();

        public CreatePropertyForm()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            PropertyForm propertyForm = new PropertyForm();
            propertyForm.Show();
            this.Hide();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (AddressCity_txt.Text == "" && AddressStreet_txt.Text == "" && AddressHouse_txt.Text == "" && AddressNumber_txt.Text == "" && Floor_txt.Text == "" && Rooms_txt.Text == "" && Area_txt.Text == "")
            {
                MessageBox.Show("Заполните хотябы одно поле!");
                return;
            }
            if (Area_txt.Text == "")
            {
                MessageBox.Show("Введите площадь!");
                return;
            }
            try
            {
                property propert = new property
                {
                    Address_City = Convert.ToString(AddressCity_txt.Text),
                    Address_Street = Convert.ToString(AddressStreet_txt.Text),
                    Address_House = Convert.ToString(AddressHouse_txt.Text),
                    Address_Number = Convert.ToString(AddressNumber_txt.Text),
                    Floor = Convert.ToString(Floor_txt.Text), 
                    Rooms = Convert.ToString(Rooms_txt.Text), 
                    TotalArea = Convert.ToDouble(Area_txt.Text),
                    TypeId = Convert.ToInt32(Type_comboBox.SelectedValue)
                };

                db.property.Add(propert);
                db.SaveChanges();

                PropertyForm propertyForm = new PropertyForm();
                propertyForm.UpdateTable_Apartament();
                propertyForm.UpdateTable_House();
                propertyForm.UpdateTable_Lands();
                propertyForm.Show();
                this.Hide();

                MessageBox.Show("Добавление прошло успешно!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CreatePropertyForm_Load(object sender, EventArgs e)
        {
            Rooms_txt.Visible = false;
            Floor_txt.Visible = false;
            Area_txt.Visible = false;

            try
            {
                var tableType = db.typeProperty.ToList();
                Type_comboBox.DataSource = tableType;
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
                Rooms_txt.Visible = true;
                Floor_txt.Visible = true;
                Area_txt.Visible = true;
            }
            else 
            {
                Rooms_txt.Visible = false;
                Floor_txt.Visible = false;
                Area_txt.Visible = true;
            };
        }
    }
}
