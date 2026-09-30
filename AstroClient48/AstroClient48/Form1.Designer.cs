using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AstroClient48
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVelocityResult = new System.Windows.Forms.TextBox();
            this.btnVelocity = new System.Windows.Forms.Button();
            this.txtObservedWavelength = new System.Windows.Forms.TextBox();
            this.txtRestWavelength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtParallaxAngle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.btnDistance = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnEventHorizon = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDistanceResult = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKelvinResult = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEventHorizonResult = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.lblServerStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Astronomical Processing";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(87, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Star Velocity";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(299, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Star Distance";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(495, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Temperature Conversion";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(739, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Event Horizon";
            // 
            // txtVelocityResult
            // 
            this.txtVelocityResult.Location = new System.Drawing.Point(50, 284);
            this.txtVelocityResult.Name = "txtVelocityResult";
            this.txtVelocityResult.Size = new System.Drawing.Size(167, 22);
            this.txtVelocityResult.TabIndex = 17;
            // 
            // btnVelocity
            // 
            this.btnVelocity.BackColor = System.Drawing.SystemColors.Info;
            this.btnVelocity.Location = new System.Drawing.Point(48, 235);
            this.btnVelocity.Name = "btnVelocity";
            this.btnVelocity.Size = new System.Drawing.Size(169, 25);
            this.btnVelocity.TabIndex = 18;
            this.btnVelocity.Text = "Calulate Velocity";
            this.btnVelocity.UseVisualStyleBackColor = false;
            this.btnVelocity.Click += new System.EventHandler(this.btnVelocity_Click);
            // 
            // txtObservedWavelength
            // 
            this.txtObservedWavelength.Location = new System.Drawing.Point(49, 166);
            this.txtObservedWavelength.Name = "txtObservedWavelength";
            this.txtObservedWavelength.Size = new System.Drawing.Size(164, 22);
            this.txtObservedWavelength.TabIndex = 19;
            // 
            // txtRestWavelength
            // 
            this.txtRestWavelength.Location = new System.Drawing.Point(50, 207);
            this.txtRestWavelength.Name = "txtRestWavelength";
            this.txtRestWavelength.Size = new System.Drawing.Size(164, 22);
            this.txtRestWavelength.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Observed Wavelength (nm)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rest Wavelength (nm)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Result (m/s)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(272, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Parallax Angle (arcsec)";
            // 
            // txtParallaxAngle
            // 
            this.txtParallaxAngle.Location = new System.Drawing.Point(269, 166);
            this.txtParallaxAngle.Name = "txtParallaxAngle";
            this.txtParallaxAngle.Size = new System.Drawing.Size(164, 22);
            this.txtParallaxAngle.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(493, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Temperature (°C)";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(490, 166);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(164, 22);
            this.txtCelsius.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(710, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Mass (kg)";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(707, 164);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(164, 22);
            this.txtMass.TabIndex = 28;
            // 
            // btnDistance
            // 
            this.btnDistance.BackColor = System.Drawing.SystemColors.Info;
            this.btnDistance.Location = new System.Drawing.Point(264, 235);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(169, 25);
            this.btnDistance.TabIndex = 30;
            this.btnDistance.Text = "Calulate Distance";
            this.btnDistance.UseVisualStyleBackColor = false;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.BackColor = System.Drawing.SystemColors.Info;
            this.btnTemperature.Location = new System.Drawing.Point(490, 235);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(169, 25);
            this.btnTemperature.TabIndex = 31;
            this.btnTemperature.Text = "Calulate Temperature";
            this.btnTemperature.UseVisualStyleBackColor = false;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnEventHorizon
            // 
            this.btnEventHorizon.BackColor = System.Drawing.SystemColors.Info;
            this.btnEventHorizon.Location = new System.Drawing.Point(701, 235);
            this.btnEventHorizon.Name = "btnEventHorizon";
            this.btnEventHorizon.Size = new System.Drawing.Size(169, 25);
            this.btnEventHorizon.TabIndex = 32;
            this.btnEventHorizon.Text = "Calulate Horizon";
            this.btnEventHorizon.UseVisualStyleBackColor = false;
            this.btnEventHorizon.Click += new System.EventHandler(this.btnEventHorizon_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(266, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Distance (parsecs)";
            // 
            // txtDistanceResult
            // 
            this.txtDistanceResult.Location = new System.Drawing.Point(266, 284);
            this.txtDistanceResult.Name = "txtDistanceResult";
            this.txtDistanceResult.Size = new System.Drawing.Size(167, 22);
            this.txtDistanceResult.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(493, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Temperature (K)";
            // 
            // txtKelvinResult
            // 
            this.txtKelvinResult.Location = new System.Drawing.Point(493, 284);
            this.txtKelvinResult.Name = "txtKelvinResult";
            this.txtKelvinResult.Size = new System.Drawing.Size(167, 22);
            this.txtKelvinResult.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(701, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 38;
            this.label18.Text = "Event Horizon (m)";
            // 
            // txtEventHorizonResult
            // 
            this.txtEventHorizonResult.Location = new System.Drawing.Point(701, 284);
            this.txtEventHorizonResult.Name = "txtEventHorizonResult";
            this.txtEventHorizonResult.Size = new System.Drawing.Size(167, 22);
            this.txtEventHorizonResult.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(401, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 23);
            this.label19.TabIndex = 39;
            this.label19.Text = "Calculation History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(50, 343);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(829, 117);
            this.dgvHistory.TabIndex = 40;
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(49, 472);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(828, 22);
            this.lblError.TabIndex = 41;
            this.lblError.Text = "Error Message";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "German"});
            this.cmbLanguage.Location = new System.Drawing.Point(175, 80);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(167, 23);
            this.cmbLanguage.TabIndex = 1;
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Flower",
            "Sky"});
            this.cmbTheme.Location = new System.Drawing.Point(358, 80);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(164, 23);
            this.cmbTheme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Language and Layout ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Theme";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color Dialog";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(750, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Font Dialog";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(537, 77);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(151, 26);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Select Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(703, 77);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(151, 26);
            this.btnFont.TabIndex = 10;
            this.btnFont.Text = "Select Font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(48, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(824, 75);
            this.label20.TabIndex = 43;
            // 
            // picFlag
            // 
            this.picFlag.Location = new System.Drawing.Point(60, 56);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(100, 50);
            this.picFlag.TabIndex = 44;
            this.picFlag.TabStop = false;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(737, 24);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(131, 20);
            this.lblServerStatus.TabIndex = 45;
            this.lblServerStatus.Text = "Ｓｅｒｖｅｒ：　ｏｎ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 508);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEventHorizonResult);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtKelvinResult);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDistanceResult);
            this.Controls.Add(this.btnEventHorizon);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.btnDistance);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtParallaxAngle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRestWavelength);
            this.Controls.Add(this.txtObservedWavelength);
            this.Controls.Add(this.btnVelocity);
            this.Controls.Add(this.txtVelocityResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox picFlag;
        private Panel panel1;
        private Label lblServerStatus;
    }
}
