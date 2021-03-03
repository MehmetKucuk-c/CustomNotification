using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msg,Bildirimcs.enmType type)
        {
            Bildirimcs bildirimcs = new Bildirimcs();
            bildirimcs.ShowAlert(msg,type);
        }
        private void button1_Click(object sender, EventArgs e)
        {



            if(textBox2.Text==string.Empty && textBox1.Text == string.Empty)
            {
                this.Alert("Boş Alanları Doldurunuz", Bildirimcs.enmType.Warning);
            }
            else
            {
                if(textBox1.Text==textBox2.Text)
                {
                    this.Alert("Kayıt Başarılı", Bildirimcs.enmType.Success);
                }
                else
                {
                    this.Alert("Aktivasyon Kodu Aynı Değil", Bildirimcs.enmType.Error);
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
