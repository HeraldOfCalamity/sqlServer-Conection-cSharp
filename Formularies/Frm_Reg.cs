using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Formularies
{
    public partial class Frm_Reg : Form
    {
        protected Connection cnx;
        protected object item;
        public Frm_Reg()
        {
            InitializeComponent();
            cnx = new();
        }
        protected virtual void Registrar()
        {
            throw new NotImplementedException("Registrar no implementado");
        }
        protected void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            try
            {
                Registrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
