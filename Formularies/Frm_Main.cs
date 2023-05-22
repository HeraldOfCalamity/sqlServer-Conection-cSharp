using Cinema.Formularies;

namespace Cinema
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reg_Actor frm_Reg_Actor = new();
            frm_Reg_Actor.MdiParent = this;
            frm_Reg_Actor.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rep_Actor frm_rep_actor = new();
            frm_rep_actor.MdiParent = this;
            frm_rep_actor.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}