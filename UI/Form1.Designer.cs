namespace UI
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnAñadirAplicacion = new Button();
            cbCategoria = new ComboBox();
            txtPrecio = new TextBox();
            txtDesarrolladora = new TextBox();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            groupBox2 = new GroupBox();
            btnModificar = new Button();
            txtIdMod = new TextBox();
            txtNuevoPrecio = new TextBox();
            txtNuevaDesarrolladora = new TextBox();
            txtNuevaDescripcion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNuevoTitulo = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnAñadirAplicacion);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDesarrolladora);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Añadir aplicacion";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(209, 305);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(113, 54);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAñadirAplicacion
            // 
            btnAñadirAplicacion.Location = new Point(39, 305);
            btnAñadirAplicacion.Name = "btnAñadirAplicacion";
            btnAñadirAplicacion.Size = new Size(113, 54);
            btnAñadirAplicacion.TabIndex = 11;
            btnAñadirAplicacion.Text = "Añadir Aplicación";
            btnAñadirAplicacion.UseVisualStyleBackColor = true;
            btnAñadirAplicacion.Click += btnAñadirAplicacion_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(106, 246);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(216, 23);
            cbCategoria.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(216, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtDesarrolladora
            // 
            txtDesarrolladora.Location = new Point(106, 144);
            txtDesarrolladora.Name = "txtDesarrolladora";
            txtDesarrolladora.Size = new Size(216, 23);
            txtDesarrolladora.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 93);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(216, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 249);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 198);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 147);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Desarrolladora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(106, 42);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(216, 23);
            txtTitulo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(txtIdMod);
            groupBox2.Controls.Add(txtNuevoPrecio);
            groupBox2.Controls.Add(txtNuevaDesarrolladora);
            groupBox2.Controls.Add(txtNuevaDescripcion);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtNuevoTitulo);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 423);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar aplicación";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(106, 266);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(124, 66);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtIdMod
            // 
            txtIdMod.Location = new Point(129, 36);
            txtIdMod.Name = "txtIdMod";
            txtIdMod.Size = new Size(216, 23);
            txtIdMod.TabIndex = 18;
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Location = new Point(129, 220);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new Size(216, 23);
            txtNuevoPrecio.TabIndex = 17;
            // 
            // txtNuevaDesarrolladora
            // 
            txtNuevaDesarrolladora.Location = new Point(129, 174);
            txtNuevaDesarrolladora.Name = "txtNuevaDesarrolladora";
            txtNuevaDesarrolladora.Size = new Size(216, 23);
            txtNuevaDesarrolladora.TabIndex = 16;
            // 
            // txtNuevaDescripcion
            // 
            txtNuevaDescripcion.Location = new Point(129, 128);
            txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            txtNuevaDescripcion.Size = new Size(216, 23);
            txtNuevaDescripcion.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 223);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Nuevo Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 177);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 13;
            label8.Text = "Nueva Desarrolladora:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 131);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 12;
            label9.Text = "Nueva Descripción:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 85);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 11;
            label10.Text = "Nuevo Titulo:";
            // 
            // txtNuevoTitulo
            // 
            txtNuevoTitulo.Location = new Point(129, 82);
            txtNuevoTitulo.Name = "txtNuevoTitulo";
            txtNuevoTitulo.Size = new Size(216, 23);
            txtNuevoTitulo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 39);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 635);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(413, 665);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(572, 119);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar aplicación";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(377, 24);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 66);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(68, 46);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(216, 23);
            txtIdEliminar.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 49);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 20;
            label11.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 792);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private TextBox txtDesarrolladora;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTitulo;
        private Button btnConfirmar;
        private Button btnAñadirAplicacion;
        private ComboBox cbCategoria;
        private GroupBox groupBox2;
        private TextBox txtIdMod;
        private TextBox txtNuevoPrecio;
        private TextBox txtNuevaDesarrolladora;
        private TextBox txtNuevaDescripcion;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNuevoTitulo;
        private Label label6;
        private Button btnModificar;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label11;
    }
}
