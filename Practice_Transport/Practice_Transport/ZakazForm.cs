using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Practice_Transport
{
    public partial class ZakazForm : Form
    {
        public string company; 
        public string Date; 
        public string price;
        public string size;
        public string weight;
        public string OtkudaKuda;
        public ZakazForm()
        {
            InitializeComponent();
        }

        private void ZakazForm_Load(object sender, EventArgs e)
        {
            CompanyLabel.Text = company;
            DateLabel.Text = Date;
            PriceLabel.Text = price;
            SizeLabel.Text = size;
            WeightLabel.Text = weight;
            OtkudaKudaLabel.Text = OtkudaKuda;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if ((FamiliaMaskedTextBox.Text == "") || (NameMaskedTextBox.Text == "")
               || (OtchestvoMaskedTextBox.Text == "") || (PhoneMaskedTextBox.Text == ""))
                MessageBox.Show("Введите все нужные данные");
            else if
                ((FamiliaMaskedTextBox.Text[0] == ' ') || (NameMaskedTextBox.Text[0] == ' ')
               || (OtchestvoMaskedTextBox.Text[0] == ' '))
                MessageBox.Show("Введите ФИО с начала поля");
            else if (PhoneMaskedTextBox.Text.Replace(" ", "").Length != 11)
                MessageBox.Show("Введите номер телефона полностью");
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source= .\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
                con.Open();
                string CommandString = String.Format("insert into MyTable([Компания],[Дата доставки],[Цена, руб],[Откуда - куда],[Фамилия],[Имя],[Отчество],[Телефон])" +
                    "values (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", company, Convert.ToDateTime(Date), price, OtkudaKuda,
                    FamiliaMaskedTextBox.Text, NameMaskedTextBox.Text, OtchestvoMaskedTextBox.Text, PhoneMaskedTextBox.Text);
                SqlCommand cmd = new SqlCommand(CommandString);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Заказ создан");
                this.Close();
            }
        }
    }

}
