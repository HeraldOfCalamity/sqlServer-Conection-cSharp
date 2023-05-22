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
            nud_id = new NumericUpDown();
            label1 = new Label();
            btn_verify = new Button();
            txt_up_name = new TextBox();
            txt_up_last = new TextBox();
            dtp_up_birth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            grp_parameters.SuspendLayout();
            grp_up_fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_id).BeginInit();
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
            grp_up_fields.Controls.Add(label4);
            grp_up_fields.Controls.Add(label3);
            grp_up_fields.Controls.Add(label2);
            grp_up_fields.Controls.Add(dtp_up_birth);
            grp_up_fields.Controls.Add(txt_up_last);
            grp_up_fields.Controls.Add(txt_up_name);
            grp_up_fields.Controls.Add(btn_verify);
            grp_up_fields.Controls.Add(label1);
            grp_up_fields.Controls.Add(nud_id);
            grp_up_fields.Controls.SetChildIndex(btn_submit_update, 0);
            grp_up_fields.Controls.SetChildIndex(btn_cancel_update, 0);
            grp_up_fields.Controls.SetChildIndex(nud_id, 0);
            grp_up_fields.Controls.SetChildIndex(label1, 0);
            grp_up_fields.Controls.SetChildIndex(btn_verify, 0);
            grp_up_fields.Controls.SetChildIndex(txt_up_name, 0);
            grp_up_fields.Controls.SetChildIndex(txt_up_last, 0);
            grp_up_fields.Controls.SetChildIndex(dtp_up_birth, 0);
            grp_up_fields.Controls.SetChildIndex(label2, 0);
            grp_up_fields.Controls.SetChildIndex(label3, 0);
            grp_up_fields.Controls.SetChildIndex(label4, 0);
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
            // nud_id
            // 
            nud_id.Location = new Point(31, 61);
            nud_id.Name = "nud_id";
            nud_id.Size = new Size(42, 23);
            nud_id.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 3;
            label1.Text = "Id del actor a editar:";
            // 
            // btn_verify
            // 
            btn_verify.Location = new Point(98, 61);
            btn_verify.Name = "btn_verify";
            btn_verify.Size = new Size(75, 23);
            btn_verify.TabIndex = 4;
            btn_verify.Text = "Verificar";
            btn_verify.UseVisualStyleBackColor = true;
            btn_verify.Click += btn_verify_Click;
            // 
            // txt_up_name
            // 
            txt_up_name.BackColor = SystemColors.Window;
            txt_up_name.Enabled = false;
            txt_up_name.Location = new Point(50, 121);
            txt_up_name.Name = "txt_up_name";
            txt_up_name.Size = new Size(100, 23);
            txt_up_name.TabIndex = 5;
            // 
            // txt_up_last
            // 
            txt_up_last.BackColor = SystemColors.Window;
            txt_up_last.Enabled = false;
            txt_up_last.Location = new Point(50, 174);
            txt_up_last.Name = "txt_up_last";
            txt_up_last.Size = new Size(100, 23);
            txt_up_last.TabIndex = 6;
            // 
            // dtp_up_birth
            // 
            dtp_up_birth.Enabled = false;
            dtp_up_birth.Format = DateTimePickerFormat.Short;
            dtp_up_birth.Location = new Point(50, 233);
            dtp_up_birth.Name = "dtp_up_birth";
            dtp_up_birth.Size = new Size(81, 23);
            dtp_up_birth.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 156);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 215);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha de Nacimiento";
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
            grp_up_fields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_id).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chb_lst;
        private CheckBox chb_name;
        private TextBox txt_last;
        private TextBox txt_name;
        private ComboBox cmb_gender;
        private CheckBox chb_gender;
        private NumericUpDown nud_id;
        private Button btn_verify;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtp_up_birth;
        private TextBox txt_up_last;
        private TextBox txt_up_name;
    }
}