using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Formularies
{
    public partial class Frm_Rep_Actor : Frm_Rep
    {
        public Frm_Rep_Actor()
        {
            InitializeComponent();
            cnx = new();
        }
        protected override void Mostrar()
        {
            dataGridView1.DataSource = cnx.mostrar_actor();
        }
        protected override string Query()
        {
            string query = "select * from Actor";
            bool hasPrevious = false;


            if (chb_name.Checked)
            {
                if (!hasPrevious)
                {
                    query += " where ";
                    hasPrevious = true;
                }
                else
                {
                    query += " and ";
                }
                query += "nombre_actor = '" + txt_name.Text + "'";
            }


            if (chb_lst.Checked)
            {
                if (!hasPrevious)
                {
                    query += " where ";
                    hasPrevious = true;
                }
                else
                {
                    query += " and ";
                }
                query += "apellido_actor = '" + txt_last.Text + "'";
            }

            if (chb_gender.Checked)
            {
                if (!hasPrevious)
                {
                    query += " where ";
                    hasPrevious = true;
                }
                else
                {
                    query += " and ";
                }
                query += "genero_actor = '" + Convert.ToChar(cmb_gender.SelectedItem) + "'";
            }

            return query;
        }
        protected override void Mostrar(string query)
        {
            dataGridView1.DataSource = cnx.QuerySearch(query);
        }
        protected override string getInvalidFields()
        {
            string error = "";
            if (chb_name.Checked && txt_name.Text.Trim().Length < 3)
                error += "\n Invalid Name";
            if (chb_lst.Checked && txt_last.Text.Trim().Length < 3)
                error += "\n Invalid Last Name";
            if (chb_gender.Checked && (Convert.ToChar(cmb_gender.SelectedItem) != 'F' && Convert.ToChar(cmb_gender.SelectedItem) != 'M'))
                error += "\n Invalid Gender";
            return error;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Query());
            //try
            //{
            //    Mostrar(Query());
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void chb_lst_CheckedChanged(object sender, EventArgs e)
        {
            txt_last.Enabled = chb_lst.Checked;
            if (!txt_last.Enabled) txt_last.Clear();
        }

        private void chb_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_name.Enabled = chb_name.Checked;
            if (!txt_name.Enabled) txt_name.Clear();
        }

        private void chb_gender_CheckedChanged(object sender, EventArgs e)
        {
            cmb_gender.Enabled = chb_gender.Checked;
            if (!cmb_gender.Enabled) cmb_gender.Text = "";
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = cnx.buscar_actor(Convert.ToInt32(nud_id.Value));
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Actor con codigo " + nud_id.Value + " no encontrado");
                    return;
                }

                txt_up_name.Text = table.Rows[0].ItemArray[1].ToString();
                txt_up_last.Text = table.Rows[0].ItemArray[2].ToString();
                dtp_up_birth.Value = Convert.ToDateTime(table.Rows[0].ItemArray[4]);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
