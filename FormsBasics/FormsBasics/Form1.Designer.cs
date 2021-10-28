
namespace FormsBasics
{
    partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkBlue = new System.Windows.Forms.CheckBox();
            this.chkMagenta = new System.Windows.Forms.CheckBox();
            this.chkCyan = new System.Windows.Forms.CheckBox();
            this.chkYellow = new System.Windows.Forms.CheckBox();
            this.chkOrange = new System.Windows.Forms.CheckBox();
            this.chkBrown = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlanetas = new System.Windows.Forms.TextBox();
            this.radMercurio = new System.Windows.Forms.RadioButton();
            this.radVenus = new System.Windows.Forms.RadioButton();
            this.radTierra = new System.Windows.Forms.RadioButton();
            this.radMarte = new System.Windows.Forms.RadioButton();
            this.radJupiter = new System.Windows.Forms.RadioButton();
            this.radSaturno = new System.Windows.Forms.RadioButton();
            this.radNeptuno = new System.Windows.Forms.RadioButton();
            this.radUrano = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrillo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(334, 8);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 35);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test:";
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(83, 12);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(245, 26);
            this.txtTest.TabIndex = 2;
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRed.Location = new System.Drawing.Point(83, 120);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(49, 19);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(83, 74);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(339, 26);
            this.txtColor.TabIndex = 2;
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreen.Location = new System.Drawing.Point(83, 145);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(60, 19);
            this.chkGreen.TabIndex = 3;
            this.chkGreen.Text = "Green";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkBlue
            // 
            this.chkBlue.AutoSize = true;
            this.chkBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlue.Location = new System.Drawing.Point(83, 170);
            this.chkBlue.Name = "chkBlue";
            this.chkBlue.Size = new System.Drawing.Size(51, 19);
            this.chkBlue.TabIndex = 3;
            this.chkBlue.Text = "Blue";
            this.chkBlue.UseVisualStyleBackColor = true;
            this.chkBlue.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkMagenta
            // 
            this.chkMagenta.AutoSize = true;
            this.chkMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMagenta.Location = new System.Drawing.Point(83, 195);
            this.chkMagenta.Name = "chkMagenta";
            this.chkMagenta.Size = new System.Drawing.Size(75, 19);
            this.chkMagenta.TabIndex = 3;
            this.chkMagenta.Text = "Magenta";
            this.chkMagenta.UseVisualStyleBackColor = true;
            this.chkMagenta.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkCyan
            // 
            this.chkCyan.AutoSize = true;
            this.chkCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCyan.Location = new System.Drawing.Point(215, 120);
            this.chkCyan.Name = "chkCyan";
            this.chkCyan.Size = new System.Drawing.Size(53, 19);
            this.chkCyan.TabIndex = 3;
            this.chkCyan.Text = "Cyan";
            this.chkCyan.UseVisualStyleBackColor = true;
            this.chkCyan.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkYellow
            // 
            this.chkYellow.AutoSize = true;
            this.chkYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYellow.Location = new System.Drawing.Point(215, 145);
            this.chkYellow.Name = "chkYellow";
            this.chkYellow.Size = new System.Drawing.Size(62, 19);
            this.chkYellow.TabIndex = 3;
            this.chkYellow.Text = "Yellow";
            this.chkYellow.UseVisualStyleBackColor = true;
            this.chkYellow.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkOrange
            // 
            this.chkOrange.AutoSize = true;
            this.chkOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrange.Location = new System.Drawing.Point(215, 170);
            this.chkOrange.Name = "chkOrange";
            this.chkOrange.Size = new System.Drawing.Size(67, 19);
            this.chkOrange.TabIndex = 3;
            this.chkOrange.Text = "Orange";
            this.chkOrange.UseVisualStyleBackColor = true;
            this.chkOrange.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkBrown
            // 
            this.chkBrown.AutoSize = true;
            this.chkBrown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrown.Location = new System.Drawing.Point(215, 195);
            this.chkBrown.Name = "chkBrown";
            this.chkBrown.Size = new System.Drawing.Size(61, 19);
            this.chkBrown.TabIndex = 3;
            this.chkBrown.Text = "Brown";
            this.chkBrown.UseVisualStyleBackColor = true;
            this.chkBrown.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Planeta:";
            // 
            // txtPlanetas
            // 
            this.txtPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanetas.Location = new System.Drawing.Point(83, 238);
            this.txtPlanetas.Name = "txtPlanetas";
            this.txtPlanetas.Size = new System.Drawing.Size(339, 26);
            this.txtPlanetas.TabIndex = 2;
            this.txtPlanetas.Text = "Tierra";
            // 
            // radMercurio
            // 
            this.radMercurio.AutoSize = true;
            this.radMercurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMercurio.Location = new System.Drawing.Point(18, 30);
            this.radMercurio.Name = "radMercurio";
            this.radMercurio.Size = new System.Drawing.Size(74, 19);
            this.radMercurio.TabIndex = 4;
            this.radMercurio.Text = "Mercurio";
            this.radMercurio.UseVisualStyleBackColor = true;
            this.radMercurio.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radVenus
            // 
            this.radVenus.AutoSize = true;
            this.radVenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVenus.Location = new System.Drawing.Point(18, 55);
            this.radVenus.Name = "radVenus";
            this.radVenus.Size = new System.Drawing.Size(59, 19);
            this.radVenus.TabIndex = 4;
            this.radVenus.Text = "Venus";
            this.radVenus.UseVisualStyleBackColor = true;
            this.radVenus.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radTierra
            // 
            this.radTierra.AutoSize = true;
            this.radTierra.Checked = true;
            this.radTierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTierra.Location = new System.Drawing.Point(18, 80);
            this.radTierra.Name = "radTierra";
            this.radTierra.Size = new System.Drawing.Size(57, 19);
            this.radTierra.TabIndex = 4;
            this.radTierra.TabStop = true;
            this.radTierra.Text = "Tierra";
            this.radTierra.UseVisualStyleBackColor = true;
            this.radTierra.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radMarte
            // 
            this.radMarte.AutoSize = true;
            this.radMarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMarte.Location = new System.Drawing.Point(18, 105);
            this.radMarte.Name = "radMarte";
            this.radMarte.Size = new System.Drawing.Size(57, 19);
            this.radMarte.TabIndex = 4;
            this.radMarte.Text = "Marte";
            this.radMarte.UseVisualStyleBackColor = true;
            this.radMarte.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radJupiter
            // 
            this.radJupiter.AutoSize = true;
            this.radJupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJupiter.Location = new System.Drawing.Point(137, 30);
            this.radJupiter.Name = "radJupiter";
            this.radJupiter.Size = new System.Drawing.Size(62, 19);
            this.radJupiter.TabIndex = 4;
            this.radJupiter.Text = "Jupiter";
            this.radJupiter.UseVisualStyleBackColor = true;
            this.radJupiter.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radSaturno
            // 
            this.radSaturno.AutoSize = true;
            this.radSaturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSaturno.Location = new System.Drawing.Point(137, 55);
            this.radSaturno.Name = "radSaturno";
            this.radSaturno.Size = new System.Drawing.Size(68, 19);
            this.radSaturno.TabIndex = 4;
            this.radSaturno.Text = "Saturno";
            this.radSaturno.UseVisualStyleBackColor = true;
            this.radSaturno.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radNeptuno
            // 
            this.radNeptuno.AutoSize = true;
            this.radNeptuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNeptuno.Location = new System.Drawing.Point(137, 105);
            this.radNeptuno.Name = "radNeptuno";
            this.radNeptuno.Size = new System.Drawing.Size(72, 19);
            this.radNeptuno.TabIndex = 4;
            this.radNeptuno.Text = "Neptuno";
            this.radNeptuno.UseVisualStyleBackColor = true;
            this.radNeptuno.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // radUrano
            // 
            this.radUrano.AutoSize = true;
            this.radUrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUrano.Location = new System.Drawing.Point(137, 80);
            this.radUrano.Name = "radUrano";
            this.radUrano.Size = new System.Drawing.Size(59, 19);
            this.radUrano.TabIndex = 4;
            this.radUrano.Text = "Urano";
            this.radUrano.UseVisualStyleBackColor = true;
            this.radUrano.CheckedChanged += new System.EventHandler(this.radTierra_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radJupiter);
            this.groupBox1.Controls.Add(this.radMarte);
            this.groupBox1.Controls.Add(this.radUrano);
            this.groupBox1.Controls.Add(this.radTierra);
            this.groupBox1.Controls.Add(this.radSaturno);
            this.groupBox1.Controls.Add(this.radVenus);
            this.groupBox1.Controls.Add(this.radNeptuno);
            this.groupBox1.Controls.Add(this.radMercurio);
            this.groupBox1.Location = new System.Drawing.Point(83, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planetas";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(470, 103);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(171, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Brillo:";
            // 
            // txtBrillo
            // 
            this.txtBrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrillo.Location = new System.Drawing.Point(519, 71);
            this.txtBrillo.Name = "txtBrillo";
            this.txtBrillo.ReadOnly = true;
            this.txtBrillo.Size = new System.Drawing.Size(122, 26);
            this.txtBrillo.TabIndex = 2;
            this.txtBrillo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBrown);
            this.Controls.Add(this.chkMagenta);
            this.Controls.Add(this.chkOrange);
            this.Controls.Add(this.chkBlue);
            this.Controls.Add(this.chkYellow);
            this.Controls.Add(this.chkGreen);
            this.Controls.Add(this.chkCyan);
            this.Controls.Add(this.chkRed);
            this.Controls.Add(this.txtPlanetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrillo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic controls demo v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkBlue;
        private System.Windows.Forms.CheckBox chkMagenta;
        private System.Windows.Forms.CheckBox chkCyan;
        private System.Windows.Forms.CheckBox chkYellow;
        private System.Windows.Forms.CheckBox chkOrange;
        private System.Windows.Forms.CheckBox chkBrown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlanetas;
        private System.Windows.Forms.RadioButton radMercurio;
        private System.Windows.Forms.RadioButton radVenus;
        private System.Windows.Forms.RadioButton radTierra;
        private System.Windows.Forms.RadioButton radMarte;
        private System.Windows.Forms.RadioButton radJupiter;
        private System.Windows.Forms.RadioButton radSaturno;
        private System.Windows.Forms.RadioButton radNeptuno;
        private System.Windows.Forms.RadioButton radUrano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrillo;
    }
}

