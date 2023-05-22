namespace Cinema.Formularies
{
    partial class Frm_Rep
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btn__back = new Button();
            btn_search = new Button();
            btn_update = new Button();
            grp_parameters = new GroupBox();
            btn_submit = new Button();
            grp_up_fields = new GroupBox();
            btn_cancel_update = new Button();
            btn_submit_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            grp_parameters.SuspendLayout();
            grp_up_fields.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(538, 197);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn__back);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Location = new Point(12, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // btn__back
            // 
            btn__back.Location = new Point(35, 94);
            btn__back.Name = "btn__back";
            btn__back.Size = new Size(75, 23);
            btn__back.TabIndex = 2;
            btn__back.Text = "Atras";
            btn__back.UseVisualStyleBackColor = true;
            btn__back.Click += btn__back_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(35, 46);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 23);
            btn_search.TabIndex = 0;
            btn_search.Text = "FIltrar";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(226, 123);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 1;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // grp_parameters
            // 
            grp_parameters.Controls.Add(btn_submit);
            grp_parameters.Controls.Add(btn_update);
            grp_parameters.Enabled = false;
            grp_parameters.Location = new Point(162, 215);
            grp_parameters.Name = "grp_parameters";
            grp_parameters.Size = new Size(388, 152);
            grp_parameters.TabIndex = 2;
            grp_parameters.TabStop = false;
            grp_parameters.Text = "Parametros ";
            grp_parameters.Visible = false;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(307, 123);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Aceptar";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // grp_up_fields
            // 
            grp_up_fields.Controls.Add(btn_cancel_update);
            grp_up_fields.Controls.Add(btn_submit_update);
            grp_up_fields.Enabled = false;
            grp_up_fields.Location = new Point(556, 12);
            grp_up_fields.Name = "grp_up_fields";
            grp_up_fields.Size = new Size(200, 355);
            grp_up_fields.TabIndex = 3;
            grp_up_fields.TabStop = false;
            grp_up_fields.Text = "Escoja los campos";
            grp_up_fields.UseCompatibleTextRendering = true;
            grp_up_fields.Visible = false;
            // 
            // btn_cancel_update
            // 
            btn_cancel_update.Location = new Point(6, 326);
            btn_cancel_update.Name = "btn_cancel_update";
            btn_cancel_update.Size = new Size(188, 23);
            btn_cancel_update.TabIndex = 1;
            btn_cancel_update.Text = "Cancelar";
            btn_cancel_update.UseVisualStyleBackColor = true;
            btn_cancel_update.Click += btn_cancel_update_Click;
            // 
            // btn_submit_update
            // 
            btn_submit_update.Location = new Point(6, 297);
            btn_submit_update.Name = "btn_submit_update";
            btn_submit_update.Size = new Size(188, 23);
            btn_submit_update.TabIndex = 0;
            btn_submit_update.Text = "Confirmar Actualizacion";
            btn_submit_update.UseVisualStyleBackColor = true;
            btn_submit_update.Click += btn_submit_update_Click;
            // 
            // Frm_Rep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(766, 395);
            Controls.Add(grp_up_fields);
            Controls.Add(grp_parameters);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Frm_Rep";
            Text = "Frm_Rep";
            Load += Frm_Rep_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            grp_parameters.ResumeLayout(false);
            grp_up_fields.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected DataGridView dataGridView1;
        protected GroupBox groupBox1;
        protected Button btn__back;
        protected Button btn_update;
        protected Button btn_search;
        protected GroupBox grp_parameters;
        protected Button btn_submit;
        protected GroupBox grp_up_fields;
        protected Button btn_cancel_update;
        protected Button btn_submit_update;
    }
}