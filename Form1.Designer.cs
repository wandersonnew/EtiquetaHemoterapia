namespace ImpressaoZebra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            solucao = new TextBox();
            label12 = new Label();
            dtnasc = new MaskedTextBox();
            hora = new MaskedTextBox();
            data = new MaskedTextBox();
            composicao = new TextBox();
            vazao = new TextBox();
            matricula = new TextBox();
            nmmae = new TextBox();
            protocolo = new TextBox();
            nmpaciente = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbmatpes = new TextBox();
            btnbuscar = new Button();
            button2 = new Button();
            listimpressoras = new ComboBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(solucao);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtnasc);
            groupBox1.Controls.Add(hora);
            groupBox1.Controls.Add(data);
            groupBox1.Controls.Add(composicao);
            groupBox1.Controls.Add(vazao);
            groupBox1.Controls.Add(matricula);
            groupBox1.Controls.Add(nmmae);
            groupBox1.Controls.Add(protocolo);
            groupBox1.Controls.Add(nmpaciente);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Paciente";
            // 
            // solucao
            // 
            solucao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            solucao.Location = new Point(134, 305);
            solucao.Name = "solucao";
            solucao.Size = new Size(611, 29);
            solucao.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(19, 309);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 13;
            label12.Text = "Solução:";
            label12.Click += label12_Click;
            // 
            // dtnasc
            // 
            dtnasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtnasc.Location = new Point(493, 104);
            dtnasc.Mask = "00/00/0000";
            dtnasc.Name = "dtnasc";
            dtnasc.Size = new Size(252, 29);
            dtnasc.TabIndex = 7;
            dtnasc.ValidatingType = typeof(DateTime);
            // 
            // hora
            // 
            hora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hora.Location = new Point(493, 220);
            hora.Mask = "00:00";
            hora.Name = "hora";
            hora.Size = new Size(252, 29);
            hora.TabIndex = 11;
            hora.ValidatingType = typeof(DateTime);
            // 
            // data
            // 
            data.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            data.Location = new Point(134, 220);
            data.Mask = "00/00/0000";
            data.Name = "data";
            data.Size = new Size(252, 29);
            data.TabIndex = 10;
            data.ValidatingType = typeof(DateTime);
            // 
            // composicao
            // 
            composicao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            composicao.Location = new Point(134, 142);
            composicao.Name = "composicao";
            composicao.Size = new Size(611, 29);
            composicao.TabIndex = 8;
            // 
            // vazao
            // 
            vazao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vazao.Location = new Point(134, 182);
            vazao.Name = "vazao";
            vazao.Size = new Size(611, 29);
            vazao.TabIndex = 9;
            // 
            // matricula
            // 
            matricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            matricula.Location = new Point(134, 104);
            matricula.Name = "matricula";
            matricula.Size = new Size(252, 29);
            matricula.TabIndex = 6;
            // 
            // nmmae
            // 
            nmmae.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmmae.Location = new Point(134, 62);
            nmmae.Name = "nmmae";
            nmmae.Size = new Size(611, 29);
            nmmae.TabIndex = 5;
            // 
            // protocolo
            // 
            protocolo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            protocolo.Location = new Point(134, 261);
            protocolo.Name = "protocolo";
            protocolo.Size = new Size(611, 29);
            protocolo.TabIndex = 12;
            // 
            // nmpaciente
            // 
            nmpaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmpaciente.Location = new Point(134, 24);
            nmpaciente.Name = "nmpaciente";
            nmpaciente.Size = new Size(611, 29);
            nmpaciente.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(392, 224);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 8;
            label10.Text = "Hora:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 265);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 7;
            label9.Text = "Protocolo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 224);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 6;
            label8.Text = "Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 186);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 5;
            label7.Text = "Vazão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 146);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 4;
            label6.Text = "Composição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(392, 108);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 3;
            label5.Text = "Dt. Nasc.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 108);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Matrícula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 66);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "Mãe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Paciente:";
            // 
            // tbmatpes
            // 
            tbmatpes.Location = new Point(15, 37);
            tbmatpes.Name = "tbmatpes";
            tbmatpes.Size = new Size(382, 23);
            tbmatpes.TabIndex = 1;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.IndianRed;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(15, 69);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(382, 37);
            btnbuscar.TabIndex = 3;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(403, 69);
            button2.Name = "button2";
            button2.Size = new Size(387, 37);
            button2.TabIndex = 13;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listimpressoras
            // 
            listimpressoras.FormattingEnabled = true;
            listimpressoras.Location = new Point(403, 37);
            listimpressoras.Name = "listimpressoras";
            listimpressoras.Size = new Size(385, 23);
            listimpressoras.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(403, 9);
            label11.Name = "label11";
            label11.Size = new Size(111, 25);
            label11.TabIndex = 6;
            label11.Text = "Impressora";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 498);
            Controls.Add(label11);
            Controls.Add(listimpressoras);
            Controls.Add(button2);
            Controls.Add(btnbuscar);
            Controls.Add(tbmatpes);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiqueta Quimioterapia";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MaskedTextBox dtnasc;
        private MaskedTextBox hora;
        private MaskedTextBox data;
        private TextBox composicao;
        private TextBox vazao;
        private TextBox matricula;
        private TextBox nmmae;
        private TextBox protocolo;
        private TextBox nmpaciente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbmatpes;
        private Button btnbuscar;
        private Button button2;
        private ComboBox listimpressoras;
        private Label label11;
        private TextBox solucao;
        private Label label12;
    }
}