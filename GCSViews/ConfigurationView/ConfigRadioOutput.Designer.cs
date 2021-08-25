
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigRadioOutput
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rev1 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.BAR1 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.max8 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim8 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min8 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max7 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim7 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min7 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max6 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim6 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min6 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max5 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim5 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min5 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max4 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim4 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min4 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max3 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim3 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min3 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max2 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim2 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min2 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max1 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim1 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rev3 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.BAR2 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.rev2 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.BAR3 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR4 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.rev4 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.BAR5 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR6 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR7 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR8 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.rev5 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev6 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev7 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev8 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev9 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev10 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev11 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev12 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev13 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.rev14 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.func1 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func2 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func3 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func4 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func5 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func6 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func7 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func8 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func9 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func10 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func11 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func12 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func13 = new MissionPlanner.Controls.MavlinkComboBox();
            this.func14 = new MissionPlanner.Controls.MavlinkComboBox();
            this.min1 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BAR9 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR10 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR11 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR12 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.label20 = new System.Windows.Forms.Label();
            this.BAR13 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR14 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.min9 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min10 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min11 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min12 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min13 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.min14 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim9 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim10 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim11 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim12 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim13 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.trim14 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max9 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max10 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max11 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max12 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max13 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.max14 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rev1
            // 
            this.rev1.AutoSize = true;
            this.rev1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev1.Enabled = false;
            this.rev1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev1.Location = new System.Drawing.Point(236, 23);
            this.rev1.Name = "rev1";
            this.rev1.OffValue = 0D;
            this.rev1.OnValue = 1D;
            this.rev1.ParamName = null;
            this.rev1.Size = new System.Drawing.Size(51, 34);
            this.rev1.TabIndex = 123;
            this.rev1.UseVisualStyleBackColor = true;
            // 
            // BAR1
            // 
            this.BAR1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR1.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR1.BorderColor = System.Drawing.Color.Empty;
            this.BAR1.DisplayScale = 1F;
            this.BAR1.DrawLabel = true;
            this.BAR1.Label = "";
            this.BAR1.Location = new System.Drawing.Point(33, 23);
            this.BAR1.Maximum = 2200;
            this.BAR1.maxline = 0;
            this.BAR1.Minimum = 800;
            this.BAR1.minline = 0;
            this.BAR1.Name = "BAR1";
            this.BAR1.Size = new System.Drawing.Size(197, 21);
            this.BAR1.TabIndex = 122;
            this.BAR1.Value = 1500;
            this.BAR1.ValueColor = System.Drawing.Color.Empty;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.max8, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.trim8, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.min8, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.max7, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.trim7, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.min7, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.max6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.trim6, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.min6, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.max5, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.trim5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.min5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.max4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.trim4, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.min4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.max3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.trim3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.min3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.max2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.trim2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.min2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.max1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.trim1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rev3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BAR1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rev1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BAR2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rev2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BAR3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BAR4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rev4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BAR5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BAR6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BAR7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.BAR8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.rev5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.rev6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.rev7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.rev8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.rev9, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.rev10, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.rev11, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.rev12, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.rev13, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.rev14, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.func1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.func2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.func3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.func4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.func5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.func6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.func7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.func8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.func9, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.func10, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.func11, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.func12, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.func13, 3, 13);
            this.tableLayoutPanel1.Controls.Add(this.func14, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.min1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.BAR9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.BAR10, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.BAR11, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.BAR12, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.BAR13, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.BAR14, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.min9, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.min10, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.min11, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.min12, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.min13, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.min14, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.trim9, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.trim10, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.trim11, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.trim12, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.trim13, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.trim14, 5, 14);
            this.tableLayoutPanel1.Controls.Add(this.max9, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.max10, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.max11, 6, 11);
            this.tableLayoutPanel1.Controls.Add(this.max12, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.max13, 6, 13);
            this.tableLayoutPanel1.Controls.Add(this.max14, 6, 14);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 582);
            this.tableLayoutPanel1.TabIndex = 124;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 540);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 194;
            this.label21.Text = "14";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 460);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 188;
            this.label19.Text = "12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 184;
            this.label15.Text = "#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 183;
            this.label14.Text = "8";
            // 
            // max8
            // 
            this.max8.Enabled = false;
            this.max8.Location = new System.Drawing.Point(503, 303);
            this.max8.Max = 1F;
            this.max8.Min = 0F;
            this.max8.Name = "max8";
            this.max8.ParamName = null;
            this.max8.Size = new System.Drawing.Size(54, 21);
            this.max8.TabIndex = 175;
            // 
            // trim8
            // 
            this.trim8.Enabled = false;
            this.trim8.Location = new System.Drawing.Point(443, 303);
            this.trim8.Max = 1F;
            this.trim8.Min = 0F;
            this.trim8.Name = "trim8";
            this.trim8.ParamName = null;
            this.trim8.Size = new System.Drawing.Size(54, 21);
            this.trim8.TabIndex = 174;
            // 
            // min8
            // 
            this.min8.Enabled = false;
            this.min8.Location = new System.Drawing.Point(383, 303);
            this.min8.Max = 1F;
            this.min8.Min = 0F;
            this.min8.Name = "min8";
            this.min8.ParamName = null;
            this.min8.Size = new System.Drawing.Size(54, 21);
            this.min8.TabIndex = 173;
            // 
            // max7
            // 
            this.max7.Enabled = false;
            this.max7.Location = new System.Drawing.Point(503, 263);
            this.max7.Max = 1F;
            this.max7.Min = 0F;
            this.max7.Name = "max7";
            this.max7.ParamName = null;
            this.max7.Size = new System.Drawing.Size(54, 21);
            this.max7.TabIndex = 172;
            // 
            // trim7
            // 
            this.trim7.Enabled = false;
            this.trim7.Location = new System.Drawing.Point(443, 263);
            this.trim7.Max = 1F;
            this.trim7.Min = 0F;
            this.trim7.Name = "trim7";
            this.trim7.ParamName = null;
            this.trim7.Size = new System.Drawing.Size(54, 21);
            this.trim7.TabIndex = 171;
            // 
            // min7
            // 
            this.min7.Enabled = false;
            this.min7.Location = new System.Drawing.Point(383, 263);
            this.min7.Max = 1F;
            this.min7.Min = 0F;
            this.min7.Name = "min7";
            this.min7.ParamName = null;
            this.min7.Size = new System.Drawing.Size(54, 21);
            this.min7.TabIndex = 170;
            // 
            // max6
            // 
            this.max6.Enabled = false;
            this.max6.Location = new System.Drawing.Point(503, 223);
            this.max6.Max = 1F;
            this.max6.Min = 0F;
            this.max6.Name = "max6";
            this.max6.ParamName = null;
            this.max6.Size = new System.Drawing.Size(54, 21);
            this.max6.TabIndex = 169;
            // 
            // trim6
            // 
            this.trim6.Enabled = false;
            this.trim6.Location = new System.Drawing.Point(443, 223);
            this.trim6.Max = 1F;
            this.trim6.Min = 0F;
            this.trim6.Name = "trim6";
            this.trim6.ParamName = null;
            this.trim6.Size = new System.Drawing.Size(54, 21);
            this.trim6.TabIndex = 168;
            // 
            // min6
            // 
            this.min6.Enabled = false;
            this.min6.Location = new System.Drawing.Point(383, 223);
            this.min6.Max = 1F;
            this.min6.Min = 0F;
            this.min6.Name = "min6";
            this.min6.ParamName = null;
            this.min6.Size = new System.Drawing.Size(54, 21);
            this.min6.TabIndex = 167;
            // 
            // max5
            // 
            this.max5.Enabled = false;
            this.max5.Location = new System.Drawing.Point(503, 183);
            this.max5.Max = 1F;
            this.max5.Min = 0F;
            this.max5.Name = "max5";
            this.max5.ParamName = null;
            this.max5.Size = new System.Drawing.Size(54, 21);
            this.max5.TabIndex = 166;
            // 
            // trim5
            // 
            this.trim5.Enabled = false;
            this.trim5.Location = new System.Drawing.Point(443, 183);
            this.trim5.Max = 1F;
            this.trim5.Min = 0F;
            this.trim5.Name = "trim5";
            this.trim5.ParamName = null;
            this.trim5.Size = new System.Drawing.Size(54, 21);
            this.trim5.TabIndex = 165;
            // 
            // min5
            // 
            this.min5.Enabled = false;
            this.min5.Location = new System.Drawing.Point(383, 183);
            this.min5.Max = 1F;
            this.min5.Min = 0F;
            this.min5.Name = "min5";
            this.min5.ParamName = null;
            this.min5.Size = new System.Drawing.Size(54, 21);
            this.min5.TabIndex = 164;
            // 
            // max4
            // 
            this.max4.Enabled = false;
            this.max4.Location = new System.Drawing.Point(503, 143);
            this.max4.Max = 1F;
            this.max4.Min = 0F;
            this.max4.Name = "max4";
            this.max4.ParamName = null;
            this.max4.Size = new System.Drawing.Size(54, 21);
            this.max4.TabIndex = 163;
            // 
            // trim4
            // 
            this.trim4.Enabled = false;
            this.trim4.Location = new System.Drawing.Point(443, 143);
            this.trim4.Max = 1F;
            this.trim4.Min = 0F;
            this.trim4.Name = "trim4";
            this.trim4.ParamName = null;
            this.trim4.Size = new System.Drawing.Size(54, 21);
            this.trim4.TabIndex = 162;
            // 
            // min4
            // 
            this.min4.Enabled = false;
            this.min4.Location = new System.Drawing.Point(383, 143);
            this.min4.Max = 1F;
            this.min4.Min = 0F;
            this.min4.Name = "min4";
            this.min4.ParamName = null;
            this.min4.Size = new System.Drawing.Size(54, 21);
            this.min4.TabIndex = 161;
            // 
            // max3
            // 
            this.max3.Enabled = false;
            this.max3.Location = new System.Drawing.Point(503, 103);
            this.max3.Max = 1F;
            this.max3.Min = 0F;
            this.max3.Name = "max3";
            this.max3.ParamName = null;
            this.max3.Size = new System.Drawing.Size(54, 21);
            this.max3.TabIndex = 160;
            // 
            // trim3
            // 
            this.trim3.Enabled = false;
            this.trim3.Location = new System.Drawing.Point(443, 103);
            this.trim3.Max = 1F;
            this.trim3.Min = 0F;
            this.trim3.Name = "trim3";
            this.trim3.ParamName = null;
            this.trim3.Size = new System.Drawing.Size(54, 21);
            this.trim3.TabIndex = 159;
            // 
            // min3
            // 
            this.min3.Enabled = false;
            this.min3.Location = new System.Drawing.Point(383, 103);
            this.min3.Max = 1F;
            this.min3.Min = 0F;
            this.min3.Name = "min3";
            this.min3.ParamName = null;
            this.min3.Size = new System.Drawing.Size(54, 21);
            this.min3.TabIndex = 158;
            // 
            // max2
            // 
            this.max2.Enabled = false;
            this.max2.Location = new System.Drawing.Point(503, 63);
            this.max2.Max = 1F;
            this.max2.Min = 0F;
            this.max2.Name = "max2";
            this.max2.ParamName = null;
            this.max2.Size = new System.Drawing.Size(54, 21);
            this.max2.TabIndex = 157;
            // 
            // trim2
            // 
            this.trim2.Enabled = false;
            this.trim2.Location = new System.Drawing.Point(443, 63);
            this.trim2.Max = 1F;
            this.trim2.Min = 0F;
            this.trim2.Name = "trim2";
            this.trim2.ParamName = null;
            this.trim2.Size = new System.Drawing.Size(54, 21);
            this.trim2.TabIndex = 156;
            // 
            // min2
            // 
            this.min2.Enabled = false;
            this.min2.Location = new System.Drawing.Point(383, 63);
            this.min2.Max = 1F;
            this.min2.Min = 0F;
            this.min2.Name = "min2";
            this.min2.ParamName = null;
            this.min2.Size = new System.Drawing.Size(54, 21);
            this.min2.TabIndex = 155;
            // 
            // max1
            // 
            this.max1.Enabled = false;
            this.max1.Location = new System.Drawing.Point(503, 23);
            this.max1.Max = 1F;
            this.max1.Min = 0F;
            this.max1.Name = "max1";
            this.max1.ParamName = null;
            this.max1.Size = new System.Drawing.Size(54, 21);
            this.max1.TabIndex = 154;
            // 
            // trim1
            // 
            this.trim1.Enabled = false;
            this.trim1.Location = new System.Drawing.Point(443, 23);
            this.trim1.Max = 1F;
            this.trim1.Min = 0F;
            this.trim1.Name = "trim1";
            this.trim1.ParamName = null;
            this.trim1.Size = new System.Drawing.Size(54, 21);
            this.trim1.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 152;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 151;
            this.label5.Text = "Trim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 150;
            this.label4.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 149;
            this.label3.Text = "Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 148;
            this.label2.Text = "Reverse";
            // 
            // rev3
            // 
            this.rev3.AutoSize = true;
            this.rev3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev3.Enabled = false;
            this.rev3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev3.Location = new System.Drawing.Point(236, 103);
            this.rev3.Name = "rev3";
            this.rev3.OffValue = 0D;
            this.rev3.OnValue = 1D;
            this.rev3.ParamName = null;
            this.rev3.Size = new System.Drawing.Size(51, 34);
            this.rev3.TabIndex = 133;
            this.rev3.UseVisualStyleBackColor = true;
            // 
            // BAR2
            // 
            this.BAR2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR2.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR2.BorderColor = System.Drawing.Color.Empty;
            this.BAR2.DisplayScale = 1F;
            this.BAR2.DrawLabel = true;
            this.BAR2.Label = "";
            this.BAR2.Location = new System.Drawing.Point(33, 63);
            this.BAR2.Maximum = 2200;
            this.BAR2.maxline = 0;
            this.BAR2.Minimum = 800;
            this.BAR2.minline = 0;
            this.BAR2.Name = "BAR2";
            this.BAR2.Size = new System.Drawing.Size(197, 21);
            this.BAR2.TabIndex = 124;
            this.BAR2.Value = 1500;
            this.BAR2.ValueColor = System.Drawing.Color.Empty;
            // 
            // rev2
            // 
            this.rev2.AutoSize = true;
            this.rev2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev2.Enabled = false;
            this.rev2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev2.Location = new System.Drawing.Point(236, 63);
            this.rev2.Name = "rev2";
            this.rev2.OffValue = 0D;
            this.rev2.OnValue = 1D;
            this.rev2.ParamName = null;
            this.rev2.Size = new System.Drawing.Size(51, 34);
            this.rev2.TabIndex = 132;
            this.rev2.UseVisualStyleBackColor = true;
            // 
            // BAR3
            // 
            this.BAR3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR3.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR3.BorderColor = System.Drawing.Color.Empty;
            this.BAR3.DisplayScale = 1F;
            this.BAR3.DrawLabel = true;
            this.BAR3.Label = "";
            this.BAR3.Location = new System.Drawing.Point(33, 103);
            this.BAR3.Maximum = 2200;
            this.BAR3.maxline = 0;
            this.BAR3.Minimum = 800;
            this.BAR3.minline = 0;
            this.BAR3.Name = "BAR3";
            this.BAR3.Size = new System.Drawing.Size(197, 21);
            this.BAR3.TabIndex = 128;
            this.BAR3.Value = 1500;
            this.BAR3.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR4
            // 
            this.BAR4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR4.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR4.BorderColor = System.Drawing.Color.Empty;
            this.BAR4.DisplayScale = 1F;
            this.BAR4.DrawLabel = true;
            this.BAR4.Label = "";
            this.BAR4.Location = new System.Drawing.Point(33, 143);
            this.BAR4.Maximum = 2200;
            this.BAR4.maxline = 0;
            this.BAR4.Minimum = 800;
            this.BAR4.minline = 0;
            this.BAR4.Name = "BAR4";
            this.BAR4.Size = new System.Drawing.Size(197, 21);
            this.BAR4.TabIndex = 127;
            this.BAR4.Value = 1500;
            this.BAR4.ValueColor = System.Drawing.Color.Empty;
            // 
            // rev4
            // 
            this.rev4.AutoSize = true;
            this.rev4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev4.Enabled = false;
            this.rev4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev4.Location = new System.Drawing.Point(236, 143);
            this.rev4.Name = "rev4";
            this.rev4.OffValue = 0D;
            this.rev4.OnValue = 1D;
            this.rev4.ParamName = null;
            this.rev4.Size = new System.Drawing.Size(51, 34);
            this.rev4.TabIndex = 135;
            this.rev4.UseVisualStyleBackColor = true;
            // 
            // BAR5
            // 
            this.BAR5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR5.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR5.BorderColor = System.Drawing.Color.Empty;
            this.BAR5.DisplayScale = 1F;
            this.BAR5.DrawLabel = true;
            this.BAR5.Label = "";
            this.BAR5.Location = new System.Drawing.Point(33, 183);
            this.BAR5.Maximum = 2200;
            this.BAR5.maxline = 0;
            this.BAR5.Minimum = 800;
            this.BAR5.minline = 0;
            this.BAR5.Name = "BAR5";
            this.BAR5.Size = new System.Drawing.Size(197, 21);
            this.BAR5.TabIndex = 126;
            this.BAR5.Value = 1500;
            this.BAR5.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR6
            // 
            this.BAR6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR6.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR6.BorderColor = System.Drawing.Color.Empty;
            this.BAR6.DisplayScale = 1F;
            this.BAR6.DrawLabel = true;
            this.BAR6.Label = "";
            this.BAR6.Location = new System.Drawing.Point(33, 223);
            this.BAR6.Maximum = 2200;
            this.BAR6.maxline = 0;
            this.BAR6.Minimum = 800;
            this.BAR6.minline = 0;
            this.BAR6.Name = "BAR6";
            this.BAR6.Size = new System.Drawing.Size(197, 21);
            this.BAR6.TabIndex = 130;
            this.BAR6.Value = 1500;
            this.BAR6.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR7
            // 
            this.BAR7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR7.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR7.BorderColor = System.Drawing.Color.Empty;
            this.BAR7.DisplayScale = 1F;
            this.BAR7.DrawLabel = true;
            this.BAR7.Label = "";
            this.BAR7.Location = new System.Drawing.Point(33, 263);
            this.BAR7.Maximum = 2200;
            this.BAR7.maxline = 0;
            this.BAR7.Minimum = 800;
            this.BAR7.minline = 0;
            this.BAR7.Name = "BAR7";
            this.BAR7.Size = new System.Drawing.Size(197, 21);
            this.BAR7.TabIndex = 129;
            this.BAR7.Value = 1500;
            this.BAR7.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR8
            // 
            this.BAR8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR8.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR8.BorderColor = System.Drawing.Color.Empty;
            this.BAR8.DisplayScale = 1F;
            this.BAR8.DrawLabel = true;
            this.BAR8.Label = "";
            this.BAR8.Location = new System.Drawing.Point(33, 303);
            this.BAR8.Maximum = 2200;
            this.BAR8.maxline = 0;
            this.BAR8.Minimum = 800;
            this.BAR8.minline = 0;
            this.BAR8.Name = "BAR8";
            this.BAR8.Size = new System.Drawing.Size(197, 25);
            this.BAR8.TabIndex = 125;
            this.BAR8.Value = 1500;
            this.BAR8.ValueColor = System.Drawing.Color.Empty;
            // 
            // rev5
            // 
            this.rev5.AutoSize = true;
            this.rev5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev5.Enabled = false;
            this.rev5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev5.Location = new System.Drawing.Point(236, 183);
            this.rev5.Name = "rev5";
            this.rev5.OffValue = 0D;
            this.rev5.OnValue = 1D;
            this.rev5.ParamName = null;
            this.rev5.Size = new System.Drawing.Size(51, 34);
            this.rev5.TabIndex = 137;
            this.rev5.UseVisualStyleBackColor = true;
            // 
            // rev6
            // 
            this.rev6.AutoSize = true;
            this.rev6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev6.Enabled = false;
            this.rev6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev6.Location = new System.Drawing.Point(236, 223);
            this.rev6.Name = "rev6";
            this.rev6.OffValue = 0D;
            this.rev6.OnValue = 1D;
            this.rev6.ParamName = null;
            this.rev6.Size = new System.Drawing.Size(51, 34);
            this.rev6.TabIndex = 131;
            this.rev6.UseVisualStyleBackColor = true;
            // 
            // rev7
            // 
            this.rev7.AutoSize = true;
            this.rev7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev7.Enabled = false;
            this.rev7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev7.Location = new System.Drawing.Point(236, 263);
            this.rev7.Name = "rev7";
            this.rev7.OffValue = 0D;
            this.rev7.OnValue = 1D;
            this.rev7.ParamName = null;
            this.rev7.Size = new System.Drawing.Size(51, 34);
            this.rev7.TabIndex = 136;
            this.rev7.UseVisualStyleBackColor = true;
            // 
            // rev8
            // 
            this.rev8.AutoSize = true;
            this.rev8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev8.Enabled = false;
            this.rev8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev8.Location = new System.Drawing.Point(236, 303);
            this.rev8.Name = "rev8";
            this.rev8.OffValue = 0D;
            this.rev8.OnValue = 1D;
            this.rev8.ParamName = null;
            this.rev8.Size = new System.Drawing.Size(51, 34);
            this.rev8.TabIndex = 134;
            this.rev8.UseVisualStyleBackColor = true;
            // 
            // rev9
            // 
            this.rev9.AutoSize = true;
            this.rev9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev9.Enabled = false;
            this.rev9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev9.Location = new System.Drawing.Point(236, 343);
            this.rev9.Name = "rev9";
            this.rev9.OffValue = 0D;
            this.rev9.OnValue = 1D;
            this.rev9.ParamName = null;
            this.rev9.Size = new System.Drawing.Size(51, 34);
            this.rev9.TabIndex = 215;
            this.rev9.UseVisualStyleBackColor = true;
            // 
            // rev10
            // 
            this.rev10.AutoSize = true;
            this.rev10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev10.Enabled = false;
            this.rev10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev10.Location = new System.Drawing.Point(236, 383);
            this.rev10.Name = "rev10";
            this.rev10.OffValue = 0D;
            this.rev10.OnValue = 1D;
            this.rev10.ParamName = null;
            this.rev10.Size = new System.Drawing.Size(51, 34);
            this.rev10.TabIndex = 215;
            this.rev10.UseVisualStyleBackColor = true;
            // 
            // rev11
            // 
            this.rev11.AutoSize = true;
            this.rev11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev11.Enabled = false;
            this.rev11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev11.Location = new System.Drawing.Point(236, 423);
            this.rev11.Name = "rev11";
            this.rev11.OffValue = 0D;
            this.rev11.OnValue = 1D;
            this.rev11.ParamName = null;
            this.rev11.Size = new System.Drawing.Size(51, 34);
            this.rev11.TabIndex = 216;
            this.rev11.UseVisualStyleBackColor = true;
            // 
            // rev12
            // 
            this.rev12.AutoSize = true;
            this.rev12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev12.Enabled = false;
            this.rev12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev12.Location = new System.Drawing.Point(236, 463);
            this.rev12.Name = "rev12";
            this.rev12.OffValue = 0D;
            this.rev12.OnValue = 1D;
            this.rev12.ParamName = null;
            this.rev12.Size = new System.Drawing.Size(51, 34);
            this.rev12.TabIndex = 217;
            this.rev12.UseVisualStyleBackColor = true;
            // 
            // rev13
            // 
            this.rev13.AutoSize = true;
            this.rev13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev13.Enabled = false;
            this.rev13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev13.Location = new System.Drawing.Point(236, 503);
            this.rev13.Name = "rev13";
            this.rev13.OffValue = 0D;
            this.rev13.OnValue = 1D;
            this.rev13.ParamName = null;
            this.rev13.Size = new System.Drawing.Size(51, 34);
            this.rev13.TabIndex = 218;
            this.rev13.UseVisualStyleBackColor = true;
            // 
            // rev14
            // 
            this.rev14.AutoSize = true;
            this.rev14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rev14.Enabled = false;
            this.rev14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rev14.Location = new System.Drawing.Point(236, 543);
            this.rev14.Name = "rev14";
            this.rev14.OffValue = 0D;
            this.rev14.OnValue = 1D;
            this.rev14.ParamName = null;
            this.rev14.Size = new System.Drawing.Size(51, 36);
            this.rev14.TabIndex = 219;
            this.rev14.UseVisualStyleBackColor = true;
            // 
            // func1
            // 
            this.func1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func1.Enabled = false;
            this.func1.FormattingEnabled = true;
            this.func1.Location = new System.Drawing.Point(293, 23);
            this.func1.Name = "func1";
            this.func1.ParamName = null;
            this.func1.Size = new System.Drawing.Size(84, 20);
            this.func1.SubControl = null;
            this.func1.TabIndex = 138;
            // 
            // func2
            // 
            this.func2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func2.Enabled = false;
            this.func2.FormattingEnabled = true;
            this.func2.Location = new System.Drawing.Point(293, 63);
            this.func2.Name = "func2";
            this.func2.ParamName = null;
            this.func2.Size = new System.Drawing.Size(84, 20);
            this.func2.SubControl = null;
            this.func2.TabIndex = 139;
            // 
            // func3
            // 
            this.func3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func3.Enabled = false;
            this.func3.FormattingEnabled = true;
            this.func3.Location = new System.Drawing.Point(293, 103);
            this.func3.Name = "func3";
            this.func3.ParamName = null;
            this.func3.Size = new System.Drawing.Size(84, 20);
            this.func3.SubControl = null;
            this.func3.TabIndex = 140;
            // 
            // func4
            // 
            this.func4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func4.Enabled = false;
            this.func4.FormattingEnabled = true;
            this.func4.Location = new System.Drawing.Point(293, 143);
            this.func4.Name = "func4";
            this.func4.ParamName = null;
            this.func4.Size = new System.Drawing.Size(84, 20);
            this.func4.SubControl = null;
            this.func4.TabIndex = 141;
            // 
            // func5
            // 
            this.func5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func5.Enabled = false;
            this.func5.FormattingEnabled = true;
            this.func5.Location = new System.Drawing.Point(293, 183);
            this.func5.Name = "func5";
            this.func5.ParamName = null;
            this.func5.Size = new System.Drawing.Size(84, 20);
            this.func5.SubControl = null;
            this.func5.TabIndex = 142;
            // 
            // func6
            // 
            this.func6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func6.Enabled = false;
            this.func6.FormattingEnabled = true;
            this.func6.Location = new System.Drawing.Point(293, 223);
            this.func6.Name = "func6";
            this.func6.ParamName = null;
            this.func6.Size = new System.Drawing.Size(84, 20);
            this.func6.SubControl = null;
            this.func6.TabIndex = 143;
            // 
            // func7
            // 
            this.func7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func7.Enabled = false;
            this.func7.FormattingEnabled = true;
            this.func7.Location = new System.Drawing.Point(293, 263);
            this.func7.Name = "func7";
            this.func7.ParamName = null;
            this.func7.Size = new System.Drawing.Size(84, 20);
            this.func7.SubControl = null;
            this.func7.TabIndex = 144;
            // 
            // func8
            // 
            this.func8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func8.Enabled = false;
            this.func8.FormattingEnabled = true;
            this.func8.Location = new System.Drawing.Point(293, 303);
            this.func8.Name = "func8";
            this.func8.ParamName = null;
            this.func8.Size = new System.Drawing.Size(84, 20);
            this.func8.SubControl = null;
            this.func8.TabIndex = 145;
            // 
            // func9
            // 
            this.func9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func9.Enabled = false;
            this.func9.FormattingEnabled = true;
            this.func9.Location = new System.Drawing.Point(293, 343);
            this.func9.Name = "func9";
            this.func9.ParamName = null;
            this.func9.Size = new System.Drawing.Size(84, 20);
            this.func9.SubControl = null;
            this.func9.TabIndex = 219;
            // 
            // func10
            // 
            this.func10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func10.Enabled = false;
            this.func10.FormattingEnabled = true;
            this.func10.Location = new System.Drawing.Point(293, 383);
            this.func10.Name = "func10";
            this.func10.ParamName = null;
            this.func10.Size = new System.Drawing.Size(84, 20);
            this.func10.SubControl = null;
            this.func10.TabIndex = 220;
            // 
            // func11
            // 
            this.func11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func11.Enabled = false;
            this.func11.FormattingEnabled = true;
            this.func11.Location = new System.Drawing.Point(293, 423);
            this.func11.Name = "func11";
            this.func11.ParamName = null;
            this.func11.Size = new System.Drawing.Size(84, 20);
            this.func11.SubControl = null;
            this.func11.TabIndex = 221;
            // 
            // func12
            // 
            this.func12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func12.Enabled = false;
            this.func12.FormattingEnabled = true;
            this.func12.Location = new System.Drawing.Point(293, 463);
            this.func12.Name = "func12";
            this.func12.ParamName = null;
            this.func12.Size = new System.Drawing.Size(84, 20);
            this.func12.SubControl = null;
            this.func12.TabIndex = 222;
            // 
            // func13
            // 
            this.func13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func13.Enabled = false;
            this.func13.FormattingEnabled = true;
            this.func13.Location = new System.Drawing.Point(293, 503);
            this.func13.Name = "func13";
            this.func13.ParamName = null;
            this.func13.Size = new System.Drawing.Size(84, 20);
            this.func13.SubControl = null;
            this.func13.TabIndex = 223;
            // 
            // func14
            // 
            this.func14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.func14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.func14.Enabled = false;
            this.func14.FormattingEnabled = true;
            this.func14.Location = new System.Drawing.Point(293, 543);
            this.func14.Name = "func14";
            this.func14.ParamName = null;
            this.func14.Size = new System.Drawing.Size(84, 20);
            this.func14.SubControl = null;
            this.func14.TabIndex = 224;
            // 
            // min1
            // 
            this.min1.Enabled = false;
            this.min1.Location = new System.Drawing.Point(383, 23);
            this.min1.Max = 1F;
            this.min1.Min = 0F;
            this.min1.Name = "min1";
            this.min1.ParamName = null;
            this.min1.Size = new System.Drawing.Size(54, 21);
            this.min1.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 147;
            this.label1.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 176;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 177;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 178;
            this.label9.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 179;
            this.label10.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 180;
            this.label11.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 181;
            this.label12.Text = "6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 182;
            this.label13.Text = "7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 185;
            this.label16.Text = "9";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 380);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 186;
            this.label18.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 420);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 187;
            this.label17.Text = "11";
            // 
            // BAR9
            // 
            this.BAR9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR9.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR9.BorderColor = System.Drawing.Color.Empty;
            this.BAR9.DisplayScale = 1F;
            this.BAR9.DrawLabel = true;
            this.BAR9.Label = "";
            this.BAR9.Location = new System.Drawing.Point(33, 343);
            this.BAR9.Maximum = 2200;
            this.BAR9.maxline = 0;
            this.BAR9.Minimum = 800;
            this.BAR9.minline = 0;
            this.BAR9.Name = "BAR9";
            this.BAR9.Size = new System.Drawing.Size(197, 25);
            this.BAR9.TabIndex = 189;
            this.BAR9.Value = 1500;
            this.BAR9.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR10
            // 
            this.BAR10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR10.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR10.BorderColor = System.Drawing.Color.Empty;
            this.BAR10.DisplayScale = 1F;
            this.BAR10.DrawLabel = true;
            this.BAR10.Label = "";
            this.BAR10.Location = new System.Drawing.Point(33, 383);
            this.BAR10.Maximum = 2200;
            this.BAR10.maxline = 0;
            this.BAR10.Minimum = 800;
            this.BAR10.minline = 0;
            this.BAR10.Name = "BAR10";
            this.BAR10.Size = new System.Drawing.Size(197, 25);
            this.BAR10.TabIndex = 190;
            this.BAR10.Value = 1500;
            this.BAR10.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR11
            // 
            this.BAR11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR11.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR11.BorderColor = System.Drawing.Color.Empty;
            this.BAR11.DisplayScale = 1F;
            this.BAR11.DrawLabel = true;
            this.BAR11.Label = "";
            this.BAR11.Location = new System.Drawing.Point(33, 423);
            this.BAR11.Maximum = 2200;
            this.BAR11.maxline = 0;
            this.BAR11.Minimum = 800;
            this.BAR11.minline = 0;
            this.BAR11.Name = "BAR11";
            this.BAR11.Size = new System.Drawing.Size(197, 25);
            this.BAR11.TabIndex = 191;
            this.BAR11.Value = 1500;
            this.BAR11.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR12
            // 
            this.BAR12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR12.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR12.BorderColor = System.Drawing.Color.Empty;
            this.BAR12.DisplayScale = 1F;
            this.BAR12.DrawLabel = true;
            this.BAR12.Label = "";
            this.BAR12.Location = new System.Drawing.Point(33, 463);
            this.BAR12.Maximum = 2200;
            this.BAR12.maxline = 0;
            this.BAR12.Minimum = 800;
            this.BAR12.minline = 0;
            this.BAR12.Name = "BAR12";
            this.BAR12.Size = new System.Drawing.Size(197, 25);
            this.BAR12.TabIndex = 192;
            this.BAR12.Value = 1500;
            this.BAR12.ValueColor = System.Drawing.Color.Empty;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 500);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 193;
            this.label20.Text = "13";
            // 
            // BAR13
            // 
            this.BAR13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR13.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR13.BorderColor = System.Drawing.Color.Empty;
            this.BAR13.DisplayScale = 1F;
            this.BAR13.DrawLabel = true;
            this.BAR13.Label = "";
            this.BAR13.Location = new System.Drawing.Point(33, 503);
            this.BAR13.Maximum = 2200;
            this.BAR13.maxline = 0;
            this.BAR13.Minimum = 800;
            this.BAR13.minline = 0;
            this.BAR13.Name = "BAR13";
            this.BAR13.Size = new System.Drawing.Size(197, 25);
            this.BAR13.TabIndex = 195;
            this.BAR13.Value = 1500;
            this.BAR13.ValueColor = System.Drawing.Color.Empty;
            // 
            // BAR14
            // 
            this.BAR14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR14.BackgroundColor = System.Drawing.Color.Empty;
            this.BAR14.BorderColor = System.Drawing.Color.Empty;
            this.BAR14.DisplayScale = 1F;
            this.BAR14.DrawLabel = true;
            this.BAR14.Label = "";
            this.BAR14.Location = new System.Drawing.Point(33, 543);
            this.BAR14.Maximum = 2200;
            this.BAR14.maxline = 0;
            this.BAR14.Minimum = 800;
            this.BAR14.minline = 0;
            this.BAR14.Name = "BAR14";
            this.BAR14.Size = new System.Drawing.Size(197, 25);
            this.BAR14.TabIndex = 196;
            this.BAR14.Value = 1500;
            this.BAR14.ValueColor = System.Drawing.Color.Empty;
            // 
            // min9
            // 
            this.min9.Enabled = false;
            this.min9.Location = new System.Drawing.Point(383, 343);
            this.min9.Max = 1F;
            this.min9.Min = 0F;
            this.min9.Name = "min9";
            this.min9.ParamName = null;
            this.min9.Size = new System.Drawing.Size(54, 21);
            this.min9.TabIndex = 197;
            // 
            // min10
            // 
            this.min10.Enabled = false;
            this.min10.Location = new System.Drawing.Point(383, 383);
            this.min10.Max = 1F;
            this.min10.Min = 0F;
            this.min10.Name = "min10";
            this.min10.ParamName = null;
            this.min10.Size = new System.Drawing.Size(54, 21);
            this.min10.TabIndex = 198;
            // 
            // min11
            // 
            this.min11.Enabled = false;
            this.min11.Location = new System.Drawing.Point(383, 423);
            this.min11.Max = 1F;
            this.min11.Min = 0F;
            this.min11.Name = "min11";
            this.min11.ParamName = null;
            this.min11.Size = new System.Drawing.Size(54, 21);
            this.min11.TabIndex = 199;
            // 
            // min12
            // 
            this.min12.Enabled = false;
            this.min12.Location = new System.Drawing.Point(383, 463);
            this.min12.Max = 1F;
            this.min12.Min = 0F;
            this.min12.Name = "min12";
            this.min12.ParamName = null;
            this.min12.Size = new System.Drawing.Size(54, 21);
            this.min12.TabIndex = 200;
            // 
            // min13
            // 
            this.min13.Enabled = false;
            this.min13.Location = new System.Drawing.Point(383, 503);
            this.min13.Max = 1F;
            this.min13.Min = 0F;
            this.min13.Name = "min13";
            this.min13.ParamName = null;
            this.min13.Size = new System.Drawing.Size(54, 21);
            this.min13.TabIndex = 201;
            // 
            // min14
            // 
            this.min14.Enabled = false;
            this.min14.Location = new System.Drawing.Point(383, 543);
            this.min14.Max = 1F;
            this.min14.Min = 0F;
            this.min14.Name = "min14";
            this.min14.ParamName = null;
            this.min14.Size = new System.Drawing.Size(54, 21);
            this.min14.TabIndex = 202;
            // 
            // trim9
            // 
            this.trim9.Enabled = false;
            this.trim9.Location = new System.Drawing.Point(443, 343);
            this.trim9.Max = 1F;
            this.trim9.Min = 0F;
            this.trim9.Name = "trim9";
            this.trim9.ParamName = null;
            this.trim9.Size = new System.Drawing.Size(54, 21);
            this.trim9.TabIndex = 203;
            // 
            // trim10
            // 
            this.trim10.Enabled = false;
            this.trim10.Location = new System.Drawing.Point(443, 383);
            this.trim10.Max = 1F;
            this.trim10.Min = 0F;
            this.trim10.Name = "trim10";
            this.trim10.ParamName = null;
            this.trim10.Size = new System.Drawing.Size(54, 21);
            this.trim10.TabIndex = 204;
            // 
            // trim11
            // 
            this.trim11.Enabled = false;
            this.trim11.Location = new System.Drawing.Point(443, 423);
            this.trim11.Max = 1F;
            this.trim11.Min = 0F;
            this.trim11.Name = "trim11";
            this.trim11.ParamName = null;
            this.trim11.Size = new System.Drawing.Size(54, 21);
            this.trim11.TabIndex = 205;
            // 
            // trim12
            // 
            this.trim12.Enabled = false;
            this.trim12.Location = new System.Drawing.Point(443, 463);
            this.trim12.Max = 1F;
            this.trim12.Min = 0F;
            this.trim12.Name = "trim12";
            this.trim12.ParamName = null;
            this.trim12.Size = new System.Drawing.Size(54, 21);
            this.trim12.TabIndex = 206;
            // 
            // trim13
            // 
            this.trim13.Enabled = false;
            this.trim13.Location = new System.Drawing.Point(443, 503);
            this.trim13.Max = 1F;
            this.trim13.Min = 0F;
            this.trim13.Name = "trim13";
            this.trim13.ParamName = null;
            this.trim13.Size = new System.Drawing.Size(54, 21);
            this.trim13.TabIndex = 207;
            // 
            // trim14
            // 
            this.trim14.Enabled = false;
            this.trim14.Location = new System.Drawing.Point(443, 543);
            this.trim14.Max = 1F;
            this.trim14.Min = 0F;
            this.trim14.Name = "trim14";
            this.trim14.ParamName = null;
            this.trim14.Size = new System.Drawing.Size(54, 21);
            this.trim14.TabIndex = 208;
            // 
            // max9
            // 
            this.max9.Enabled = false;
            this.max9.Location = new System.Drawing.Point(503, 343);
            this.max9.Max = 1F;
            this.max9.Min = 0F;
            this.max9.Name = "max9";
            this.max9.ParamName = null;
            this.max9.Size = new System.Drawing.Size(54, 21);
            this.max9.TabIndex = 209;
            // 
            // max10
            // 
            this.max10.Enabled = false;
            this.max10.Location = new System.Drawing.Point(503, 383);
            this.max10.Max = 1F;
            this.max10.Min = 0F;
            this.max10.Name = "max10";
            this.max10.ParamName = null;
            this.max10.Size = new System.Drawing.Size(54, 21);
            this.max10.TabIndex = 210;
            // 
            // max11
            // 
            this.max11.Enabled = false;
            this.max11.Location = new System.Drawing.Point(503, 423);
            this.max11.Max = 1F;
            this.max11.Min = 0F;
            this.max11.Name = "max11";
            this.max11.ParamName = null;
            this.max11.Size = new System.Drawing.Size(54, 21);
            this.max11.TabIndex = 211;
            // 
            // max12
            // 
            this.max12.Enabled = false;
            this.max12.Location = new System.Drawing.Point(503, 463);
            this.max12.Max = 1F;
            this.max12.Min = 0F;
            this.max12.Name = "max12";
            this.max12.ParamName = null;
            this.max12.Size = new System.Drawing.Size(54, 21);
            this.max12.TabIndex = 212;
            // 
            // max13
            // 
            this.max13.Enabled = false;
            this.max13.Location = new System.Drawing.Point(503, 503);
            this.max13.Max = 1F;
            this.max13.Min = 0F;
            this.max13.Name = "max13";
            this.max13.ParamName = null;
            this.max13.Size = new System.Drawing.Size(54, 21);
            this.max13.TabIndex = 213;
            // 
            // max14
            // 
            this.max14.Enabled = false;
            this.max14.Location = new System.Drawing.Point(503, 543);
            this.max14.Max = 1F;
            this.max14.Min = 0F;
            this.max14.Name = "max14";
            this.max14.ParamName = null;
            this.max14.Size = new System.Drawing.Size(54, 21);
            this.max14.TabIndex = 214;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConfigRadioOutput
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfigRadioOutput";
            this.Size = new System.Drawing.Size(596, 588);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }


        private MavlinkCheckBox rev1;
        private HorizontalProgressBar2 BAR1;
        private MavlinkCheckBox rev7;
        private MavlinkCheckBox rev3;
        private MavlinkCheckBox rev6;
        private HorizontalProgressBar2 BAR6;
        private HorizontalProgressBar2 BAR2;
        private MavlinkCheckBox rev2;
        private HorizontalProgressBar2 BAR3;
        private HorizontalProgressBar2 BAR4;
        private MavlinkCheckBox rev5;
        private HorizontalProgressBar2 BAR5;
        private HorizontalProgressBar2 BAR7;
        private MavlinkCheckBox rev4;
        private MavlinkCheckBox rev8;
        private MavlinkCheckBox rev9;
        private MavlinkCheckBox rev10;
        private MavlinkCheckBox rev11;
        private MavlinkCheckBox rev12;
        private MavlinkCheckBox rev13;
        private MavlinkCheckBox rev14;
        private HorizontalProgressBar2 BAR8;
        private MavlinkComboBox func1;
        private MavlinkComboBox func2;
        private MavlinkComboBox func3;
        private MavlinkComboBox func4;
        private MavlinkComboBox func5;
        private MavlinkComboBox func6;
        private MavlinkComboBox func7;
        private MavlinkComboBox func8;
        private MavlinkComboBox func9;
        private MavlinkComboBox func10;
        private MavlinkComboBox func11;
        private MavlinkComboBox func12;
        private MavlinkComboBox func13;
        private MavlinkComboBox func14;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MavlinkNumericUpDown min1;
        private Label label1;
        private MavlinkNumericUpDown max8;
        private MavlinkNumericUpDown trim8;
        private MavlinkNumericUpDown min8;
        private MavlinkNumericUpDown max7;
        private MavlinkNumericUpDown trim7;
        private MavlinkNumericUpDown min7;
        private MavlinkNumericUpDown max6;
        private MavlinkNumericUpDown trim6;
        private MavlinkNumericUpDown min6;
        private MavlinkNumericUpDown max5;
        private MavlinkNumericUpDown trim5;
        private MavlinkNumericUpDown min5;
        private MavlinkNumericUpDown max4;
        private MavlinkNumericUpDown trim4;
        private MavlinkNumericUpDown min4;
        private MavlinkNumericUpDown max3;
        private MavlinkNumericUpDown trim3;
        private MavlinkNumericUpDown min3;
        private MavlinkNumericUpDown max2;
        private MavlinkNumericUpDown trim2;
        private MavlinkNumericUpDown min2;
        private MavlinkNumericUpDown max1;
        private MavlinkNumericUpDown trim1;
        private BindingSource bindingSource1;
       
        private Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label15;
        private Label label14;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label19;
        private Label label16;
        private Label label18;
        private Label label17;
        private HorizontalProgressBar2 BAR9;
        private HorizontalProgressBar2 BAR10;
        private HorizontalProgressBar2 BAR11;
        private HorizontalProgressBar2 BAR12;
        private Label label21;
        private Label label20;
        private HorizontalProgressBar2 BAR13;
        private HorizontalProgressBar2 BAR14;
        private MavlinkNumericUpDown min9;
        private MavlinkNumericUpDown min10;
        private MavlinkNumericUpDown min11;
        private MavlinkNumericUpDown min12;
        private MavlinkNumericUpDown min13;
        private MavlinkNumericUpDown min14;
        private MavlinkNumericUpDown trim9;
        private MavlinkNumericUpDown trim10;
        private MavlinkNumericUpDown trim11;
        private MavlinkNumericUpDown trim12;
        private MavlinkNumericUpDown trim13;
        private MavlinkNumericUpDown trim14;
        private MavlinkNumericUpDown max9;
        private MavlinkNumericUpDown max10;
        private MavlinkNumericUpDown max11;
        private MavlinkNumericUpDown max12;
        private MavlinkNumericUpDown max13;
        private MavlinkNumericUpDown max14;
    }
}
