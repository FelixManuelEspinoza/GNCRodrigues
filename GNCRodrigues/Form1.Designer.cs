namespace GNCRodrigues
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Cb_retirar = new System.Windows.Forms.CheckBox();
            this.Cb_clienteavisado = new System.Windows.Forms.CheckBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gNCRodriguesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gNCRodriguesDataSet = new GNCRodrigues.GNCRodriguesDataSet();
            this.Cb_Cortacorriente = new System.Windows.Forms.CheckBox();
            this.Cb_Nafta = new System.Windows.Forms.CheckBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Tb_total = new System.Windows.Forms.TextBox();
            this.Tb_presupuesto = new System.Windows.Forms.TextBox();
            this.Tb_Trabajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_Fallas = new System.Windows.Forms.TextBox();
            this.Tb_Detalle = new System.Windows.Forms.TextBox();
            this.Tb_Telefono = new System.Windows.Forms.TextBox();
            this.Tb_dominio = new System.Windows.Forms.TextBox();
            this.Tb_Vehiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gNCRodriguesDataSet1 = new GNCRodrigues.GNCRodriguesDataSet1();
            this.tableTableAdapter = new GNCRodrigues.GNCRodriguesDataSetTableAdapters.TableTableAdapter();
            this.ordenTableAdapter = new GNCRodrigues.GNCRodriguesDataSet1TableAdapters.OrdenTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Btn_modificar);
            this.tabPage1.Controls.Add(this.Btn_limpiar);
            this.tabPage1.Controls.Add(this.Btn_guardar);
            this.tabPage1.Controls.Add(this.Cb_retirar);
            this.tabPage1.Controls.Add(this.Cb_clienteavisado);
            this.tabPage1.Controls.Add(this.Cb_Cortacorriente);
            this.tabPage1.Controls.Add(this.Cb_Nafta);
            this.tabPage1.Controls.Add(this.Dtp_Fecha);
            this.tabPage1.Controls.Add(this.Tb_total);
            this.tabPage1.Controls.Add(this.Tb_presupuesto);
            this.tabPage1.Controls.Add(this.Tb_Trabajo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Tb_Fallas);
            this.tabPage1.Controls.Add(this.Tb_Detalle);
            this.tabPage1.Controls.Add(this.Tb_Telefono);
            this.tabPage1.Controls.Add(this.Tb_dominio);
            this.tabPage1.Controls.Add(this.Tb_Vehiculo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orden de Trabajo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(325, 537);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.Btn_modificar.TabIndex = 27;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(211, 537);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpiar.TabIndex = 26;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(93, 537);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 25;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Cb_retirar
            // 
            this.Cb_retirar.AutoSize = true;
            this.Cb_retirar.Location = new System.Drawing.Point(391, 455);
            this.Cb_retirar.Name = "Cb_retirar";
            this.Cb_retirar.Size = new System.Drawing.Size(117, 17);
            this.Cb_retirar.TabIndex = 24;
            this.Cb_retirar.Text = "Avisado para retirar";
            this.Cb_retirar.UseVisualStyleBackColor = true;
            // 
            // Cb_clienteavisado
            // 
            this.Cb_clienteavisado.AutoSize = true;
            this.Cb_clienteavisado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ConfirmoCliente", true));
            this.Cb_clienteavisado.Location = new System.Drawing.Point(391, 259);
            this.Cb_clienteavisado.Name = "Cb_clienteavisado";
            this.Cb_clienteavisado.Size = new System.Drawing.Size(98, 17);
            this.Cb_clienteavisado.TabIndex = 23;
            this.Cb_clienteavisado.Text = "Cliente avisado";
            this.Cb_clienteavisado.UseVisualStyleBackColor = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.gNCRodriguesDataSetBindingSource;
            // 
            // gNCRodriguesDataSetBindingSource
            // 
            this.gNCRodriguesDataSetBindingSource.DataSource = this.gNCRodriguesDataSet;
            this.gNCRodriguesDataSetBindingSource.Position = 0;
            // 
            // gNCRodriguesDataSet
            // 
            this.gNCRodriguesDataSet.DataSetName = "GNCRodriguesDataSet";
            this.gNCRodriguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cb_Cortacorriente
            // 
            this.Cb_Cortacorriente.AutoSize = true;
            this.Cb_Cortacorriente.Location = new System.Drawing.Point(286, 93);
            this.Cb_Cortacorriente.Name = "Cb_Cortacorriente";
            this.Cb_Cortacorriente.Size = new System.Drawing.Size(96, 17);
            this.Cb_Cortacorriente.TabIndex = 22;
            this.Cb_Cortacorriente.Text = "Corta Corriente";
            this.Cb_Cortacorriente.UseVisualStyleBackColor = true;
            // 
            // Cb_Nafta
            // 
            this.Cb_Nafta.AutoSize = true;
            this.Cb_Nafta.Location = new System.Drawing.Point(44, 89);
            this.Cb_Nafta.Name = "Cb_Nafta";
            this.Cb_Nafta.Size = new System.Drawing.Size(52, 17);
            this.Cb_Nafta.TabIndex = 21;
            this.Cb_Nafta.Text = "Nafta";
            this.Cb_Nafta.UseVisualStyleBackColor = true;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(251, 10);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha.TabIndex = 20;
            // 
            // Tb_total
            // 
            this.Tb_total.Location = new System.Drawing.Point(80, 452);
            this.Tb_total.Name = "Tb_total";
            this.Tb_total.Size = new System.Drawing.Size(100, 20);
            this.Tb_total.TabIndex = 19;
            // 
            // Tb_presupuesto
            // 
            this.Tb_presupuesto.Location = new System.Drawing.Point(80, 256);
            this.Tb_presupuesto.Name = "Tb_presupuesto";
            this.Tb_presupuesto.Size = new System.Drawing.Size(100, 20);
            this.Tb_presupuesto.TabIndex = 18;
            // 
            // Tb_Trabajo
            // 
            this.Tb_Trabajo.Location = new System.Drawing.Point(9, 333);
            this.Tb_Trabajo.Multiline = true;
            this.Tb_Trabajo.Name = "Tb_Trabajo";
            this.Tb_Trabajo.Size = new System.Drawing.Size(462, 113);
            this.Tb_Trabajo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trabajo Realizado";
            // 
            // Tb_Fallas
            // 
            this.Tb_Fallas.Location = new System.Drawing.Point(9, 193);
            this.Tb_Fallas.Multiline = true;
            this.Tb_Fallas.Name = "Tb_Fallas";
            this.Tb_Fallas.Size = new System.Drawing.Size(462, 60);
            this.Tb_Fallas.TabIndex = 15;
            // 
            // Tb_Detalle
            // 
            this.Tb_Detalle.Location = new System.Drawing.Point(9, 134);
            this.Tb_Detalle.Multiline = true;
            this.Tb_Detalle.Name = "Tb_Detalle";
            this.Tb_Detalle.Size = new System.Drawing.Size(462, 29);
            this.Tb_Detalle.TabIndex = 14;
            // 
            // Tb_Telefono
            // 
            this.Tb_Telefono.Location = new System.Drawing.Point(263, 44);
            this.Tb_Telefono.Name = "Tb_Telefono";
            this.Tb_Telefono.Size = new System.Drawing.Size(100, 20);
            this.Tb_Telefono.TabIndex = 13;
            // 
            // Tb_dominio
            // 
            this.Tb_dominio.Location = new System.Drawing.Point(60, 44);
            this.Tb_dominio.Name = "Tb_dominio";
            this.Tb_dominio.Size = new System.Drawing.Size(100, 20);
            this.Tb_dominio.TabIndex = 11;
            // 
            // Tb_Vehiculo
            // 
            this.Tb_Vehiculo.Location = new System.Drawing.Point(60, 10);
            this.Tb_Vehiculo.Name = "Tb_Vehiculo";
            this.Tb_Vehiculo.Size = new System.Drawing.Size(100, 20);
            this.Tb_Vehiculo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Presupuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fallas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dominio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Historial";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataMember = "Orden";
            this.ordenBindingSource.DataSource = this.gNCRodriguesDataSet1;
            // 
            // gNCRodriguesDataSet1
            // 
            this.gNCRodriguesDataSet1.DataSetName = "GNCRodriguesDataSet1";
            this.gNCRodriguesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GNC Rodrigues";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Telefono;
        private System.Windows.Forms.TextBox Tb_dominio;
        private System.Windows.Forms.TextBox Tb_Vehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_Fallas;
        private System.Windows.Forms.TextBox Tb_Detalle;
        private System.Windows.Forms.TextBox Tb_total;
        private System.Windows.Forms.TextBox Tb_presupuesto;
        private System.Windows.Forms.TextBox Tb_Trabajo;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.CheckBox Cb_retirar;
        private System.Windows.Forms.CheckBox Cb_clienteavisado;
        private System.Windows.Forms.CheckBox Cb_Cortacorriente;
        private System.Windows.Forms.CheckBox Cb_Nafta;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource gNCRodriguesDataSetBindingSource;
        private GNCRodriguesDataSet gNCRodriguesDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private GNCRodriguesDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private GNCRodriguesDataSet1 gNCRodriguesDataSet1;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private GNCRodriguesDataSet1TableAdapters.OrdenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

