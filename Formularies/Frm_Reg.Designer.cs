namespace Cinema.Formularies
{
    partial class Frm_Reg
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
            button1 = new Button();
            btn_register = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(203, 175);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(78, 175);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 1;
            btn_register.Text = "Registrar";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Frm_Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(391, 235);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "Frm_Reg";
            Text = "Frm_Reg";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Button button1;
        protected Button btn_register;
        protected GroupBox groupBox1;
    }
}