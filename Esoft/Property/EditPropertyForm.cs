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
    public partial class EditPropertyForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int ID;
        property proper;

        public EditPropertyForm(int id_prop)
        {
            InitializeComponent();
            ID = id_prop;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            PropertyForm propertyForm = new PropertyForm();
            propertyForm.Show();
            this.Hide();
        }

        private void EditPropertyForm_Load(object sender, EventArgs e)
        {
            Rooms_txt.Visible = false;
            Floor_txt.Visible = false;
            Area_txt.Visible = false;

            try
            {
                proper = db.property.Where(p => p.Id == ID).FirstOrDefault();

                AddressCity_txt.Text = proper.Address_City;
                AddressStreet_txt.Text = proper.Address_Street;
                AddressHouse_txt.Text = proper.Address_House;
                AddressNumber_txt.Text = proper.Address_Number;
                Area_txt.Text = Convert.ToString(proper.TotalArea);


                var tableType = db.typeProperty.ToList();
                Type_comboBox.DataSource = tableType;
                Type_comboBox.DisplayMember = "name";
                Type_comboBox.ValueMember = "Id";
                Type_comboBox.SelectedValue = proper.TypeId;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
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

                property proper = db.property.Where(p => p.Id == ID).FirstOrDefault();

                proper.Address_City = Convert.ToString(AddressCity_txt.Text);
                proper.Address_Street = Convert.ToString(AddressStreet_txt.Text);
                proper.Address_House = Convert.ToString(AddressHouse_txt.Text);
                proper.Address_Number = Convert.ToString(AddressNumber_txt.Text);
                proper.Floor = Convert.ToString(Floor_txt.Text);
                proper.Rooms = Convert.ToString(Rooms_txt.Text);
                proper.TotalArea = Convert.ToDouble(Area_txt.Text);
                proper.TypeId = Convert.ToInt32(Type_comboBox.SelectedValue);

                db.SaveChanges();

                PropertyForm propertyForm = new PropertyForm();
                propertyForm.UpdateTable_Apartament();
                propertyForm.UpdateTable_House();
                propertyForm.UpdateTable_Lands();
                propertyForm.Show();
                this.Hide();

                MessageBox.Show("Изменение прошло успешно!");
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
