using System;
using System.Windows.Forms;
using Task1_Singleton_Proxy.Proxy;

namespace Task1_Singleton_Proxy
{
    public partial class Form1 : Form
    {
        Secretary secretary;
        public Form1()
        {
            InitializeComponent();
            secretary = new Secretary("Secretary", "Chief", 10000m);
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                double percent = Convert.ToDouble(textBoxAwardPercentage.Text);
                secretary.AddToRewardOrder(textBoxEmployeeSurname.Text, percent);
                textBoxEmployeeSurname.Text = "";
                textBoxEmployeeSurname.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid award percentage");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid award percentage");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBoxAwardPercentage.Text = "";
            }
        }

        private void buttonPrintOrder_Click(object sender, EventArgs e)
        {
            listBoxOrder.Items.AddRange(secretary.CreatRewardOrder().ToArray());
        }
    }
}
