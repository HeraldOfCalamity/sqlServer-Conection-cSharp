using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Classes;

namespace Cinema.Formularies
{
    public partial class Frm_Rep : Form
    {
        protected Connection? cnx;
        public Frm_Rep()
        {
            InitializeComponent();
        }
        protected virtual string Query()
        {
            throw new NotImplementedException("GetQuery no implementado");
        }
        protected virtual void Mostrar(string query)
        {
            throw new NotImplementedException("Mostrar no implementado");
        }
        protected virtual void Mostrar()
        {
            throw new NotImplementedException("MostrarTodo no implementado");
        }
        protected virtual void Actualizar(int id)
        {
            throw new NotImplementedException("actualizar no implementado");
        }
        protected virtual int GetId()
        {
            throw new NotImplementedException("GetId no implementado");
        }
        protected virtual string getInvalidFields()
        {
            throw new NotImplementedException("getInvalidFields no implementado");
        }
        protected void Frm_Rep_Load(object sender, EventArgs e)
        {
            try
            {
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void btn__back_Click(object sender, EventArgs e)
        {
            grp_parameters.Enabled = false;
            grp_parameters.Visible = false;
            grp_up_fields.Enabled = false;
            grp_up_fields.Visible = false;

            try
            {
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {

            grp_up_fields.Enabled = true;
            grp_up_fields.Visible = true;
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            grp_parameters.Enabled = true;
            grp_parameters.Visible = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string error = getInvalidFields();
            if(error != "")
            {
                MessageBox.Show(error, "There are invalid fields");
                return;
            }

            try
            {
                Mostrar(Query());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_submit_update_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar(GetId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_update_Click(object sender, EventArgs e)
        {
            grp_up_fields.Enabled = false;
            grp_up_fields.Visible = false;
        }
    }
}
