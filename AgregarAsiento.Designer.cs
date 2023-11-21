namespace Contabilidad
{
    partial class AgregarAsiento
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAsiento));
            this.rb_debe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_haber = new System.Windows.Forms.RadioButton();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_listaCuentas = new System.Windows.Forms.TextBox();
            this.txt_asiento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.contabilidadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_debe
            // 
            this.rb_debe.AutoSize = true;
            this.rb_debe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.rb_debe.Location = new System.Drawing.Point(6, 20);
            this.rb_debe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_debe.Name = "rb_debe";
            this.rb_debe.Size = new System.Drawing.Size(75, 26);
            this.rb_debe.TabIndex = 2;
            this.rb_debe.TabStop = true;
            this.rb_debe.Text = "Debe";
            this.rb_debe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_haber);
            this.groupBox1.Controls.Add(this.rb_debe);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(79, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(124, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rb_haber
            // 
            this.rb_haber.AutoSize = true;
            this.rb_haber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.rb_haber.Location = new System.Drawing.Point(62, 20);
            this.rb_haber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_haber.Name = "rb_haber";
            this.rb_haber.Size = new System.Drawing.Size(81, 26);
            this.rb_haber.TabIndex = 3;
            this.rb_haber.TabStop = true;
            this.rb_haber.Text = "Haber";
            this.rb_haber.UseVisualStyleBackColor = true;
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_cuenta.Items.AddRange(new object[] { "Acreedores varios", "Alquileres ganados", "Alquileres perdidos", "Banco \"X\" cta cte", "Caja", "Capital", "Costo de ventas", "Depreciaciones", "Deudores por ventas", "Deudores varios", "Documentos a cobrar", "Documentos a pagar", "Equipos de computación", "Gastos generales", "Impuestos", "Inmuebles", "Instalaciones", "Intereses ganados", "Intereses perdidos", "Maquinarias", "Materia prima", "Mercadería", "Mermas y roturas", "Muebles y útiles", "Obligaciones a pagar", "Proveedores", "Rodados", "Sueldos y jornales", "Ventas" });
            this.cb_cuenta.Location = new System.Drawing.Point(51, 79);
            this.cb_cuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(152, 30);
            this.cb_cuenta.Sorted = true;
            this.cb_cuenta.TabIndex = 4;
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(79, 177);
            this.txt_monto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(124, 28);
            this.txt_monto.TabIndex = 5;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F);
            this.btn_agregar.Location = new System.Drawing.Point(73, 285);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 24);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F);
            this.btn_guardar.Location = new System.Drawing.Point(258, 285);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(130, 24);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar asiento";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 28);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingresa por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(4, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Monto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cuenta:";
            // 
            // txt_listaCuentas
            // 
            this.txt_listaCuentas.Location = new System.Drawing.Point(16, 32);
            this.txt_listaCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_listaCuentas.Multiline = true;
            this.txt_listaCuentas.Name = "txt_listaCuentas";
            this.txt_listaCuentas.Size = new System.Drawing.Size(145, 166);
            this.txt_listaCuentas.TabIndex = 12;
            // 
            // txt_asiento
            // 
            this.txt_asiento.AutoSize = true;
            this.txt_asiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_asiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.txt_asiento.Location = new System.Drawing.Point(18, 18);
            this.txt_asiento.Name = "txt_asiento";
            this.txt_asiento.Size = new System.Drawing.Size(0, 33);
            this.txt_asiento.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.txt_listaCuentas);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.groupBox2.Location = new System.Drawing.Point(252, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(177, 212);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de cuentas";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_cuenta);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_monto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.groupBox3.Location = new System.Drawing.Point(22, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(218, 212);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva cuenta a agregar";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // AgregarAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_asiento);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_agregar);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AgregarAsiento";
            this.Text = "Nuevo Asiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton rb_debe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_haber;
        private System.Windows.Forms.ComboBox cb_cuenta;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_listaCuentas;
        private System.Windows.Forms.BindingSource contabilidadDataSetBindingSource;
        private System.Windows.Forms.BindingSource contabilidadBindingSource;
        public System.Windows.Forms.Label txt_asiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

