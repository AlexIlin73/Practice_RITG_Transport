using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Transport
{
    public partial class ZakazListForm : Form
    {
        public ZakazListForm()
        {
            InitializeComponent();
        }

        private void ZakazListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDatabaseDataSet.MyTable". При необходимости она может быть перемещена или удалена.
            this.myTableTableAdapter.Fill(this.myDatabaseDataSet.MyTable);

        }

        private void myTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

        }

        private void SortIDButton_Click(object sender, EventArgs e)
        {
            myTableBindingSource.Sort = "[Номер заказа] ASC";
        }

        private void SortDateButton_Click(object sender, EventArgs e)
        {
            myTableBindingSource.Sort = "[Дата доставки] ASC";
        }

        private void SortCompanyButton_Click(object sender, EventArgs e)
        {
            myTableBindingSource.Sort = "Компания ASC";
        }
    }
}
