using System;

namespace calculadora_desktop {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sub = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.backSpace = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.display, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(3, 3);
            this.display.MaxLength = 14;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(304, 49);
            this.display.TabIndex = 2;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.sub, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nine, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.eight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.seven, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.equal, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.dot, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.backSpace, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.div, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.add, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.mult, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.percent, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearEntry, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clear, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 350);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.sub.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sub.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(233, 209);
            this.sub.Margin = new System.Windows.Forms.Padding(2);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 65);
            this.sub.TabIndex = 15;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.three.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(156, 209);
            this.three.Margin = new System.Windows.Forms.Padding(2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(73, 65);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(2, 209);
            this.one.Margin = new System.Windows.Forms.Padding(2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(73, 65);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.six.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(156, 140);
            this.six.Margin = new System.Windows.Forms.Padding(2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(73, 65);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.five.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(79, 140);
            this.five.Margin = new System.Windows.Forms.Padding(2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(73, 65);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.four.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(2, 140);
            this.four.Margin = new System.Windows.Forms.Padding(2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(73, 65);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.nine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(156, 71);
            this.nine.Margin = new System.Windows.Forms.Padding(2);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(73, 65);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.eight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(79, 71);
            this.eight.Margin = new System.Windows.Forms.Padding(2);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(73, 65);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.seven.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(2, 71);
            this.seven.Margin = new System.Windows.Forms.Padding(2);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(73, 65);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(79, 278);
            this.zero.Margin = new System.Windows.Forms.Padding(2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(73, 70);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.two.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(79, 209);
            this.two.Margin = new System.Windows.Forms.Padding(2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(73, 65);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.equal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(233, 278);
            this.equal.Margin = new System.Windows.Forms.Padding(2);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 70);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.dot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(156, 278);
            this.dot.Margin = new System.Windows.Forms.Padding(2);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(73, 70);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // backSpace
            // 
            this.backSpace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backSpace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.backSpace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backSpace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.backSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSpace.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpace.Location = new System.Drawing.Point(2, 278);
            this.backSpace.Margin = new System.Windows.Forms.Padding(2);
            this.backSpace.Name = "backSpace";
            this.backSpace.Size = new System.Drawing.Size(73, 70);
            this.backSpace.TabIndex = 3;
            this.backSpace.Text = "←";
            this.backSpace.UseVisualStyleBackColor = false;
            this.backSpace.Click += new System.EventHandler(this.backSpace_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.div.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.div.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(233, 2);
            this.div.Margin = new System.Windows.Forms.Padding(2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 65);
            this.div.TabIndex = 7;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operator_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(233, 140);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 65);
            this.add.TabIndex = 20;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.operator_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mult.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.mult.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mult.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(233, 71);
            this.mult.Margin = new System.Windows.Forms.Padding(2);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 65);
            this.mult.TabIndex = 11;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.operator_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.percent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.percent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(156, 2);
            this.percent.Margin = new System.Windows.Forms.Padding(2);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(73, 65);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.clearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntry.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(79, 2);
            this.clearEntry.Margin = new System.Windows.Forms.Padding(2);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(73, 65);
            this.clearEntry.TabIndex = 1;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(2, 2);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(73, 65);
            this.clear.TabIndex = 2;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button backSpace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.TextBox display;
    }
}

