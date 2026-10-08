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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.picFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtVelocityResult
            // 
            resources.ApplyResources(this.txtVelocityResult, "txtVelocityResult");
            this.txtVelocityResult.Name = "txtVelocityResult";
            // 
            // btnVelocity
            // 
            resources.ApplyResources(this.btnVelocity, "btnVelocity");
            this.btnVelocity.BackColor = System.Drawing.SystemColors.Info;
            this.btnVelocity.Name = "btnVelocity";
            this.btnVelocity.UseVisualStyleBackColor = false;
            this.btnVelocity.Click += new System.EventHandler(this.btnVelocity_Click);
            // 
            // txtObservedWavelength
            // 
            resources.ApplyResources(this.txtObservedWavelength, "txtObservedWavelength");
            this.txtObservedWavelength.Name = "txtObservedWavelength";
            // 
            // txtRestWavelength
            // 
            resources.ApplyResources(this.txtRestWavelength, "txtRestWavelength");
            this.txtRestWavelength.Name = "txtRestWavelength";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtParallaxAngle
            // 
            resources.ApplyResources(this.txtParallaxAngle, "txtParallaxAngle");
            this.txtParallaxAngle.Name = "txtParallaxAngle";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtCelsius
            // 
            resources.ApplyResources(this.txtCelsius, "txtCelsius");
            this.txtCelsius.Name = "txtCelsius";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txtMass
            // 
            resources.ApplyResources(this.txtMass, "txtMass");
            this.txtMass.Name = "txtMass";
            // 
            // btnDistance
            // 
            resources.ApplyResources(this.btnDistance, "btnDistance");
            this.btnDistance.BackColor = System.Drawing.SystemColors.Info;
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.UseVisualStyleBackColor = false;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnTemperature
            // 
            resources.ApplyResources(this.btnTemperature, "btnTemperature");
            this.btnTemperature.BackColor = System.Drawing.SystemColors.Info;
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.UseVisualStyleBackColor = false;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnEventHorizon
            // 
            resources.ApplyResources(this.btnEventHorizon, "btnEventHorizon");
            this.btnEventHorizon.BackColor = System.Drawing.SystemColors.Info;
            this.btnEventHorizon.Name = "btnEventHorizon";
            this.btnEventHorizon.UseVisualStyleBackColor = false;
            this.btnEventHorizon.Click += new System.EventHandler(this.btnEventHorizon_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtDistanceResult
            // 
            resources.ApplyResources(this.txtDistanceResult, "txtDistanceResult");
            this.txtDistanceResult.Name = "txtDistanceResult";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // txtKelvinResult
            // 
            resources.ApplyResources(this.txtKelvinResult, "txtKelvinResult");
            this.txtKelvinResult.Name = "txtKelvinResult";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // txtEventHorizonResult
            // 
            resources.ApplyResources(this.txtEventHorizonResult, "txtEventHorizonResult");
            this.txtEventHorizonResult.Name = "txtEventHorizonResult";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // dgvHistory
            // 
            resources.ApplyResources(this.dgvHistory, "dgvHistory");
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Name = "dgvHistory";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            resources.GetString("cmbLanguage.Items"),
            resources.GetString("cmbLanguage.Items1"),
            resources.GetString("cmbLanguage.Items2")});
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged_1);
            // 
            // cmbTheme
            // 
            resources.ApplyResources(this.cmbTheme, "cmbTheme");
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            resources.GetString("cmbTheme.Items"),
            resources.GetString("cmbTheme.Items1"),
            resources.GetString("cmbTheme.Items2")});
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // btnColor
            // 
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.BackColor = System.Drawing.SystemColors.Info;
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            resources.ApplyResources(this.btnFont, "btnFont");
            this.btnFont.BackColor = System.Drawing.SystemColors.Info;
            this.btnFont.Name = "btnFont";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // lblServerStatus
            // 
            resources.ApplyResources(this.lblServerStatus, "lblServerStatus");
            this.lblServerStatus.Name = "lblServerStatus";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // panelTopMenu
            // 
            resources.ApplyResources(this.panelTopMenu, "panelTopMenu");
            this.panelTopMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTopMenu.Controls.Add(this.picFlag);
            this.panelTopMenu.Controls.Add(this.btnFont);
            this.panelTopMenu.Controls.Add(this.btnColor);
            this.panelTopMenu.Controls.Add(this.label5);
            this.panelTopMenu.Controls.Add(this.label4);
            this.panelTopMenu.Controls.Add(this.label3);
            this.panelTopMenu.Controls.Add(this.label2);
            this.panelTopMenu.Controls.Add(this.cmbTheme);
            this.panelTopMenu.Controls.Add(this.cmbLanguage);
            this.panelTopMenu.Name = "panelTopMenu";
            // 
            // picFlag
            // 
            resources.ApplyResources(this.picFlag, "picFlag");
            this.picFlag.BackColor = System.Drawing.Color.Transparent;
            this.picFlag.Name = "picFlag";
            this.picFlag.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblServerStatus);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label6;
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
        private PictureBox picFlag;
        private Panel panel1;
        private Label lblServerStatus;
        private Label label7;
        private Panel panelTopMenu;
    }
}
