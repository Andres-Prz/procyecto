namespace gruposInvestigacion
{
    partial class ventanaGrupos
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaGrupos));
            this.txtNombre = new Wisej.Web.TextBox();
            this.comBoxLider = new Wisej.Web.ComboBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.btnGuardar = new Wisej.Web.Button();
            this.btnEditar = new Wisej.Web.Button();
            this.btnEliminar = new Wisej.Web.Button();
            this.btnLimpiar = new Wisej.Web.Button();
            this.label3 = new Wisej.Web.Label();
            this.txtId = new Wisej.Web.TextBox();
            this.btnRefresh = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comBoxLider
            // 
            this.comBoxLider.AutoCompleteMode = Wisej.Web.AutoCompleteMode.AppendFilter;
            this.comBoxLider.Location = new System.Drawing.Point(549, 70);
            this.comBoxLider.Name = "comBoxLider";
            this.comBoxLider.Size = new System.Drawing.Size(190, 30);
            this.comBoxLider.TabIndex = 1;
            this.comBoxLider.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del grupo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lider de grupo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(84, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 301);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(82, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(156, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 49);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(219, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 51);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(287, 119);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 50);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id grupo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(755, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 60);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ventanaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 532);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxLider);
            this.Controls.Add(this.txtNombre);
            this.Name = "ventanaGrupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.ventanaGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtNombre;
        private Wisej.Web.ComboBox comBoxLider;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Button btnGuardar;
        private Wisej.Web.Button btnEditar;
        private Wisej.Web.Button btnEliminar;
        private Wisej.Web.Button btnLimpiar;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox txtId;
        private Wisej.Web.Button btnRefresh;
    }
}