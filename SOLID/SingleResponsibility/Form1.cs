using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        /*
         * Bir nesnenin sadece bir sorumluluğu olmalı!
         * Bir class içinde değişiklik yapmak için birden fazla sebebiniz varsa, bu prensibe uymuyorsunuz demektir.
         * 
         * Bir nesnenin isminden sorumluluğunu anlamaya çalışın.
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var affectedRows = new ProductBusiness().AddProduct(name, price);
            var message = affectedRows > 0 ? "Ürün başarıyla eklendi." : "Ürün eklenemedi.";
            MessageBox.Show(message);
        }


    }
}