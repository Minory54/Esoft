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
    public partial class EditClientForm : Form
    {
        EsoftEntities db = new EsoftEntities();
        int ID;
        clients client;

        public EditClientForm(int id_client)
        {
            InitializeComponent();
            ID = id_client;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ClientForm clientInfo = new ClientForm();
            clientInfo.Show();
            this.Hide();
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            client = db.clients.Where(i => i.Id == ID).FirstOrDefault();

            FirstName_txt.Text = client.FirstName;
            MiddleName_txt.Text = client.MiddleName;
            LastName_txt.Text = client.LastName;
            Phone_txt.Text = client.Phone;
            Email_txt.Text = client.Email;

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Phone_txt.Text == "" && Email_txt.Text == "")
            {
                MessageBox.Show("Введите номер телефона или почту!");
                return;
            }
            try
            {
                clients client = db.clients.Where(i => i.Id == ID).FirstOrDefault();

                client.FirstName = FirstName_txt.Text;
                client.MiddleName = MiddleName_txt.Text;
                client.LastName = LastName_txt.Text;
                client.Phone = Phone_txt.Text;
                client.Email = Email_txt.Text;

                db.SaveChanges();
                this.Close();

                MessageBox.Show("Изменение прошло успешно!");
                ClientForm clientInfo = new ClientForm();
                clientInfo.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
