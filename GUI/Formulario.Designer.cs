namespace GUI
{
    partial class Formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cnt_tab = new System.Windows.Forms.TabControl();
            this.tab_admin = new System.Windows.Forms.TabPage();
            this.tab_seccion1 = new System.Windows.Forms.TabPage();
            this.tab1_btn_submit = new System.Windows.Forms.Button();
            this.tab1_txtbx4 = new System.Windows.Forms.TextBox();
            this.tab1_txtbx3 = new System.Windows.Forms.TextBox();
            this.tab1_txtbx2 = new System.Windows.Forms.TextBox();
            this.tab1_txtbx1 = new System.Windows.Forms.TextBox();
            this.rdbtn_opcion2 = new System.Windows.Forms.RadioButton();
            this.rdbtn_opcion1 = new System.Windows.Forms.RadioButton();
            this.prueba = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TituloDeSeccion1 = new System.Windows.Forms.Label();
            this.tab_seccion2 = new System.Windows.Forms.TabPage();
            this.tab_seccion3 = new System.Windows.Forms.TabPage();
            this.tab_seccion4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tab2_rdbtn_opcion1 = new System.Windows.Forms.RadioButton();
            this.tab2_rdbtn_opcion2 = new System.Windows.Forms.RadioButton();
            this.tab2_rdbtn_opcion3 = new System.Windows.Forms.RadioButton();
            this.tab2_rdbtn_opcion4 = new System.Windows.Forms.RadioButton();
            this.cnt_tab.SuspendLayout();
            this.tab_seccion1.SuspendLayout();
            this.tab_seccion2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnt_tab
            // 
            this.cnt_tab.Controls.Add(this.tab_admin);
            this.cnt_tab.Controls.Add(this.tab_seccion1);
            this.cnt_tab.Controls.Add(this.tab_seccion2);
            this.cnt_tab.Controls.Add(this.tab_seccion3);
            this.cnt_tab.Controls.Add(this.tab_seccion4);
            this.cnt_tab.Location = new System.Drawing.Point(-2, 2);
            this.cnt_tab.Name = "cnt_tab";
            this.cnt_tab.SelectedIndex = 0;
            this.cnt_tab.Size = new System.Drawing.Size(804, 453);
            this.cnt_tab.TabIndex = 0;
            // 
            // tab_admin
            // 
            this.tab_admin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_admin.Location = new System.Drawing.Point(4, 24);
            this.tab_admin.Name = "tab_admin";
            this.tab_admin.Size = new System.Drawing.Size(796, 425);
            this.tab_admin.TabIndex = 4;
            this.tab_admin.Text = "Administrador";
            this.tab_admin.UseVisualStyleBackColor = true;
            // 
            // tab_seccion1
            // 
            this.tab_seccion1.Controls.Add(this.tab1_btn_submit);
            this.tab_seccion1.Controls.Add(this.tab1_txtbx4);
            this.tab_seccion1.Controls.Add(this.tab1_txtbx3);
            this.tab_seccion1.Controls.Add(this.tab1_txtbx2);
            this.tab_seccion1.Controls.Add(this.tab1_txtbx1);
            this.tab_seccion1.Controls.Add(this.rdbtn_opcion2);
            this.tab_seccion1.Controls.Add(this.rdbtn_opcion1);
            this.tab_seccion1.Controls.Add(this.prueba);
            this.tab_seccion1.Controls.Add(this.label6);
            this.tab_seccion1.Controls.Add(this.label5);
            this.tab_seccion1.Controls.Add(this.label10);
            this.tab_seccion1.Controls.Add(this.label9);
            this.tab_seccion1.Controls.Add(this.label8);
            this.tab_seccion1.Controls.Add(this.label7);
            this.tab_seccion1.Controls.Add(this.label4);
            this.tab_seccion1.Controls.Add(this.label3);
            this.tab_seccion1.Controls.Add(this.label2);
            this.tab_seccion1.Controls.Add(this.label1);
            this.tab_seccion1.Controls.Add(this.TituloDeSeccion1);
            this.tab_seccion1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_seccion1.Location = new System.Drawing.Point(4, 24);
            this.tab_seccion1.Name = "tab_seccion1";
            this.tab_seccion1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_seccion1.Size = new System.Drawing.Size(796, 425);
            this.tab_seccion1.TabIndex = 0;
            this.tab_seccion1.Text = "Seccion 1";
            this.tab_seccion1.UseVisualStyleBackColor = true;
            this.tab_seccion1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tab1_btn_submit
            // 
            this.tab1_btn_submit.Location = new System.Drawing.Point(162, 361);
            this.tab1_btn_submit.Name = "tab1_btn_submit";
            this.tab1_btn_submit.Size = new System.Drawing.Size(75, 23);
            this.tab1_btn_submit.TabIndex = 4;
            this.tab1_btn_submit.Text = "Ingresar";
            this.tab1_btn_submit.UseVisualStyleBackColor = true;
            this.tab1_btn_submit.Click += new System.EventHandler(this.tab1_btn_submit_Click);
            // 
            // tab1_txtbx4
            // 
            this.tab1_txtbx4.Location = new System.Drawing.Point(335, 315);
            this.tab1_txtbx4.Name = "tab1_txtbx4";
            this.tab1_txtbx4.Size = new System.Drawing.Size(100, 23);
            this.tab1_txtbx4.TabIndex = 3;
            // 
            // tab1_txtbx3
            // 
            this.tab1_txtbx3.Location = new System.Drawing.Point(335, 278);
            this.tab1_txtbx3.Name = "tab1_txtbx3";
            this.tab1_txtbx3.Size = new System.Drawing.Size(100, 23);
            this.tab1_txtbx3.TabIndex = 3;
            // 
            // tab1_txtbx2
            // 
            this.tab1_txtbx2.Location = new System.Drawing.Point(335, 245);
            this.tab1_txtbx2.Name = "tab1_txtbx2";
            this.tab1_txtbx2.Size = new System.Drawing.Size(100, 23);
            this.tab1_txtbx2.TabIndex = 3;
            // 
            // tab1_txtbx1
            // 
            this.tab1_txtbx1.Location = new System.Drawing.Point(335, 215);
            this.tab1_txtbx1.Name = "tab1_txtbx1";
            this.tab1_txtbx1.Size = new System.Drawing.Size(100, 23);
            this.tab1_txtbx1.TabIndex = 3;
            // 
            // rdbtn_opcion2
            // 
            this.rdbtn_opcion2.AutoSize = true;
            this.rdbtn_opcion2.Checked = true;
            this.rdbtn_opcion2.Location = new System.Drawing.Point(10, 108);
            this.rdbtn_opcion2.Name = "rdbtn_opcion2";
            this.rdbtn_opcion2.Size = new System.Drawing.Size(105, 20);
            this.rdbtn_opcion2.TabIndex = 2;
            this.rdbtn_opcion2.TabStop = true;
            this.rdbtn_opcion2.Text = "En otra area";
            this.rdbtn_opcion2.UseVisualStyleBackColor = true;
            this.rdbtn_opcion2.CheckedChanged += new System.EventHandler(this.rdbtn_opcion2_CheckedChanged);
            // 
            // rdbtn_opcion1
            // 
            this.rdbtn_opcion1.AutoSize = true;
            this.rdbtn_opcion1.Location = new System.Drawing.Point(10, 82);
            this.rdbtn_opcion1.Name = "rdbtn_opcion1";
            this.rdbtn_opcion1.Size = new System.Drawing.Size(319, 20);
            this.rdbtn_opcion1.TabIndex = 2;
            this.rdbtn_opcion1.Text = "En medicina Humana o composicion Musical";
            this.rdbtn_opcion1.UseVisualStyleBackColor = true;
            this.rdbtn_opcion1.CheckedChanged += new System.EventHandler(this.rdbtn_opcion1_CheckedChanged);
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Location = new System.Drawing.Point(243, 364);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(53, 16);
            this.prueba.TabIndex = 1;
            this.prueba.Text = "Prueba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ph.D. o Doctorado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Magister o Mestrias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(441, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Programas cursados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(441, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Programas cursados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(441, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Programas cursados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(441, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Años academicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "No clinicas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clinicas en Medicina Humana y Odontologia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por titulos de Posgrado.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por titulos de pregrado: Solo si ha obtenido el diploma.";
            // 
            // TituloDeSeccion1
            // 
            this.TituloDeSeccion1.AutoSize = true;
            this.TituloDeSeccion1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TituloDeSeccion1.Location = new System.Drawing.Point(10, 14);
            this.TituloDeSeccion1.Name = "TituloDeSeccion1";
            this.TituloDeSeccion1.Size = new System.Drawing.Size(263, 19);
            this.TituloDeSeccion1.TabIndex = 0;
            this.TituloDeSeccion1.Text = "1. Titulos de estudios universitarios";
            // 
            // tab_seccion2
            // 
            this.tab_seccion2.Controls.Add(this.tab2_rdbtn_opcion4);
            this.tab_seccion2.Controls.Add(this.tab2_rdbtn_opcion3);
            this.tab_seccion2.Controls.Add(this.tab2_rdbtn_opcion2);
            this.tab_seccion2.Controls.Add(this.tab2_rdbtn_opcion1);
            this.tab_seccion2.Controls.Add(this.label11);
            this.tab_seccion2.Controls.Add(this.label12);
            this.tab_seccion2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_seccion2.Location = new System.Drawing.Point(4, 24);
            this.tab_seccion2.Name = "tab_seccion2";
            this.tab_seccion2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_seccion2.Size = new System.Drawing.Size(796, 425);
            this.tab_seccion2.TabIndex = 1;
            this.tab_seccion2.Text = "Seccion 2";
            this.tab_seccion2.UseVisualStyleBackColor = true;
            // 
            // tab_seccion3
            // 
            this.tab_seccion3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_seccion3.Location = new System.Drawing.Point(4, 24);
            this.tab_seccion3.Name = "tab_seccion3";
            this.tab_seccion3.Padding = new System.Windows.Forms.Padding(3);
            this.tab_seccion3.Size = new System.Drawing.Size(796, 425);
            this.tab_seccion3.TabIndex = 2;
            this.tab_seccion3.Text = "Seccion 3";
            this.tab_seccion3.UseVisualStyleBackColor = true;
            // 
            // tab_seccion4
            // 
            this.tab_seccion4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_seccion4.Location = new System.Drawing.Point(4, 24);
            this.tab_seccion4.Name = "tab_seccion4";
            this.tab_seccion4.Padding = new System.Windows.Forms.Padding(3);
            this.tab_seccion4.Size = new System.Drawing.Size(796, 425);
            this.tab_seccion4.TabIndex = 3;
            this.tab_seccion4.Text = "Seccion 4";
            this.tab_seccion4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Seleccione una categoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(10, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "2. Categoria";
            // 
            // tab2_rdbtn_opcion1
            // 
            this.tab2_rdbtn_opcion1.AutoSize = true;
            this.tab2_rdbtn_opcion1.Location = new System.Drawing.Point(10, 79);
            this.tab2_rdbtn_opcion1.Name = "tab2_rdbtn_opcion1";
            this.tab2_rdbtn_opcion1.Size = new System.Drawing.Size(85, 20);
            this.tab2_rdbtn_opcion1.TabIndex = 4;
            this.tab2_rdbtn_opcion1.TabStop = true;
            this.tab2_rdbtn_opcion1.Text = "Instructor";
            this.tab2_rdbtn_opcion1.UseVisualStyleBackColor = true;
            // 
            // tab2_rdbtn_opcion2
            // 
            this.tab2_rdbtn_opcion2.AutoSize = true;
            this.tab2_rdbtn_opcion2.Location = new System.Drawing.Point(10, 105);
            this.tab2_rdbtn_opcion2.Name = "tab2_rdbtn_opcion2";
            this.tab2_rdbtn_opcion2.Size = new System.Drawing.Size(83, 20);
            this.tab2_rdbtn_opcion2.TabIndex = 4;
            this.tab2_rdbtn_opcion2.TabStop = true;
            this.tab2_rdbtn_opcion2.Text = "Asistente";
            this.tab2_rdbtn_opcion2.UseVisualStyleBackColor = true;
            // 
            // tab2_rdbtn_opcion3
            // 
            this.tab2_rdbtn_opcion3.AutoSize = true;
            this.tab2_rdbtn_opcion3.Location = new System.Drawing.Point(10, 131);
            this.tab2_rdbtn_opcion3.Name = "tab2_rdbtn_opcion3";
            this.tab2_rdbtn_opcion3.Size = new System.Drawing.Size(87, 20);
            this.tab2_rdbtn_opcion3.TabIndex = 4;
            this.tab2_rdbtn_opcion3.TabStop = true;
            this.tab2_rdbtn_opcion3.Text = "Asociado";
            this.tab2_rdbtn_opcion3.UseVisualStyleBackColor = true;
            // 
            // tab2_rdbtn_opcion4
            // 
            this.tab2_rdbtn_opcion4.AutoSize = true;
            this.tab2_rdbtn_opcion4.Location = new System.Drawing.Point(10, 157);
            this.tab2_rdbtn_opcion4.Name = "tab2_rdbtn_opcion4";
            this.tab2_rdbtn_opcion4.Size = new System.Drawing.Size(65, 20);
            this.tab2_rdbtn_opcion4.TabIndex = 4;
            this.tab2_rdbtn_opcion4.TabStop = true;
            this.tab2_rdbtn_opcion4.Text = "Titular";
            this.tab2_rdbtn_opcion4.UseVisualStyleBackColor = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnt_tab);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.cnt_tab.ResumeLayout(false);
            this.tab_seccion1.ResumeLayout(false);
            this.tab_seccion1.PerformLayout();
            this.tab_seccion2.ResumeLayout(false);
            this.tab_seccion2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl cnt_tab;
        private TabPage tab_seccion1;
        private TabPage tab_seccion2;
        private TabPage tab_seccion3;
        private TabPage tab_seccion4;
        private TabPage tab_admin;
        private Label label1;
        private Label TituloDeSeccion1;
        private TextBox tab1_txtbx4;
        private TextBox tab1_txtbx3;
        private TextBox tab1_txtbx2;
        private TextBox tab1_txtbx1;
        private RadioButton rdbtn_opcion2;
        private RadioButton rdbtn_opcion1;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button tab1_btn_submit;
        private Label prueba;
        private Label label11;
        private Label label12;
        private RadioButton tab2_rdbtn_opcion4;
        private RadioButton tab2_rdbtn_opcion3;
        private RadioButton tab2_rdbtn_opcion2;
        private RadioButton tab2_rdbtn_opcion1;
    }
}