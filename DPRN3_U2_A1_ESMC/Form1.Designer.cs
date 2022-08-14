namespace DPRN3_U2_A1_ESMC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dtAutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cmbyearauto = new System.Windows.Forms.ComboBox();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Isverifacdocmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtColorMixto = new System.Windows.Forms.TextBox();
            this.AzulCh = new System.Windows.Forms.CheckBox();
            this.GrisCh = new System.Windows.Forms.CheckBox();
            this.amarilloCh = new System.Windows.Forms.CheckBox();
            this.NegroCh = new System.Windows.Forms.CheckBox();
            this.RojoCh = new System.Windows.Forms.CheckBox();
            this.colorcmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.imgtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.marcatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serietxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipocmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dtAutos);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbyearauto);
            this.groupBox1.Controls.Add(this.cmbyear);
            this.groupBox1.Controls.Add(this.lblfecha);
            this.groupBox1.Controls.Add(this.lblhora);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Isverifacdocmb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.imgtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.modelotxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.marcatxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serietxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tipocmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Flotilla";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1105, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtAutos
            // 
            this.dtAutos.AllowUserToAddRows = false;
            this.dtAutos.AllowUserToDeleteRows = false;
            this.dtAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAutos.Location = new System.Drawing.Point(29, 261);
            this.dtAutos.Name = "dtAutos";
            this.dtAutos.ReadOnly = true;
            this.dtAutos.Size = new System.Drawing.Size(1151, 165);
            this.dtAutos.TabIndex = 25;
            this.dtAutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAutos_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImagen);
            this.groupBox3.Location = new System.Drawing.Point(584, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 220);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vista Previa";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(16, 19);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(296, 182);
            this.pbImagen.TabIndex = 26;
            this.pbImagen.TabStop = false;
            // 
            // cmbyearauto
            // 
            this.cmbyearauto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyearauto.FormattingEnabled = true;
            this.cmbyearauto.Location = new System.Drawing.Point(124, 164);
            this.cmbyearauto.Name = "cmbyearauto";
            this.cmbyearauto.Size = new System.Drawing.Size(173, 21);
            this.cmbyearauto.TabIndex = 31;
            // 
            // cmbyear
            // 
            this.cmbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Location = new System.Drawing.Point(124, 76);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(173, 21);
            this.cmbyear.TabIndex = 30;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(935, 103);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(111, 20);
            this.lblfecha.TabIndex = 29;
            this.lblfecha.Text = "DD/MM/AAAA";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblhora.Location = new System.Drawing.Point(929, 52);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(71, 37);
            this.lblhora.TabIndex = 28;
            this.lblhora.Text = "--/--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(929, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Fecha / Hora:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Isverifacdocmb
            // 
            this.Isverifacdocmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Isverifacdocmb.FormattingEnabled = true;
            this.Isverifacdocmb.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.Isverifacdocmb.Location = new System.Drawing.Point(124, 224);
            this.Isverifacdocmb.Name = "Isverifacdocmb";
            this.Isverifacdocmb.Size = new System.Drawing.Size(173, 21);
            this.Isverifacdocmb.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Es verificado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtColorMixto);
            this.groupBox2.Controls.Add(this.AzulCh);
            this.groupBox2.Controls.Add(this.GrisCh);
            this.groupBox2.Controls.Add(this.amarilloCh);
            this.groupBox2.Controls.Add(this.NegroCh);
            this.groupBox2.Controls.Add(this.RojoCh);
            this.groupBox2.Controls.Add(this.colorcmb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(347, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 210);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // txtColorMixto
            // 
            this.txtColorMixto.Location = new System.Drawing.Point(15, 174);
            this.txtColorMixto.Name = "txtColorMixto";
            this.txtColorMixto.Size = new System.Drawing.Size(197, 20);
            this.txtColorMixto.TabIndex = 23;
            // 
            // AzulCh
            // 
            this.AzulCh.AutoSize = true;
            this.AzulCh.Location = new System.Drawing.Point(15, 142);
            this.AzulCh.Name = "AzulCh";
            this.AzulCh.Size = new System.Drawing.Size(46, 17);
            this.AzulCh.TabIndex = 22;
            this.AzulCh.Text = "Azul";
            this.AzulCh.UseVisualStyleBackColor = true;
            this.AzulCh.CheckedChanged += new System.EventHandler(this.AzulCh_CheckedChanged);
            // 
            // GrisCh
            // 
            this.GrisCh.AutoSize = true;
            this.GrisCh.Location = new System.Drawing.Point(92, 119);
            this.GrisCh.Name = "GrisCh";
            this.GrisCh.Size = new System.Drawing.Size(44, 17);
            this.GrisCh.TabIndex = 21;
            this.GrisCh.Text = "Gris";
            this.GrisCh.UseVisualStyleBackColor = true;
            this.GrisCh.CheckedChanged += new System.EventHandler(this.GrisCh_CheckedChanged);
            // 
            // amarilloCh
            // 
            this.amarilloCh.AutoSize = true;
            this.amarilloCh.Location = new System.Drawing.Point(15, 119);
            this.amarilloCh.Name = "amarilloCh";
            this.amarilloCh.Size = new System.Drawing.Size(62, 17);
            this.amarilloCh.TabIndex = 20;
            this.amarilloCh.Text = "Amarillo";
            this.amarilloCh.UseVisualStyleBackColor = true;
            this.amarilloCh.CheckedChanged += new System.EventHandler(this.amarilloCh_CheckedChanged);
            // 
            // NegroCh
            // 
            this.NegroCh.AutoSize = true;
            this.NegroCh.Location = new System.Drawing.Point(91, 142);
            this.NegroCh.Name = "NegroCh";
            this.NegroCh.Size = new System.Drawing.Size(55, 17);
            this.NegroCh.TabIndex = 19;
            this.NegroCh.Text = "Negro";
            this.NegroCh.UseVisualStyleBackColor = true;
            this.NegroCh.CheckedChanged += new System.EventHandler(this.NegroCh_CheckedChanged);
            // 
            // RojoCh
            // 
            this.RojoCh.AutoSize = true;
            this.RojoCh.Location = new System.Drawing.Point(164, 119);
            this.RojoCh.Name = "RojoCh";
            this.RojoCh.Size = new System.Drawing.Size(48, 17);
            this.RojoCh.TabIndex = 18;
            this.RojoCh.Text = "Rojo";
            this.RojoCh.UseVisualStyleBackColor = true;
            this.RojoCh.CheckedChanged += new System.EventHandler(this.RojoCh_CheckedChanged);
            // 
            // colorcmb
            // 
            this.colorcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorcmb.FormattingEnabled = true;
            this.colorcmb.Items.AddRange(new object[] {
            "ROJO",
            "NEGRO",
            "AMARILLO",
            "GRIS",
            "AZUL"});
            this.colorcmb.Location = new System.Drawing.Point(52, 58);
            this.colorcmb.Name = "colorcmb";
            this.colorcmb.Size = new System.Drawing.Size(111, 21);
            this.colorcmb.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Color:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mixto";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Un color";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgtxt
            // 
            this.imgtxt.Enabled = false;
            this.imgtxt.Location = new System.Drawing.Point(124, 194);
            this.imgtxt.Name = "imgtxt";
            this.imgtxt.Size = new System.Drawing.Size(173, 20);
            this.imgtxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Imagen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Año del auto:";
            // 
            // modelotxt
            // 
            this.modelotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.modelotxt.Location = new System.Drawing.Point(124, 135);
            this.modelotxt.Name = "modelotxt";
            this.modelotxt.Size = new System.Drawing.Size(173, 20);
            this.modelotxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modelo:";
            // 
            // marcatxt
            // 
            this.marcatxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.marcatxt.Location = new System.Drawing.Point(124, 106);
            this.marcatxt.Name = "marcatxt";
            this.marcatxt.Size = new System.Drawing.Size(173, 20);
            this.marcatxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año de adqusición:";
            // 
            // serietxt
            // 
            this.serietxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.serietxt.Location = new System.Drawing.Point(124, 47);
            this.serietxt.MaxLength = 17;
            this.serietxt.Name = "serietxt";
            this.serietxt.Size = new System.Drawing.Size(173, 20);
            this.serietxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serie:";
            // 
            // tipocmb
            // 
            this.tipocmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipocmb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tipocmb.Items.AddRange(new object[] {
            "SEDAN",
            "PICK-UP",
            "MOTOCICLETA"});
            this.tipocmb.Location = new System.Drawing.Point(124, 17);
            this.tipocmb.Name = "tipocmb";
            this.tipocmb.Size = new System.Drawing.Size(173, 21);
            this.tipocmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Vehículo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 538);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Control de Flotillas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marcatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serietxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipocmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox colorcmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox imgtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Isverifacdocmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox AzulCh;
        private System.Windows.Forms.CheckBox GrisCh;
        private System.Windows.Forms.CheckBox amarilloCh;
        private System.Windows.Forms.CheckBox NegroCh;
        private System.Windows.Forms.CheckBox RojoCh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtAutos;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.ComboBox cmbyearauto;
        private System.Windows.Forms.TextBox txtColorMixto;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

