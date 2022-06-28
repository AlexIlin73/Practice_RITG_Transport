using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;


namespace Practice_Transport
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((OtkudaComboBox.Text == "") || (KudaComboBox.Text == "") || (LengthTextBox.Text == "")
               || (WidthTextBox.Text == "") || (HeightTextBox.Text == "") || (WeightTextBox.Text == ""))
            {
                MessageBox.Show("Введите все нужные данные");
            }
            else
            {
                try
                {
                    if ((Convert.ToSingle(LengthTextBox.Text) <= 0) || (Convert.ToSingle(WidthTextBox.Text) <= 0)
                        || (Convert.ToSingle(HeightTextBox.Text) <= 0) || (Convert.ToSingle(WeightTextBox.Text) <= 0))
                        throw new Exception("Параметры товара не могут быть равны нулю или меньше его");
                    BoxberryDateLabel.Text = Convert.ToString(Boxberry.Date(OtkudaComboBox.Text)).Substring(0,10);
                    DPDDateLabel.Text = Convert.ToString(DPD.Date(OtkudaComboBox.Text)).Substring(0, 10);
                    SDEKDateLabel.Text = Convert.ToString(SDEK.Date(OtkudaComboBox.Text)).Substring(0, 10);

                    BoxberryPriceLabel.Text = Convert.ToString(Boxberry.Price(OtkudaComboBox.Text, FromDoorCheckBox.Checked, ToDoorCheckBox.Checked,
                    Convert.ToSingle(LengthTextBox.Text), Convert.ToSingle(WidthTextBox.Text), Convert.ToSingle(HeightTextBox.Text),
                    Convert.ToSingle(WeightTextBox.Text)));

                    DPDPriceLabel.Text = Convert.ToString(DPD.Price(OtkudaComboBox.Text, FromDoorCheckBox.Checked, ToDoorCheckBox.Checked,
                    Convert.ToSingle(LengthTextBox.Text), Convert.ToSingle(WidthTextBox.Text), Convert.ToSingle(HeightTextBox.Text),
                    Convert.ToSingle(WeightTextBox.Text)));

                    SDEKPriceLabel.Text = Convert.ToString(SDEK.Price(OtkudaComboBox.Text, FromDoorCheckBox.Checked, ToDoorCheckBox.Checked,
                    Convert.ToSingle(LengthTextBox.Text), Convert.ToSingle(WidthTextBox.Text), Convert.ToSingle(HeightTextBox.Text),
                    Convert.ToSingle(WeightTextBox.Text)));

                    BoxberryDateLabel.Visible = true;
                    DPDDateLabel.Visible = true;
                    SDEKDateLabel.Visible = true;
                    BoxberryPriceLabel.Visible = true;
                    DPDPriceLabel.Visible = true;
                    SDEKPriceLabel.Visible = true;
                    BoxberryZakazButton.Visible = true;
                    DPDZakazButton.Visible = true;
                    SDEKZakazButton.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Некорректные данные. Проверьте введённые вами данные и исправьте.");
                }
            }
        }

        private void BoxberryZakazButton_Click(object sender, EventArgs e)
        {
            ZakazForm zakazForm = new ZakazForm();
            zakazForm.company = "Boxberry";
            zakazForm.Date = BoxberryDateLabel.Text;
            zakazForm.price = BoxberryPriceLabel.Text;
            zakazForm.size = LengthTextBox.Text+"*"+WidthTextBox.Text +"*"+ HeightTextBox.Text;
            zakazForm.weight = WeightTextBox.Text;
            zakazForm.OtkudaKuda = OtkudaComboBox.Text+" - "+KudaComboBox.Text;
            if (FromDoorCheckBox.Checked && ToDoorCheckBox.Checked)
                zakazForm.OtkudaKuda += ", от двери и до двери";
            else
            if (FromDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", от двери";
            else
            if (ToDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", до двери";
            zakazForm.ShowDialog();
            
        }

        private void DPDZakazButton_Click(object sender, EventArgs e)
        {
            ZakazForm zakazForm = new ZakazForm();
            zakazForm.company = "DPD";
            zakazForm.Date = DPDDateLabel.Text;
            zakazForm.price = DPDPriceLabel.Text;
            zakazForm.size = LengthTextBox.Text + "*" + WidthTextBox.Text + "*" + HeightTextBox.Text;
            zakazForm.weight = WeightTextBox.Text;
            zakazForm.OtkudaKuda = OtkudaComboBox.Text + " - " + KudaComboBox.Text;
            if (FromDoorCheckBox.Checked && ToDoorCheckBox.Checked)
                zakazForm.OtkudaKuda += ", от двери и до двери";
            else
            if (FromDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", от двери";
            else
            if (ToDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", до двери";
            zakazForm.ShowDialog();
        }

        private void SDEKZakazButton_Click(object sender, EventArgs e)
        {
            ZakazForm zakazForm = new ZakazForm();
            zakazForm.company = "СДЭК";
            zakazForm.Date = SDEKDateLabel.Text;
            zakazForm.price = SDEKPriceLabel.Text;
            zakazForm.size = LengthTextBox.Text + "*" + WidthTextBox.Text + "*" + HeightTextBox.Text;
            zakazForm.weight = WeightTextBox.Text;
            zakazForm.OtkudaKuda = OtkudaComboBox.Text + " - " + KudaComboBox.Text;
            if (FromDoorCheckBox.Checked && ToDoorCheckBox.Checked)
                zakazForm.OtkudaKuda += ", от двери и до двери";
            else
            if (FromDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", от двери";
            else
            if (ToDoorCheckBox.Checked) zakazForm.OtkudaKuda += ", до двери";
            zakazForm.ShowDialog();
        }

        private void ZakazListButton_Click(object sender, EventArgs e)
        {
            ZakazListForm zakazListForm = new ZakazListForm();
            zakazListForm.ShowDialog();
        }
    }
}
