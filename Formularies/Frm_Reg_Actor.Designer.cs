namespace Cinema.Formularies
{
    partial class Frm_Reg_Actor
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
            label1 = new Label();
            txt_lastName = new TextBox();
            cmb_gender = new ComboBox();
            txt_name = new TextBox();
            dtp_birth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtp_birth);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_lastName);
            groupBox1.Controls.Add(cmb_gender);
            groupBox1.Controls.SetChildIndex(cmb_gender, 0);
            groupBox1.Controls.SetChildIndex(txt_lastName, 0);
            groupBox1.Controls.SetChildIndex(txt_name, 0);
            groupBox1.Controls.SetChildIndex(label1, 0);
            groupBox1.Controls.SetChildIndex(dtp_birth, 0);
            groupBox1.Controls.SetChildIndex(btn_register, 0);
            groupBox1.Controls.SetChildIndex(label2, 0);
            groupBox1.Controls.SetChildIndex(button1, 0);
            groupBox1.Controls.SetChildIndex(label3, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 64);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Last Name:";
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(165, 61);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(100, 23);
            txt_lastName.TabIndex = 5;
            // 
            // cmb_gender
            // 
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "M", "F" });
            cmb_gender.Location = new Point(165, 90);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(100, 23);
            cmb_gender.TabIndex = 4;
            cmb_gender.Text = "Genero:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(165, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 2;
            // 
            // dtp_birth
            // 
            dtp_birth.Format = DateTimePickerFormat.Short;
            dtp_birth.Location = new Point(165, 119);
            dtp_birth.Name = "dtp_birth";
            dtp_birth.Size = new Size(100, 23);
            dtp_birth.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 35);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 125);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "Birth Date:";
            // 
            // Frm_Reg_Actor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 228);
            Name = "Frm_Reg_Actor";
            Text = "Frm_Reg_Actor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private DateTimePicker dtp_birth;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_lastName;
        private ComboBox cmb_gender;
    }
}