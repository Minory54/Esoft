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
    public partial class PropertyForm : Form
    {

        EsoftEntities db = new EsoftEntities();
        int id_prop;

        public PropertyForm()
        {
            InitializeComponent();
        }

        public void UpdateTable_Apartament()
        {
            try
            {
                var property = from prop in db.property 
                              join tprop in db.typeProperty on prop.TypeId equals tprop.Id
                              where prop.TypeId == 1 
                              select new
                              {
                                  Id = prop.Id,
                                  TypeProp = tprop.name,
                                  Address_City = prop.Address_City,
                                  Address_Street = prop.Address_Street,
                                  Address_House = prop.Address_House,
                                  Address_Number = prop.Address_Number,
                                  Floor = prop.Floor,
                                  Rooms = prop.Rooms,
                                  TotalArea = prop.TotalArea
                              };

                Apartament_table.DataSource = property.ToList();

                if (Apartament_table.Rows.Count > 0)
                {
                    Apartament_table.Columns[0].HeaderText = "№";
                    Apartament_table.Columns[0].Width = 25;
                    Apartament_table.Columns[1].HeaderText = "Тип";
                    Apartament_table.Columns[2].HeaderText = "Город";
                    Apartament_table.Columns[3].HeaderText = "Улица";
                    Apartament_table.Columns[4].HeaderText = "Дом";
                    Apartament_table.Columns[5].HeaderText = "Квартира";
                    Apartament_table.Columns[6].HeaderText = "Этаж";
                    Apartament_table.Columns[7].HeaderText = "Кол.комнат";
                    Apartament_table.Columns[8].HeaderText = "Площадь";

                    id_prop = Convert.ToInt32(Apartament_table[0, 0].Value);

                }
                else
                {
                    Apartament_table.Columns[0].HeaderText = "№";
                    Apartament_table.Columns[0].Width = 25;
                    Apartament_table.Columns[1].HeaderText = "Тип";
                    Apartament_table.Columns[2].HeaderText = "Город";
                    Apartament_table.Columns[3].HeaderText = "Улица";
                    Apartament_table.Columns[4].HeaderText = "Дом";
                    Apartament_table.Columns[5].HeaderText = "Квартира";
                    Apartament_table.Columns[6].HeaderText = "Этаж";
                    Apartament_table.Columns[7].HeaderText = "Кол.комнат";
                    Apartament_table.Columns[8].HeaderText = "Площадь";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void UpdateTable_House() 
        {

            try
            {
                var property = from prop in db.property
                               join tprop in db.typeProperty on prop.TypeId equals tprop.Id
                               where prop.TypeId == 2
                               select new
                               {
                                   Id = prop.Id,
                                   TypeProp = tprop.name,
                                   Address_City = prop.Address_City,
                                   Address_Street = prop.Address_Street,
                                   Address_House = prop.Address_House,
                                   Address_Number = prop.Address_Number,
                                   Floor = prop.Floor,
                                   Rooms = prop.Rooms,
                                   TotalArea = prop.TotalArea
                               };

                House_table.DataSource = property.ToList();

                if (House_table.Rows.Count > 0)
                {
                    House_table.Columns[0].HeaderText = "№";
                    House_table.Columns[0].Width = 25;
                    House_table.Columns[1].HeaderText = "Тип";
                    House_table.Columns[2].HeaderText = "Город";
                    House_table.Columns[3].HeaderText = "Улица";
                    House_table.Columns[4].HeaderText = "Дом";
                    House_table.Columns[5].HeaderText = "Квартира";
                    House_table.Columns[6].HeaderText = "Этаж";
                    House_table.Columns[7].HeaderText = "Кол.комнат";
                    House_table.Columns[8].HeaderText = "Площадь";

                    id_prop = Convert.ToInt32(House_table[0, 0].Value);

                }
                else
                {
                    House_table.Columns[0].HeaderText = "№";
                    House_table.Columns[0].Width = 25;
                    House_table.Columns[1].HeaderText = "Тип";
                    House_table.Columns[2].HeaderText = "Город";
                    House_table.Columns[3].HeaderText = "Улица";
                    House_table.Columns[4].HeaderText = "Дом";
                    House_table.Columns[5].HeaderText = "Квартира";
                    House_table.Columns[6].HeaderText = "Этаж";
                    House_table.Columns[7].HeaderText = "Кол.комнат";
                    House_table.Columns[8].HeaderText = "Площадь";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        public void UpdateTable_Lands()
        {

            try
            {
                var property = from prop in db.property
                               join tprop in db.typeProperty on prop.TypeId equals tprop.Id
                               where prop.TypeId == 3
                               select new
                               {
                                   Id = prop.Id,
                                   TypeProp = tprop.name,
                                   Address_City = prop.Address_City,
                                   Address_Street = prop.Address_Street,
                                   Address_House = prop.Address_House,
                                   Address_Number = prop.Address_Number,
                                   TotalArea = prop.TotalArea
                               };

                Lands_table.DataSource = property.ToList();

                if (Lands_table.Rows.Count > 0)
                {
                    Lands_table.Columns[0].HeaderText = "№";
                    Lands_table.Columns[0].Width = 25;
                    Lands_table.Columns[1].HeaderText = "Тип";
                    Lands_table.Columns[2].HeaderText = "Город";
                    Lands_table.Columns[3].HeaderText = "Улица";
                    Lands_table.Columns[4].HeaderText = "Дом";
                    Lands_table.Columns[5].HeaderText = "Квартира";
                    Lands_table.Columns[6].HeaderText = "Площадь";

                    id_prop = Convert.ToInt32(Lands_table[0, 0].Value);

                }
                else
                {
                    Lands_table.Columns[0].HeaderText = "№";
                    Lands_table.Columns[0].Width = 25;
                    Lands_table.Columns[1].HeaderText = "Тип";
                    Lands_table.Columns[2].HeaderText = "Город";
                    Lands_table.Columns[3].HeaderText = "Улица";
                    Lands_table.Columns[4].HeaderText = "Дом";
                    Lands_table.Columns[5].HeaderText = "Квартира";
                    Lands_table.Columns[6].HeaderText = "Площадь";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreatePropertyForm createPropertyForm = new CreatePropertyForm();
            createPropertyForm.Show();
            this.Hide();
        }



        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
            mainForm.ShowInTaskbar = true;
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            UpdateTable_Apartament();
            UpdateTable_House();
            UpdateTable_Lands();

            Apartament_table.ClearSelection();
            House_table.ClearSelection();
            Lands_table.ClearSelection();
        }

        private void Apartament_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prop = Convert.ToInt32(Apartament_table[0, e.RowIndex].Value);  
        }

        private void House_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prop = Convert.ToInt32(House_table[0, e.RowIndex].Value);  
        }

        private void Lands_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prop = Convert.ToInt32(Lands_table[0, e.RowIndex].Value);
 
        }

        private void Apartament_table_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            EditPropertyForm editPropertyForm = new EditPropertyForm(id_prop);
            editPropertyForm.Visible = true;
            editPropertyForm.ShowInTaskbar = true;
        }

        private void House_table_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            EditPropertyForm editPropertyForm = new EditPropertyForm(id_prop);
            editPropertyForm.Visible = true;
            editPropertyForm.ShowInTaskbar = true;
        }

        private void Lands_table_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            EditPropertyForm editPropertyForm = new EditPropertyForm(id_prop);
            editPropertyForm.Visible = true;
            editPropertyForm.ShowInTaskbar = true;
        }

        private void Apartament_table_Leave(object sender, EventArgs e)
        {
            Apartament_table.ClearSelection();
        }

        private void House_table_Leave(object sender, EventArgs e)
        {
            House_table.ClearSelection();
        }

        private void Lands_table_Leave(object sender, EventArgs e)
        {
            Lands_table.ClearSelection();
        }

        private void Lands_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Lands_table.ClearSelection();
        }

        private void House_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            House_table.ClearSelection();
        }

        private void Apartament_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Apartament_table.ClearSelection();
        }
        private void Apartament_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prop = Convert.ToInt32(Apartament_table[0, e.RowIndex].Value);
        }

        private void Lands_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prop = Convert.ToInt32(Lands_table[0, e.RowIndex].Value);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту недвижимость?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var properSup = db.supplies.FirstOrDefault(a => a.RealEstateId == id_prop);

                    if (properSup == null)
                    {
                        property proper = db.property.Where(p => p.Id == id_prop).FirstOrDefault();
                        db.property.Remove(proper);
                        db.SaveChanges();
                        UpdateTable_Apartament();
                        UpdateTable_House();
                        UpdateTable_Lands();

                        MessageBox.Show("Удаление прошло успешно!");

                    }
                    else
                    {
                        MessageBox.Show("Данная недвижимость не может быть удалена!");
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
