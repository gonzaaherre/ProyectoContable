namespace Contabilidad
{
    partial class LibroDiario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroDiario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_mayor = new System.Windows.Forms.Button();
            this.btn_asiento = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadDataSet1 = new Contabilidad.contabilidadDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadDataSet = new Contabilidad.contabilidadDataSet();
            this.contabilidadTableAdapter = new Contabilidad.contabilidadDataSetTableAdapters.contabilidadTableAdapter();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.contabilidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadDataSet11 = new Contabilidad.contabilidadDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contabilidadBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadDataSet2 = new Contabilidad.contabilidadDataSet2();
            this.contabilidadBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contabilidadTableAdapter1 = new Contabilidad.contabilidadDataSet1TableAdapters.contabilidadTableAdapter();
            this.contabilidadTableAdapter2 = new Contabilidad.contabilidadDataSet2TableAdapters.contabilidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mayor
            // 
            this.btn_mayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mayor.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mayor.Location = new System.Drawing.Point(384, 25);
            this.btn_mayor.Name = "btn_mayor";
            this.btn_mayor.Size = new System.Drawing.Size(149, 33);
            this.btn_mayor.TabIndex = 0;
            this.btn_mayor.Text = "Ver libro mayor";
            this.btn_mayor.UseVisualStyleBackColor = false;
            this.btn_mayor.Click += new System.EventHandler(this.btn_mayor_Click);
            // 
            // btn_asiento
            // 
            this.btn_asiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_asiento.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asiento.Location = new System.Drawing.Point(71, 25);
            this.btn_asiento.Name = "btn_asiento";
            this.btn_asiento.Size = new System.Drawing.Size(149, 33);
            this.btn_asiento.TabIndex = 1;
            this.btn_asiento.Text = "Agregar Asiento";
            this.btn_asiento.UseVisualStyleBackColor = false;
            this.btn_asiento.Click += new System.EventHandler(this.btn_asiento_Click_1);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "contabilidad";
            this.bindingSource2.DataSource = this.contabilidadDataSet1;
            // 
            // contabilidadDataSet1
            // 
            this.contabilidadDataSet1.DataSetName = "contabilidadDataSet";
            this.contabilidadDataSet1.Namespace = "http://tempuri.org/contabilidadDataSet.xsd";
            this.contabilidadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "contabilidad";
            this.bindingSource1.DataSource = this.contabilidadDataSet;
            // 
            // contabilidadDataSet
            // 
            this.contabilidadDataSet.DataSetName = "contabilidadDataSet";
            this.contabilidadDataSet.Namespace = "http://tempuri.org/contabilidadDataSet.xsd";
            this.contabilidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contabilidadTableAdapter
            // 
            this.contabilidadTableAdapter.ClearBeforeFill = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // contabilidadBindingSource
            // 
            this.contabilidadBindingSource.DataMember = "contabilidad";
            this.contabilidadBindingSource.DataSource = this.contabilidadDataSet1;
            // 
            // contabilidadBindingSource2
            // 
            this.contabilidadBindingSource2.DataMember = "contabilidad";
            this.contabilidadBindingSource2.DataSource = this.contabilidadDataSet1;
            // 
            // contabilidadDataSet11
            // 
            this.contabilidadDataSet11.DataSetName = "contabilidadDataSet1";
            this.contabilidadDataSet11.Namespace = "http://tempuri.org/contabilidadDataSet1.xsd";
            this.contabilidadDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.asientoDataGridViewTextBoxColumn, this.fechaDataGridViewTextBoxColumn, this.CuentaDebe, this.CuentaHaber, this.debeDataGridViewTextBoxColumn, this.haberDataGridViewTextBoxColumn });
            this.dataGridView1.DataSource = this.contabilidadBindingSource5;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(236)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(638, 227);
            this.dataGridView1.TabIndex = 2;
            // 
            // asientoDataGridViewTextBoxColumn
            // 
            this.asientoDataGridViewTextBoxColumn.DataPropertyName = "Asiento";
            this.asientoDataGridViewTextBoxColumn.HeaderText = "Asiento";
            this.asientoDataGridViewTextBoxColumn.Name = "asientoDataGridViewTextBoxColumn";
            this.asientoDataGridViewTextBoxColumn.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // CuentaDebe
            // 
            this.CuentaDebe.DataPropertyName = "CuentaDebe";
            this.CuentaDebe.HeaderText = "CuentaDebe";
            this.CuentaDebe.Name = "CuentaDebe";
            this.CuentaDebe.Width = 150;
            // 
            // CuentaHaber
            // 
            this.CuentaHaber.DataPropertyName = "CuentaHaber";
            this.CuentaHaber.HeaderText = "CuentaHaber";
            this.CuentaHaber.Name = "CuentaHaber";
            this.CuentaHaber.Width = 150;
            // 
            // debeDataGridViewTextBoxColumn
            // 
            this.debeDataGridViewTextBoxColumn.DataPropertyName = "Debe";
            this.debeDataGridViewTextBoxColumn.HeaderText = "Debe";
            this.debeDataGridViewTextBoxColumn.Name = "debeDataGridViewTextBoxColumn";
            this.debeDataGridViewTextBoxColumn.Width = 80;
            // 
            // haberDataGridViewTextBoxColumn
            // 
            this.haberDataGridViewTextBoxColumn.DataPropertyName = "Haber";
            this.haberDataGridViewTextBoxColumn.HeaderText = "Haber";
            this.haberDataGridViewTextBoxColumn.Name = "haberDataGridViewTextBoxColumn";
            this.haberDataGridViewTextBoxColumn.Width = 80;
            // 
            // contabilidadBindingSource5
            // 
            this.contabilidadBindingSource5.DataMember = "contabilidad";
            this.contabilidadBindingSource5.DataSource = this.contabilidadDataSet2;
            // 
            // contabilidadDataSet2
            // 
            this.contabilidadDataSet2.DataSetName = "contabilidadDataSet2";
            this.contabilidadDataSet2.Namespace = "http://tempuri.org/contabilidadDataSet2.xsd";
            this.contabilidadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contabilidadBindingSource4
            // 
            this.contabilidadBindingSource4.DataMember = "contabilidad";
            this.contabilidadBindingSource4.DataSource = this.contabilidadDataSet11BindingSource;
            // 
            // contabilidadDataSet11BindingSource
            // 
            this.contabilidadDataSet11BindingSource.DataSource = this.contabilidadDataSet11;
            this.contabilidadDataSet11BindingSource.Position = 0;
            // 
            // contabilidadBindingSource3
            // 
            this.contabilidadBindingSource3.DataMember = "contabilidad";
            this.contabilidadBindingSource3.DataSource = this.contabilidadDataSet1;
            // 
            // contabilidadTableAdapter1
            // 
            this.contabilidadTableAdapter1.ClearBeforeFill = true;
            // 
            // contabilidadTableAdapter2
            // 
            this.contabilidadTableAdapter2.ClearBeforeFill = true;
            // 
            // LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_asiento);
            this.Controls.Add(this.btn_mayor);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LibroDiario";
            this.Text = "Libro Diario";
            this.Load += new System.EventHandler(this.LibroDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contabilidadBindingSource3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_mayor;
        private System.Windows.Forms.Button btn_asiento;
        private System.Windows.Forms.BindingSource contabilidadBindingSource1;
        private contabilidadDataSet contabilidadDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private contabilidadDataSetTableAdapters.contabilidadTableAdapter contabilidadTableAdapter;
        private contabilidadDataSet contabilidadDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.BindingSource contabilidadBindingSource;
        private System.Windows.Forms.BindingSource contabilidadBindingSource2;
        private contabilidadDataSet1 contabilidadDataSet11;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contabilidadBindingSource3;
        private System.Windows.Forms.BindingSource contabilidadDataSet11BindingSource;
        private System.Windows.Forms.BindingSource contabilidadBindingSource4;
        private contabilidadDataSet1TableAdapters.contabilidadTableAdapter contabilidadTableAdapter1;
        private contabilidadDataSet2 contabilidadDataSet2;
        private System.Windows.Forms.BindingSource contabilidadBindingSource5;
        private contabilidadDataSet2TableAdapters.contabilidadTableAdapter contabilidadTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn debeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberDataGridViewTextBoxColumn;
    }
}