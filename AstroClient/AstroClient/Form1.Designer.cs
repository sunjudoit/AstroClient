namespace AstroClient
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
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtVelocityResult = new TextBox();
            btnVelocity = new Button();
            txtObservedWavelength = new TextBox();
            txtRestWavelength = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtParallaxAngle = new TextBox();
            label14 = new Label();
            txtCelsius = new TextBox();
            label15 = new Label();
            txtMass = new TextBox();
            btnDistance = new Button();
            btnTemperature = new Button();
            btnEventHorizon = new Button();
            label16 = new Label();
            txtDistanceResult = new TextBox();
            label17 = new Label();
            txtKelvinResult = new TextBox();
            label18 = new Label();
            txtEventHorizonResult = new TextBox();
            label19 = new Label();
            dgvHistory = new DataGridView();
            lblError = new Label();
            cmbLanguage = new ComboBox();
            cmbTheme = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnColor = new Button();
            btnFont = new Button();
            label20 = new Label();
            pictureBox1 = new PictureBox();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, -1);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 0;
            label1.Text = "Astronomical Processing";
            // 
            // label6
            // 
            label6.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 122);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 11;
            label6.Text = "Star Velocity";
            // 
            // label7
            // 
            label7.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(320, 122);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 12;
            label7.Text = "Star Distance";
            // 
            // label8
            // 
            label8.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(504, 122);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 13;
            label8.Text = "Temperature Conversion";
            // 
            // label9
            // 
            label9.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(739, 122);
            label9.Name = "label9";
            label9.Size = new Size(104, 23);
            label9.TabIndex = 14;
            label9.Text = "Event Horizon";
            // 
            // txtVelocityResult
            // 
            txtVelocityResult.Location = new Point(50, 277);
            txtVelocityResult.Name = "txtVelocityResult";
            txtVelocityResult.Size = new Size(167, 22);
            txtVelocityResult.TabIndex = 17;
            // 
            // btnVelocity
            // 
            btnVelocity.Location = new Point(48, 228);
            btnVelocity.Name = "btnVelocity";
            btnVelocity.Size = new Size(169, 25);
            btnVelocity.TabIndex = 18;
            btnVelocity.Text = "Calulate Velocity";
            btnVelocity.UseVisualStyleBackColor = true;
            // 
            // txtObservedWavelength
            // 
            txtObservedWavelength.Location = new Point(49, 157);
            txtObservedWavelength.Name = "txtObservedWavelength";
            txtObservedWavelength.Size = new Size(164, 22);
            txtObservedWavelength.TabIndex = 19;
            // 
            // txtRestWavelength
            // 
            txtRestWavelength.Location = new Point(50, 200);
            txtRestWavelength.Name = "txtRestWavelength";
            txtRestWavelength.Size = new Size(164, 22);
            txtRestWavelength.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 140);
            label10.Name = "label10";
            label10.Size = new Size(142, 15);
            label10.TabIndex = 21;
            label10.Text = "Observed Wavelength (nm)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(53, 182);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 22;
            label11.Text = "Rest Wavelength (nm)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(50, 259);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 23;
            label12.Text = "Result (m/s)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(272, 140);
            label13.Name = "label13";
            label13.Size = new Size(121, 15);
            label13.TabIndex = 25;
            label13.Text = "Parallax Angle (arcsec)";
            // 
            // txtParallaxAngle
            // 
            txtParallaxAngle.Location = new Point(269, 157);
            txtParallaxAngle.Name = "txtParallaxAngle";
            txtParallaxAngle.Size = new Size(164, 22);
            txtParallaxAngle.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(493, 140);
            label14.Name = "label14";
            label14.Size = new Size(94, 15);
            label14.TabIndex = 27;
            label14.Text = "Temperature (°C)";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(490, 157);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(164, 22);
            txtCelsius.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(710, 138);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 29;
            label15.Text = "Mass (kg)";
            // 
            // txtMass
            // 
            txtMass.Location = new Point(707, 155);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(164, 22);
            txtMass.TabIndex = 28;
            // 
            // btnDistance
            // 
            btnDistance.Location = new Point(264, 228);
            btnDistance.Name = "btnDistance";
            btnDistance.Size = new Size(169, 25);
            btnDistance.TabIndex = 30;
            btnDistance.Text = "Calulate Distance";
            btnDistance.UseVisualStyleBackColor = true;
            // 
            // btnTemperature
            // 
            btnTemperature.Location = new Point(490, 228);
            btnTemperature.Name = "btnTemperature";
            btnTemperature.Size = new Size(169, 25);
            btnTemperature.TabIndex = 31;
            btnTemperature.Text = "Calulate Temperature";
            btnTemperature.UseVisualStyleBackColor = true;
            // 
            // btnEventHorizon
            // 
            btnEventHorizon.Location = new Point(701, 228);
            btnEventHorizon.Name = "btnEventHorizon";
            btnEventHorizon.Size = new Size(169, 25);
            btnEventHorizon.TabIndex = 32;
            btnEventHorizon.Text = "Calulate Horizon";
            btnEventHorizon.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(266, 259);
            label16.Name = "label16";
            label16.Size = new Size(98, 15);
            label16.TabIndex = 34;
            label16.Text = "Distance (parsecs)";
            // 
            // txtDistanceResult
            // 
            txtDistanceResult.Location = new Point(266, 277);
            txtDistanceResult.Name = "txtDistanceResult";
            txtDistanceResult.Size = new Size(167, 22);
            txtDistanceResult.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(493, 259);
            label17.Name = "label17";
            label17.Size = new Size(90, 15);
            label17.TabIndex = 36;
            label17.Text = "Temperature (K)";
            // 
            // txtKelvinResult
            // 
            txtKelvinResult.Location = new Point(493, 277);
            txtKelvinResult.Name = "txtKelvinResult";
            txtKelvinResult.Size = new Size(167, 22);
            txtKelvinResult.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(701, 259);
            label18.Name = "label18";
            label18.Size = new Size(99, 15);
            label18.TabIndex = 38;
            label18.Text = "Event Horizon (m)";
            // 
            // txtEventHorizonResult
            // 
            txtEventHorizonResult.Location = new Point(701, 277);
            txtEventHorizonResult.Name = "txtEventHorizonResult";
            txtEventHorizonResult.Size = new Size(167, 22);
            txtEventHorizonResult.TabIndex = 37;
            // 
            // label19
            // 
            label19.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(401, 317);
            label19.Name = "label19";
            label19.Size = new Size(140, 23);
            label19.TabIndex = 39;
            label19.Text = "Calculation History";
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(50, 343);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(829, 117);
            dgvHistory.TabIndex = 40;
            // 
            // lblError
            // 
            lblError.Location = new Point(49, 472);
            lblError.Name = "lblError";
            lblError.Size = new Size(828, 22);
            lblError.TabIndex = 41;
            lblError.Text = "Error Message";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "English", "French", "German" });
            cmbLanguage.Location = new Point(175, 75);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(167, 23);
            cmbLanguage.TabIndex = 1;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // cmbTheme
            // 
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Items.AddRange(new object[] { "Light", "Dark", "Flower", "Sky" });
            cmbTheme.Location = new Point(358, 75);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(164, 23);
            cmbTheme.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 52);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 5;
            label2.Text = "Language and Layout ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 52);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 6;
            label3.Text = "Theme";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(576, 52);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 7;
            label4.Text = "Color Dialog";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(750, 52);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 8;
            label5.Text = "Font Dialog";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(537, 72);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(151, 26);
            btnColor.TabIndex = 9;
            btnColor.Text = "Select Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(703, 72);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(151, 26);
            btnFont.TabIndex = 10;
            btnFont.Text = "Select Font";
            btnFont.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.BackColor = SystemColors.ActiveCaption;
            label20.Location = new Point(48, 44);
            label20.Name = "label20";
            label20.Size = new Size(824, 75);
            label20.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label21
            // 
            label21.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(737, 24);
            label21.Name = "label21";
            label21.Size = new Size(131, 20);
            label21.TabIndex = 45;
            label21.Text = "Ｓｅｒｖｅｒ：　ｏｎ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 508);
            Controls.Add(label21);
            Controls.Add(pictureBox1);
            Controls.Add(lblError);
            Controls.Add(dgvHistory);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(txtEventHorizonResult);
            Controls.Add(label17);
            Controls.Add(txtKelvinResult);
            Controls.Add(label16);
            Controls.Add(txtDistanceResult);
            Controls.Add(btnEventHorizon);
            Controls.Add(btnTemperature);
            Controls.Add(btnDistance);
            Controls.Add(label15);
            Controls.Add(txtMass);
            Controls.Add(label14);
            Controls.Add(txtCelsius);
            Controls.Add(label13);
            Controls.Add(txtParallaxAngle);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtRestWavelength);
            Controls.Add(txtObservedWavelength);
            Controls.Add(btnVelocity);
            Controls.Add(txtVelocityResult);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbTheme);
            Controls.Add(cmbLanguage);
            Controls.Add(label1);
            Controls.Add(label20);
            Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtVelocityResult;
        private Button btnVelocity;
        private TextBox txtObservedWavelength;
        private TextBox txtRestWavelength;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtParallaxAngle;
        private Label label14;
        private TextBox txtCelsius;
        private Label label15;
        private TextBox txtMass;
        private Button btnDistance;
        private Button btnTemperature;
        private Button btnEventHorizon;
        private Label label16;
        private TextBox txtDistanceResult;
        private Label label17;
        private TextBox txtKelvinResult;
        private Label label18;
        private TextBox txtEventHorizonResult;
        private Label label19;
        private DataGridView dgvHistory;
        private Label lblError;
        private CheckBox checkBox1;
        private ComboBox cmbLanguage;
        private ComboBox cmbTheme;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnColor;
        private Button btnFont;
        private Label label20;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label21;
    }
}
