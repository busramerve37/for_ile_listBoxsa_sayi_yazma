using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._33
{
    public partial class txtBitis : Form
    {
        public txtBitis()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            Sayilar.Items.Clear();
            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(textBox2.Text);

            for (int i = baslangic; i < bitis; i++)
            {
                Sayilar.Items.Add(i);
            }
            
                
            

        }
    }
}
