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
    public partial class frm_20_v2_Dagitim_Musteri_Sevkiyatlari_Ambalajlama_ve_Ipt_Dty_Ft_D : Form
    {
        public frm_20_v2_Dagitim_Musteri_Sevkiyatlari_Ambalajlama_ve_Ipt_Dty_Ft_D()
        {
            InitializeComponent();
        }

        public string _faturaNo;
        public string _belgeNo;
        public string _koliNo;
        public string _atfNo;
        public bool _atfKontrol;
        public WS_Kontrol.ZktWmStAtfHeader _atfInfo;

        private void frm_20_Dagitim_Musteri_Sevkiyatlari_Ambalajlama_ve_Iptali_Detay_FaturaDogrula_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            Utility.loginInfo(lbl_LoginInfo);
            _atfKontrol = false;
            


        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            if (!_atfKontrol)
            {
                MessageBox.Show("İşlemi tamamlamak için öncelikle ATF No almanız gerekmektedir.", "HATA");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

            /*
            try
            {
                //ZKT_WM_WS_AMBALAJLAMA_ESLEME
                Cursor.Current = Cursors.WaitCursor;
                WS_Islem.ZKT_WM_WS_ISLEMService srv = new KoctasWM_Project.WS_Islem.ZKT_WM_WS_ISLEMService();
                WS_Islem.ZKtWmWsAmbalajlamaEsleme chk = new KoctasWM_Project.WS_Islem.ZKtWmWsAmbalajlamaEsleme();
                WS_Islem.ZKtWmWsAmbalajlamaEslemeResponse resp = new KoctasWM_Project.WS_Islem.ZKtWmWsAmbalajlamaEslemeResponse();

                chk.IvVbelnVf = _faturaNo;
                chk.IvVbelnVl = _belgeNo;

                srv.Credentials = GlobalData.globalCr;
                srv.Url = Utility.getWsUrlForWM("zkt_wm_ws_islem");
                resp = srv.ZKtWmWsAmbalajlamaEsleme(chk);

                Cursor.Current = Cursors.Default;
                if (resp.EsResponse.Length > 0)
                {
                    //Mesajlar düzenleniyor
                    GlobalData.rMsg = new KoctasWM_Project.WS_Islem.ZktWmReturn[resp.EsResponse.Length];
                    GlobalData.rMsg = Utility.mesajDuzenle(resp.EsResponse);

                    if (GlobalData.rMsg[0].Msgty.ToString().ToUpper() == "E")
                    {
                        MessageBox.Show(GlobalData.rMsg[0].Message.ToString(), "HATA");
                    }
                    else if ((GlobalData.rMsg[0].Msgty.ToString().ToUpper() == "S") || (GlobalData.rMsg[0].Msgty.ToString().ToUpper() == "W") || (GlobalData.rMsg[0].Msgty.ToString().ToUpper() == "I"))
                    {
                        MessageBox.Show(GlobalData.rMsg[0].Message.ToString(), "BİLGİ");
                        Utility.moreMsgCheck(GlobalData.rMsg);

                        this.DialogResult = DialogResult.OK;
                        this.Close();

          
                    }
                    else
                    {
                        MessageBox.Show(GlobalData.rMsg[0].Message.ToString(), "BİLİNMEYEN DURUM");
                    }
                }
                else
                {
                    MessageBox.Show("EsResponse dönüş değeri hatalı", "HATA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }*/
        }

        private void txtOkutulanFaturaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Kaydet_Click(new object(), new EventArgs());
            }
        }

        private void btn_AtfAl_Click(object sender, EventArgs e)
        {

            frm_Waiting frm = new frm_Waiting();
            frm._koliNo = _koliNo;
            frm._kontrolEttim = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm._atfKontrol == true)
                {
                    _atfKontrol = true;
                    txtAtfNo.Text = "ATF Alındı";
                }
                else
                {
                    _atfKontrol = false;
                    txtAtfNo.Text = "";
                }
                
            }

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ATF No almadan kargoya teslim edemezsiniz.", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frm_20_v2_Dagitim_Musteri_Sevkiyatlari_Ambalajlama_ve_Ipt_Dty_Ft_D_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            Utility.loginInfo(lbl_LoginInfo);
            _atfKontrol = false;
        }



    }
}