namespace Cinema.Formularies
{
    partial class Frm_Rep_Actor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_last = new TextBox();
            chb_name = new CheckBox();
            chb_lst = new CheckBox();
            chb_gender = new CheckBox();
            cmb_gender = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            grp_parameters.SuspendLayout();
            grp_up_fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // grp_parameters
            // 
            grp_parameters.Controls.Add(txt_name);
            grp_parameters.Controls.Add(chb_name);
            grp_parameters.Controls.Add(txt_last);
            grp_parameters.Controls.Add(chb_lst);
            grp_parameters.Controls.Add(cmb_gender);
            grp_parameters.Controls.Add(chb_gender);
            grp_parameters.Controls.SetChildIndex(chb_gender, 0);
            grp_parameters.Controls.SetChildIndex(cmb_gender, 0);
            grp_parameters.Controls.SetChildIndex(chb_lst, 0);
            grp_parameters.Controls.SetChildIndex(txt_last, 0);
            grp_parameters.Controls.SetChildIndex(chb_name, 0);
            grp_parameters.Controls.SetChildIndex(txt_name, 0);
            grp_parameters.Controls.SetChildIndex(btn_update, 0);
            grp_parameters.Controls.SetChildIndex(btn_submit, 0);
            // 
            // grp_up_fields
            // 
            grp_up_fields.Controls.Add(numericUpDown1);
            grp_up_fields.Controls.SetChildIndex(btn_submit_update, 0);
            grp_up_fields.Controls.SetChildIndex(btn_cancel_update, 0);
            grp_up_fields.Controls.SetChildIndex(numericUpDown1, 0);
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Window;
            txt_name.Location = new Point(116, 37);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 3;
            // 
            // txt_last
            // 
            txt_last.Location = new Point(116, 80);
            txt_last.Name = "txt_last";
            txt_last.Size = new Size(100, 23);
            txt_last.TabIndex = 4;
            // 
            // chb_name
            // 
            chb_name.AutoSize = true;
            chb_name.Location = new Point(18, 37);
            chb_name.Name = "chb_name";
            chb_name.Size = new Size(92, 19);
            chb_name.TabIndex = 5;
            chb_name.Text = "por nombre:";
            chb_name.UseVisualStyleBackColor = true;
            chb_name.CheckedChanged += chb_name_CheckedChanged;
            // 
            // chb_lst
            // 
            chb_lst.AutoSize = true;
            chb_lst.Location = new Point(18, 84);
            chb_lst.Name = "chb_lst";
            chb_lst.Size = new Size(92, 19);
            chb_lst.TabIndex = 6;
            chb_lst.Text = "por apellido:";
            chb_lst.UseVisualStyleBackColor = true;
            chb_lst.CheckedChanged += chb_lst_CheckedChanged;
            // 
            // chb_gender
            // 
            chb_gender.AutoSize = true;
            chb_gender.Location = new Point(264, 37);
            chb_gender.Name = "chb_gender";
            chb_gender.Size = new Size(87, 19);
            chb_gender.TabIndex = 7;
            chb_gender.Text = "por genero:";
            chb_gender.UseVisualStyleBackColor = true;
            chb_gender.CheckedChanged += chb_gender_CheckedChanged;
            // 
            // cmb_gender
            // 
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "F", "M" });
            cmb_gender.Location = new Point(264, 62);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(78, 23);
            cmb_gender.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(20, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // Frm_Rep_Actor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(767, 377);
            Name = "Frm_Rep_Actor";
            groupBox1.ResumeLayout(false);
            grp_parameters.ResumeLayout(false);
            grp_parameters.PerformLayout();
            grp_up_fields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chb_lst;
        private CheckBox chb_name;
        private TextBox txt_last;
        private TextBox txt_name;
        private ComboBox cmb_gender;
        private CheckBox chb_gender;
        private NumericUpDown numericUpDown1;
    }
}