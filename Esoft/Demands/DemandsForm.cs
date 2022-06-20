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
    public partial class DemandsForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int id;

        public DemandsForm()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
            mainForm.ShowInTaskbar = true;
        }

        public void UpdateTable_Apartament()
        {
            try
            {
                var demands = from dem in db.demands
                              join tdem in db.typeProperty on dem.TypeId equals tdem.Id
                              join cli in db.clients on dem.ClientId equals cli.Id
                              join agen in db.agents on dem.AgentId equals agen.Id
                              where dem.TypeId == 1
                              select new
                              {
                                  Id = dem.Id,
                                  Client = cli.FirstName,
                                  Agent = agen.FirstName,
                                  TypeDemands = tdem.name,
                                  Address_City = dem.Address_City,
                                  Address_Street = dem.Address_Street,
                                  Address_House = dem.Address_House,
                                  Address_Number = dem.Address_Number,
                                  MinPrice = dem.MinPrice,
                                  MaxPrice = dem.MaxPrice,
                                  MinArea = dem.MinArea,
                                  MaxArea = dem.MaxArea,
                                  MinRoom = dem.MinRooms,
                                  MaxRoom = dem.MaxRooms,
                                  MinFloor = dem.MinFloor,
                                  MaxFloor = dem.MaxFloor

                              };

                Apartament_table.DataSource = demands.ToList();

                if (Apartament_table.Rows.Count > 0)
                {
                    Apartament_table.Columns[0].HeaderText = "№";
                    Apartament_table.Columns[0].Width = 25;
                    Apartament_table.Columns[1].HeaderText = "Клиент";
                    Apartament_table.Columns[2].HeaderText = "Риэлтор";
                    Apartament_table.Columns[3].HeaderText = "Улица";
                    Apartament_table.Columns[4].HeaderText = "Тип";
                    Apartament_table.Columns[5].HeaderText = "Город";
                    Apartament_table.Columns[6].HeaderText = "Дом";
                    Apartament_table.Columns[7].HeaderText = "Квартира";
                    Apartament_table.Columns[8].HeaderText = "Мин. цена";
                    Apartament_table.Columns[9].HeaderText = "Макс. цена";
                    Apartament_table.Columns[10].HeaderText = "Мин. площадь";
                    Apartament_table.Columns[11].HeaderText = "Макс. площадь";
                    Apartament_table.Columns[12].HeaderText = "Мин. комнат";
                    Apartament_table.Columns[13].HeaderText = "Макс. комнат";
                    Apartament_table.Columns[14].HeaderText = "Мин. этажей";
                    Apartament_table.Columns[15].HeaderText = "Макс. этажей";

                    id = Convert.ToInt32(Apartament_table[0, 0].Value);

                }
                else
                {
                    Apartament_table.Columns[0].HeaderText = "№";
                    Apartament_table.Columns[0].Width = 25;
                    Apartament_table.Columns[1].HeaderText = "Клиент";
                    Apartament_table.Columns[2].HeaderText = "Риэлтор";
                    Apartament_table.Columns[3].HeaderText = "Улица";
                    Apartament_table.Columns[4].HeaderText = "Тип";
                    Apartament_table.Columns[5].HeaderText = "Город";
                    Apartament_table.Columns[6].HeaderText = "Дом";
                    Apartament_table.Columns[7].HeaderText = "Квартира";
                    Apartament_table.Columns[8].HeaderText = "Мин. цена";
                    Apartament_table.Columns[9].HeaderText = "Макс. цена";
                    Apartament_table.Columns[10].HeaderText = "Мин. площадь";
                    Apartament_table.Columns[11].HeaderText = "Макс. площадь";
                    Apartament_table.Columns[12].HeaderText = "Мин. комнат";
                    Apartament_table.Columns[13].HeaderText = "Макс. комнат";
                    Apartament_table.Columns[14].HeaderText = "Мин. этажей";
                    Apartament_table.Columns[15].HeaderText = "Макс. этажей";
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
                var demands = from dem in db.demands
                              join tdem in db.typeProperty on dem.TypeId equals tdem.Id
                              join cli in db.clients on dem.ClientId equals cli.Id
                              join agen in db.agents on dem.AgentId equals agen.Id
                              where dem.TypeId == 2
                              select new
                              {
                                  Id = dem.Id,
                                  Client = cli.FirstName,
                                  Agent = agen.FirstName,
                                  TypeDemands = tdem.name,
                                  Address_City = dem.Address_City,
                                  Address_Street = dem.Address_Street,
                                  Address_House = dem.Address_House,
                                  Address_Number = dem.Address_Number,
                                  MinPrice = dem.MinPrice,
                                  MaxPrice = dem.MaxPrice,
                                  MinArea = dem.MinArea,
                                  MaxArea = dem.MaxArea,
                                  MinRoom = dem.MinRooms,
                                  MaxRoom = dem.MaxRooms,
                                  MinFloor = dem.MinFloor,
                                  MaxFloor = dem.MaxFloor

                              };

                House_table.DataSource = demands.ToList();

                if (House_table.Rows.Count > 0)
                {
                    House_table.Columns[0].HeaderText = "№";
                    House_table.Columns[0].Width = 25;
                    House_table.Columns[1].HeaderText = "Клиент";
                    House_table.Columns[2].HeaderText = "Риэлтор";
                    House_table.Columns[3].HeaderText = "Улица";
                    House_table.Columns[4].HeaderText = "Тип";
                    House_table.Columns[5].HeaderText = "Город";
                    House_table.Columns[6].HeaderText = "Дом";
                    House_table.Columns[7].HeaderText = "Квартира";
                    House_table.Columns[8].HeaderText = "Мин. цена";
                    House_table.Columns[9].HeaderText = "Макс. цена";
                    House_table.Columns[10].HeaderText = "Мин. площадь";
                    House_table.Columns[11].HeaderText = "Макс. площадь";
                    House_table.Columns[12].HeaderText = "Мин. комнат";
                    House_table.Columns[13].HeaderText = "Макс. комнат";
                    House_table.Columns[14].HeaderText = "Мин. этажей";
                    House_table.Columns[15].HeaderText = "Макс. этажей";

                    id = Convert.ToInt32(House_table[0, 0].Value);

                }
                else
                {
                    House_table.Columns[0].HeaderText = "№";
                    House_table.Columns[0].Width = 25;
                    House_table.Columns[1].HeaderText = "Клиент";
                    House_table.Columns[2].HeaderText = "Риэлтор";
                    House_table.Columns[3].HeaderText = "Улица";
                    House_table.Columns[4].HeaderText = "Тип";
                    House_table.Columns[5].HeaderText = "Город";
                    House_table.Columns[6].HeaderText = "Дом";
                    House_table.Columns[7].HeaderText = "Квартира";
                    House_table.Columns[8].HeaderText = "Мин. цена";
                    House_table.Columns[9].HeaderText = "Макс. цена";
                    House_table.Columns[10].HeaderText = "Мин. площадь";
                    House_table.Columns[11].HeaderText = "Макс. площадь";
                    House_table.Columns[12].HeaderText = "Мин. комнат";
                    House_table.Columns[13].HeaderText = "Макс. комнат";
                    House_table.Columns[14].HeaderText = "Мин. этажей";
                    House_table.Columns[15].HeaderText = "Макс. этажей";
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
                var demands = from dem in db.demands
                              join tdem in db.typeProperty on dem.TypeId equals tdem.Id
                              join cli in db.clients on dem.ClientId equals cli.Id
                              join agen in db.agents on dem.AgentId equals agen.Id
                              where dem.TypeId == 3
                              select new
                              {
                                  Id = dem.Id,
                                  Client = cli.FirstName,
                                  Agent = agen.FirstName,
                                  TypeDemands = tdem.name,
                                  Address_City = dem.Address_City,
                                  Address_Street = dem.Address_Street,
                                  Address_House = dem.Address_House,
                                  Address_Number = dem.Address_Number,
                                  MinPrice = dem.MinPrice,
                                  MaxPrice = dem.MaxPrice,
                                  MinArea = dem.MinArea,
                                  MaxArea = dem.MaxArea,

                              };

                Lands_table.DataSource = demands.ToList();

                if (Lands_table.Rows.Count > 0)
                {
                    Lands_table.Columns[0].HeaderText = "№";
                    Lands_table.Columns[0].Width = 25;
                    Lands_table.Columns[1].HeaderText = "Клиент";
                    Lands_table.Columns[2].HeaderText = "Риэлтор";
                    Lands_table.Columns[3].HeaderText = "Улица";
                    Lands_table.Columns[4].HeaderText = "Тип";
                    Lands_table.Columns[5].HeaderText = "Город";
                    Lands_table.Columns[6].HeaderText = "Дом";
                    Lands_table.Columns[7].HeaderText = "Квартира";
                    Lands_table.Columns[8].HeaderText = "Мин. цена";
                    Lands_table.Columns[9].HeaderText = "Макс. цена";
                    Lands_table.Columns[10].HeaderText = "Мин. площадь";
                    Lands_table.Columns[11].HeaderText = "Макс. площадь";

                    id = Convert.ToInt32(Lands_table[0, 0].Value);

                }
                else
                {
                    Lands_table.Columns[0].HeaderText = "№";
                    Lands_table.Columns[0].Width = 25;
                    Lands_table.Columns[1].HeaderText = "Клиент";
                    Lands_table.Columns[2].HeaderText = "Риэлтор";
                    Lands_table.Columns[3].HeaderText = "Улица";
                    Lands_table.Columns[4].HeaderText = "Тип";
                    Lands_table.Columns[5].HeaderText = "Город";
                    Lands_table.Columns[6].HeaderText = "Дом";
                    Lands_table.Columns[7].HeaderText = "Квартира";
                    Lands_table.Columns[8].HeaderText = "Мин. цена";
                    Lands_table.Columns[9].HeaderText = "Макс. цена";
                    Lands_table.Columns[10].HeaderText = "Мин. площадь";
                    Lands_table.Columns[11].HeaderText = "Макс. площадь";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DemandsForm_Load(object sender, EventArgs e)
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
            id = Convert.ToInt32(Apartament_table[0, e.RowIndex].Value);
        }

        private void House_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(House_table[0, e.RowIndex].Value);
        }

        private void Lands_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(Lands_table[0, e.RowIndex].Value);
        }

        private void Apartament_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            EditDemandsForm editDemandsForm = new EditDemandsForm(id);
            editDemandsForm.Visible = true;
            editDemandsForm.ShowInTaskbar = true;
        }

        private void House_table_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
            EditDemandsForm editDemandsForm = new EditDemandsForm(id);
            editDemandsForm.Visible = true;
            editDemandsForm.ShowInTaskbar = true;
        }

        private void Lands_table_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
            EditDemandsForm editDemandsForm = new EditDemandsForm(id);
            editDemandsForm.Visible = true;
            editDemandsForm.ShowInTaskbar = true;
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот запрос?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
 
                    demands demand = db.demands.Where(p => p.Id == id).FirstOrDefault();
                    db.demands.Remove(demand);
                    db.SaveChanges();
                    UpdateTable_Apartament();
                    UpdateTable_House();
                    UpdateTable_Lands();

                    MessageBox.Show("Удаление прошло успешно!");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            CreateDemandsForm createPropertyForm = new CreateDemandsForm();
            createPropertyForm.Show();
            this.Hide();
        }

        private void Apartament_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Apartament_table.ClearSelection();
        }

        private void House_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            House_table.ClearSelection();
        }

        private void Lands_table_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Lands_table.ClearSelection();
        }

        private void Apartament_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(Apartament_table[0, e.RowIndex].Value);
        }

        private void House_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(House_table[0, e.RowIndex].Value);
        }

        private void Lands_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(Lands_table[0, e.RowIndex].Value);

        }
    }
}
