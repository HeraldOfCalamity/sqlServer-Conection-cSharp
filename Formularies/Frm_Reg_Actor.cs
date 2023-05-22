using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Formularies
{
    public partial class Frm_Reg_Actor : Frm_Reg
    {

        public Frm_Reg_Actor()
        {
            InitializeComponent();
            cnx = new();
        }
        protected override void Registrar()
        {
            item = new Actor(txt_name.Text, txt_lastName.Text, Convert.ToChar(cmb_gender.SelectedItem), dtp_birth.Value);
            MessageBox.Show(cnx.insertar_actor((Actor)item));
        }
    }
}
