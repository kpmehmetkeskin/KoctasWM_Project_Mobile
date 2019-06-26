using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasWM_Project
{
    public partial class KoliNoPopUp : Form
    {
        public KoliNoPopUp()
        {
            InitializeComponent();
            // Eklendi
        }

        private void checkListYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                WM_KOLI.ZKtWmKoliDetay srv = new KoctasWM_Project.WM_KOLI.ZKtWmKoliDetay();
                srv.IvKoliNo = koliNoText.Text.ToString();
                WM_KOLI.ZKtWmKoliDetayResponse resp = new KoctasWM_Project.WM_KOLI.ZKtWmKoliDetayResponse();
                if(resp.EsResponse.Length>0){
                    MessageBox.Show(resp.EsResponse[0].Message);
                    return;
                }else{
                    MessageBox.Show("İşlem Tamalanmıştır");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return;
            }
        }

    }
}