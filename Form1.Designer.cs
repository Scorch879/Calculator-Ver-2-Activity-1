namespace Calculator_Ver_2_Activity_1
{
    partial class SimpleCalculator
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
            txtDisplay = new TextBox();
            btnDivide = new Button();
            btnToggleSign = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnDot = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEquals = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.White;
            txtDisplay.Enabled = false;
            txtDisplay.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.WindowText;
            txtDisplay.Location = new Point(12, 19);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(526, 123);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.WindowText;
            btnDivide.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.Control;
            btnDivide.Location = new Point(396, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(127, 105);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnToggleSign
            // 
            btnToggleSign.BackColor = SystemColors.WindowText;
            btnToggleSign.Dock = DockStyle.Fill;
            btnToggleSign.Font = new Font("Arial Rounded MT Bold", 36F);
            btnToggleSign.ForeColor = SystemColors.Control;
            btnToggleSign.Location = new Point(265, 3);
            btnToggleSign.Name = "btnToggleSign";
            btnToggleSign.Size = new Size(125, 105);
            btnToggleSign.TabIndex = 18;
            btnToggleSign.Text = "+/-";
            btnToggleSign.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.WindowText;
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Arial Rounded MT Bold", 36F);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(134, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 105);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.WindowText;
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Arial Rounded MT Bold", 36F);
            btnBackspace.ForeColor = SystemColors.Control;
            btnBackspace.Location = new Point(3, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(125, 105);
            btnBackspace.TabIndex = 16;
            btnBackspace.Text = "<<";
            btnBackspace.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.WindowText;
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.ForeColor = SystemColors.Control;
            btnDot.Location = new Point(134, 447);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(125, 108);
            btnDot.TabIndex = 15;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.WindowText;
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Arial Rounded MT Bold", 36F);
            btnMultiply.ForeColor = SystemColors.Control;
            btnMultiply.Location = new Point(396, 336);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(127, 105);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.WindowText;
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.ForeColor = SystemColors.Control;
            btnSubtract.Location = new Point(396, 225);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(127, 105);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.WindowText;
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.ForeColor = SystemColors.Control;
            button0.Location = new Point(3, 447);
            button0.Name = "button0";
            button0.Size = new Size(125, 108);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.WindowText;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Arial Rounded MT Bold", 36F);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(265, 336);
            button9.Name = "button9";
            button9.Size = new Size(125, 105);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.WindowText;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Arial Rounded MT Bold", 36F);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(134, 336);
            button8.Name = "button8";
            button8.Size = new Size(125, 105);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowText;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Arial Rounded MT Bold", 36F);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(3, 336);
            button7.Name = "button7";
            button7.Size = new Size(125, 105);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.WindowText;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(265, 225);
            button6.Name = "button6";
            button6.Size = new Size(125, 105);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowText;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(134, 225);
            button5.Name = "button5";
            button5.Size = new Size(125, 105);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowText;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(3, 225);
            button4.Name = "button4";
            button4.Size = new Size(125, 105);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 114);
            button1.Name = "button1";
            button1.Size = new Size(125, 105);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(134, 114);
            button2.Name = "button2";
            button2.Size = new Size(125, 105);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(265, 114);
            button3.Name = "button3";
            button3.Size = new Size(125, 105);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.WindowText;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(396, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 105);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 3);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button9, 2, 3);
            tableLayoutPanel1.Controls.Add(button0, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSubtract, 3, 2);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 3);
            tableLayoutPanel1.Controls.Add(btnEquals, 2, 4);
            tableLayoutPanel1.Controls.Add(btnDot, 1, 4);
            tableLayoutPanel1.Controls.Add(btnBackspace, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel1.Controls.Add(btnToggleSign, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(526, 558);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.WindowText;
            tableLayoutPanel1.SetColumnSpan(btnEquals, 2);
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Font = new Font("Arial Rounded MT Bold", 25.8000011F);
            btnEquals.ForeColor = SystemColors.Control;
            btnEquals.Location = new Point(265, 447);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(258, 108);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.WindowText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(550, 741);
            Controls.Add(txtDisplay);
            Controls.Add(tableLayoutPanel1);
            Name = "SimpleCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator App";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDisplay;
        private Button btnDivide;
        private Button btnToggleSign;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnDot;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEquals;
    }
}
