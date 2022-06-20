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
    public partial class CreateClientForm : Form
    {
        EsoftEntities db = new EsoftEntities();

        public CreateClientForm()
        {
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (Phone_txt.Text == "" && Email_txt.Text == "")
            {
                MessageBox.Show("Введите номер телефона или почту!");
                return;
            }
            try
            {
               clients  client = new clients 
               { 
                   FirstName = Convert.ToString(FirstName_txt.Text),
                   MiddleName = Convert.ToString(MiddleName_txt.Text),
                   LastName = Convert.ToString(LastName_txt.Text),
                   Phone = Convert.ToString(Phone_txt.Text),
                   Email = Convert.ToString(Email_txt.Text)
               };

                db.clients.Add(client);
                db.SaveChanges();
                ClientForm clientInfo = new ClientForm();
                clientInfo.Show();
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
            ClientForm clientInfo = new ClientForm();
            clientInfo.Show();
            this.Hide();
        }
    }
}
