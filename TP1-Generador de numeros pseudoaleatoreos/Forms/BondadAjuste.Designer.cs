
namespace TP2_Generador_de_numeros_pseudoaleatoreos.Forms
{
    partial class BondadAjuste
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BondadAjuste));
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmbK = new System.Windows.Forms.ComboBox();
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntPruebaBondad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDistribucion = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblHipotesis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHipotesisKs = new System.Windows.Forms.Label();
            this.gbUniforme = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.gbPoisson = new System.Windows.Forms.GroupBox();
            this.txtLambdaPoisson = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbExponencial = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLambdaExponencial = new System.Windows.Forms.TextBox();
            this.gbNormal = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesviacionNormal = new System.Windows.Forms.TextBox();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencia_PoAC_PeAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pe_acum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKs = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.gbUniforme.SuspendLayout();
            this.gbPoisson.SuspendLayout();
            this.gbExponencial.SuspendLayout();
            this.gbNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AcceptsReturn = true;
            this.txtN.Location = new System.Drawing.Point(483, 10);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(66, 20);
            this.txtN.TabIndex = 1;
            // 
            // cmbK
            // 
            this.cmbK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbK.FormattingEnabled = true;
            this.cmbK.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cmbK.Location = new System.Drawing.Point(718, 10);
            this.cmbK.Name = "cmbK";
            this.cmbK.Size = new System.Drawing.Size(66, 21);
            this.cmbK.TabIndex = 2;
            this.cmbK.SelectionChangeCommitted += new System.EventHandler(this.cmbK_SelectionChangeCommitted);
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiCuadrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiCuadrado.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fo,
            this.fe,
            this.estadisticoMuestra,
            this.cAcum});
            this.dgvChiCuadrado.Location = new System.Drawing.Point(402, 287);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.Size = new System.Drawing.Size(520, 136);
            this.dgvChiCuadrado.TabIndex = 4;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            this.intervalo.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // estadisticoMuestra
            // 
            this.estadisticoMuestra.HeaderText = "C";
            this.estadisticoMuestra.Name = "estadisticoMuestra";
            this.estadisticoMuestra.ReadOnly = true;
            // 
            // cAcum
            // 
            this.cAcum.HeaderText = "C Acumulado";
            this.cAcum.Name = "cAcum";
            this.cAcum.ReadOnly = true;
            // 
            // bntPruebaBondad
            // 
            this.bntPruebaBondad.Location = new System.Drawing.Point(822, 7);
            this.bntPruebaBondad.Name = "bntPruebaBondad";
            this.bntPruebaBondad.Size = new System.Drawing.Size(103, 23);
            this.bntPruebaBondad.TabIndex = 4;
            this.bntPruebaBondad.Text = "Realizar pruebas";
            this.bntPruebaBondad.UseVisualStyleBackColor = true;
            this.bntPruebaBondad.Click += new System.EventHandler(this.RealizarPrueba);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamaño de la serie (n):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de intervalos (k):";
            // 
            // dgvNros
            // 
            this.dgvNros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNros.BackgroundColor = System.Drawing.Color.White;
            this.dgvNros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.nroAleatorio});
            this.dgvNros.Location = new System.Drawing.Point(10, 110);
            this.dgvNros.Name = "dgvNros";
            this.dgvNros.Size = new System.Drawing.Size(209, 246);
            this.dgvNros.TabIndex = 4;
            this.dgvNros.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test de Kolmogorov-Smirnov";
            // 
            // histograma
            // 
            this.histograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histograma.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.histograma.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Frecuencias";
            legend1.Title = "Frecuencias";
            this.histograma.Legends.Add(legend1);
            this.histograma.Location = new System.Drawing.Point(262, 92);
            this.histograma.Name = "histograma";
            this.histograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "LabelStyle=Bottom";
            series1.Legend = "Frecuencias";
            series1.Name = "Fo";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "LabelStyle=Bottom";
            series2.Legend = "Frecuencias";
            series2.Name = "Fe";
            this.histograma.Series.Add(series1);
            this.histograma.Series.Add(series2);
            this.histograma.Size = new System.Drawing.Size(663, 170);
            this.histograma.TabIndex = 7;
            this.histograma.Text = "chart1";
            this.histograma.Click += new System.EventHandler(this.histograma_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serie de num pseudo-aleatorios:";
            this.label4.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(822, 35);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Seleccionar distribución:";
            // 
            // cmbDistribucion
            // 
            this.cmbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribucion.FormattingEnabled = true;
            this.cmbDistribucion.Items.AddRange(new object[] {
            "Distribucion Normal (Convolucion)",
            "Distribucion Poisson",
            "Distribucion Exponencial Neg.",
            "Distribucion Uniforme",
            "Distribucion Normal (Box-Muller)"});
            this.cmbDistribucion.Location = new System.Drawing.Point(172, 9);
            this.cmbDistribucion.Name = "cmbDistribucion";
            this.cmbDistribucion.Size = new System.Drawing.Size(161, 21);
            this.cmbDistribucion.TabIndex = 0;
            this.cmbDistribucion.SelectedIndexChanged += new System.EventHandler(this.ValidarDistribucion);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(11, 610);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblHipotesis
            // 
            this.lblHipotesis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHipotesis.BackColor = System.Drawing.Color.Transparent;
            this.lblHipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHipotesis.Location = new System.Drawing.Point(223, 426);
            this.lblHipotesis.Name = "lblHipotesis";
            this.lblHipotesis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHipotesis.Size = new System.Drawing.Size(698, 20);
            this.lblHipotesis.TabIndex = 20;
            this.lblHipotesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ver serie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VerSerie);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "A:";
            // 
            // lblHipotesisKs
            // 
            this.lblHipotesisKs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHipotesisKs.BackColor = System.Drawing.Color.Transparent;
            this.lblHipotesisKs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHipotesisKs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotesisKs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHipotesisKs.Location = new System.Drawing.Point(223, 610);
            this.lblHipotesisKs.Name = "lblHipotesisKs";
            this.lblHipotesisKs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHipotesisKs.Size = new System.Drawing.Size(686, 43);
            this.lblHipotesisKs.TabIndex = 20;
            this.lblHipotesisKs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHipotesisKs.Visible = false;
            // 
            // gbUniforme
            // 
            this.gbUniforme.Controls.Add(this.label6);
            this.gbUniforme.Controls.Add(this.label5);
            this.gbUniforme.Controls.Add(this.txtB);
            this.gbUniforme.Controls.Add(this.txtA);
            this.gbUniforme.Location = new System.Drawing.Point(638, 37);
            this.gbUniforme.Name = "gbUniforme";
            this.gbUniforme.Size = new System.Drawing.Size(143, 49);
            this.gbUniforme.TabIndex = 22;
            this.gbUniforme.TabStop = false;
            this.gbUniforme.Text = "Parametros (Uniforme)";
            this.gbUniforme.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "B:";
            // 
            // txtB
            // 
            this.txtB.AcceptsReturn = true;
            this.txtB.Location = new System.Drawing.Point(86, 17);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(39, 20);
            this.txtB.TabIndex = 1;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtA
            // 
            this.txtA.AcceptsReturn = true;
            this.txtA.Location = new System.Drawing.Point(29, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(38, 20);
            this.txtA.TabIndex = 1;
            // 
            // gbPoisson
            // 
            this.gbPoisson.Controls.Add(this.txtLambdaPoisson);
            this.gbPoisson.Controls.Add(this.textBox2);
            this.gbPoisson.Location = new System.Drawing.Point(126, 36);
            this.gbPoisson.Name = "gbPoisson";
            this.gbPoisson.Size = new System.Drawing.Size(122, 49);
            this.gbPoisson.TabIndex = 22;
            this.gbPoisson.TabStop = false;
            this.gbPoisson.Text = "Parametros (Poisson)";
            this.gbPoisson.Visible = false;
            // 
            // txtLambdaPoisson
            // 
            this.txtLambdaPoisson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLambdaPoisson.AutoSize = true;
            this.txtLambdaPoisson.Location = new System.Drawing.Point(14, 21);
            this.txtLambdaPoisson.Name = "txtLambdaPoisson";
            this.txtLambdaPoisson.Size = new System.Drawing.Size(48, 13);
            this.txtLambdaPoisson.TabIndex = 6;
            this.txtLambdaPoisson.Text = "Lambda:";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(63, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 1;
            // 
            // gbExponencial
            // 
            this.gbExponencial.Controls.Add(this.label7);
            this.gbExponencial.Controls.Add(this.txtLambdaExponencial);
            this.gbExponencial.Location = new System.Drawing.Point(475, 37);
            this.gbExponencial.Name = "gbExponencial";
            this.gbExponencial.Size = new System.Drawing.Size(147, 49);
            this.gbExponencial.TabIndex = 22;
            this.gbExponencial.TabStop = false;
            this.gbExponencial.Text = "Parametros (Exponencial)";
            this.gbExponencial.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lambda:";
            // 
            // txtLambdaExponencial
            // 
            this.txtLambdaExponencial.AcceptsReturn = true;
            this.txtLambdaExponencial.Location = new System.Drawing.Point(63, 17);
            this.txtLambdaExponencial.Name = "txtLambdaExponencial";
            this.txtLambdaExponencial.Size = new System.Drawing.Size(38, 20);
            this.txtLambdaExponencial.TabIndex = 1;
            // 
            // gbNormal
            // 
            this.gbNormal.Controls.Add(this.label10);
            this.gbNormal.Controls.Add(this.label8);
            this.gbNormal.Controls.Add(this.txtDesviacionNormal);
            this.gbNormal.Controls.Add(this.txtMediaNormal);
            this.gbNormal.Location = new System.Drawing.Point(263, 36);
            this.gbNormal.Name = "gbNormal";
            this.gbNormal.Size = new System.Drawing.Size(195, 49);
            this.gbNormal.TabIndex = 22;
            this.gbNormal.TabStop = false;
            this.gbNormal.Text = "Parametros (Normal)";
            this.gbNormal.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Desviacion:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Media:";
            // 
            // txtDesviacionNormal
            // 
            this.txtDesviacionNormal.AcceptsReturn = true;
            this.txtDesviacionNormal.Location = new System.Drawing.Point(147, 17);
            this.txtDesviacionNormal.Name = "txtDesviacionNormal";
            this.txtDesviacionNormal.Size = new System.Drawing.Size(38, 20);
            this.txtDesviacionNormal.TabIndex = 1;
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.AcceptsReturn = true;
            this.txtMediaNormal.Location = new System.Drawing.Point(44, 17);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(38, 20);
            this.txtMediaNormal.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Test de Chi-Cuadrado:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // max
            // 
            this.max.HeaderText = "MAX";
            this.max.Name = "max";
            // 
            // diferencia_PoAC_PeAC
            // 
            this.diferencia_PoAC_PeAC.HeaderText = "Po()AC - Pe()AC";
            this.diferencia_PoAC_PeAC.Name = "diferencia_PoAC_PeAC";
            // 
            // Pe_acum
            // 
            this.Pe_acum.HeaderText = "Pe() AC";
            this.Pe_acum.Name = "Pe_acum";
            // 
            // Pe
            // 
            this.Pe.HeaderText = "Pe()";
            this.Pe.Name = "Pe";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Po() AC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Po()";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Intervalo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvKs
            // 
            this.dgvKs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKs.BackgroundColor = System.Drawing.Color.White;
            this.dgvKs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Pe,
            this.Pe_acum,
            this.diferencia_PoAC_PeAC,
            this.max});
            this.dgvKs.Location = new System.Drawing.Point(7, 451);
            this.dgvKs.Name = "dgvKs";
            this.dgvKs.Size = new System.Drawing.Size(911, 153);
            this.dgvKs.TabIndex = 4;
            // 
            // iteracion
            // 
            this.iteracion.FillWeight = 52.79187F;
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            // 
            // nroAleatorio
            // 
            this.nroAleatorio.FillWeight = 147.2081F;
            this.nroAleatorio.HeaderText = "Nro. Aleatorio";
            this.nroAleatorio.Name = "nroAleatorio";
            this.nroAleatorio.ReadOnly = true;
            // 
            // BondadAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 630);
            this.Controls.Add(this.gbPoisson);
            this.Controls.Add(this.gbExponencial);
            this.Controls.Add(this.gbUniforme);
            this.Controls.Add(this.gbNormal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHipotesisKs);
            this.Controls.Add(this.lblHipotesis);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDistribucion);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.bntPruebaBondad);
            this.Controls.Add(this.dgvNros);
            this.Controls.Add(this.dgvKs);
            this.Controls.Add(this.dgvChiCuadrado);
            this.Controls.Add(this.cmbK);
            this.Controls.Add(this.txtN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(819, 566);
            this.Name = "BondadAjuste";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test de frecuencias";
            this.Load += new System.EventHandler(this.BondadAjuste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.gbUniforme.ResumeLayout(false);
            this.gbUniforme.PerformLayout();
            this.gbPoisson.ResumeLayout(false);
            this.gbPoisson.PerformLayout();
            this.gbExponencial.ResumeLayout(false);
            this.gbExponencial.PerformLayout();
            this.gbNormal.ResumeLayout(false);
            this.gbNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cmbK;
        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadisticoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcum;
        private System.Windows.Forms.Button bntPruebaBondad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDistribucion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblHipotesis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHipotesisKs;
        private System.Windows.Forms.GroupBox gbUniforme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox gbPoisson;
        private System.Windows.Forms.Label txtLambdaPoisson;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbExponencial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLambdaExponencial;
        private System.Windows.Forms.GroupBox gbNormal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMediaNormal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDesviacionNormal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencia_PoAC_PeAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pe_acum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvKs;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAleatorio;
    }
}