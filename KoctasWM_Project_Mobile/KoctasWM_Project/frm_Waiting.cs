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
    public partial class frm_Waiting : Form
    {
        public frm_Waiting()
        {
            InitializeComponent();
        }

        public string _koliNo;
        public bool _atfKontrol = false;
        public bool _kontrolEttim = false;

        
        private void frm_Waiting_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Waiting_GotFocus(object sender, EventArgs e)
        {
            
            if (_kontrolEttim == false)
            {
                _kontrolEttim = true;
                try
                {
                    if (Utility.atfGenel(_koliNo) == true)
                    {
                        _atfKontrol = true;
                    }
                    else
                    {
                        _atfKontrol = false;
                    }
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ATF numarası alınırken hata oluştu: " + ex.Message, "HATA");
                    _atfKontrol = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}