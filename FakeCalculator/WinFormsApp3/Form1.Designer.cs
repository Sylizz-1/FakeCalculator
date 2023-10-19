namespace WinFormsApp3
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
            Screen = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn1PhanX = new Button();
            btnMod = new Button();
            btnSign = new Button();
            btnDot = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnCE = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnEqual = new Button();
            btn3 = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btn2 = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnBinhPhuong = new Button();
            btnSquareRoot = new Button();
            screenLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 46);
            label1.TabIndex = 0;
            label1.Text = "Standard";
            // 
            // Screen
            // 
            Screen.Dock = DockStyle.Fill;
            Screen.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Screen.ImeMode = ImeMode.NoControl;
            Screen.Location = new Point(3, 96);
            Screen.Name = "Screen";
            Screen.Size = new Size(424, 61);
            Screen.TabIndex = 1;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            Screen.TextChanged += Screen_TextChanged;
            Screen.KeyPress += Screen_KeyPress;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(Screen, 0, 2);
            tableLayoutPanel1.Controls.Add(screenLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.445585F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.650924F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3203287F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.37782F));
            tableLayoutPanel1.Size = new Size(430, 487);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btn1PhanX, 0, 1);
            tableLayoutPanel2.Controls.Add(btnMod, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSign, 0, 5);
            tableLayoutPanel2.Controls.Add(btnDot, 2, 5);
            tableLayoutPanel2.Controls.Add(btn9, 2, 2);
            tableLayoutPanel2.Controls.Add(btn8, 1, 2);
            tableLayoutPanel2.Controls.Add(btn7, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCE, 1, 0);
            tableLayoutPanel2.Controls.Add(btn0, 1, 5);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel2.Controls.Add(btn6, 2, 3);
            tableLayoutPanel2.Controls.Add(btn5, 1, 3);
            tableLayoutPanel2.Controls.Add(btn4, 0, 3);
            tableLayoutPanel2.Controls.Add(btnEqual, 3, 5);
            tableLayoutPanel2.Controls.Add(btn3, 2, 4);
            tableLayoutPanel2.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel2.Controls.Add(btnAdd, 3, 4);
            tableLayoutPanel2.Controls.Add(btn2, 1, 4);
            tableLayoutPanel2.Controls.Add(btnSub, 3, 3);
            tableLayoutPanel2.Controls.Add(btnMul, 3, 2);
            tableLayoutPanel2.Controls.Add(btn1, 0, 4);
            tableLayoutPanel2.Controls.Add(btnDiv, 3, 1);
            tableLayoutPanel2.Controls.Add(btnBinhPhuong, 1, 1);
            tableLayoutPanel2.Controls.Add(btnSquareRoot, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 156);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(424, 328);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // btn1PhanX
            // 
            btn1PhanX.Dock = DockStyle.Fill;
            btn1PhanX.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1PhanX.Location = new Point(3, 57);
            btn1PhanX.Name = "btn1PhanX";
            btn1PhanX.Size = new Size(100, 48);
            btn1PhanX.TabIndex = 23;
            btn1PhanX.Text = "1/x";
            btn1PhanX.UseVisualStyleBackColor = true;
            btn1PhanX.Click += btn1PhanX_Click;
            // 
            // btnMod
            // 
            btnMod.Dock = DockStyle.Fill;
            btnMod.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(3, 3);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(100, 48);
            btnMod.TabIndex = 23;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += OperatorClick;
            // 
            // btnSign
            // 
            btnSign.Dock = DockStyle.Fill;
            btnSign.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSign.Location = new Point(3, 273);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(100, 52);
            btnSign.TabIndex = 18;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(215, 273);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(100, 52);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(215, 111);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 48);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberClick;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(109, 111);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 48);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberClick;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(3, 111);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 48);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberClick;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCE.Location = new Point(109, 3);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(100, 48);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(109, 273);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 52);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberClick;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(215, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 48);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(215, 165);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 48);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberClick;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(109, 165);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 48);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberClick;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(3, 165);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 48);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberClick;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(321, 273);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(100, 52);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(215, 219);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 48);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberClick;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(321, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 48);
            btnDelete.TabIndex = 9;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(321, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 48);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OperatorClick;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(109, 219);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 48);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberClick;
            // 
            // btnSub
            // 
            btnSub.Dock = DockStyle.Fill;
            btnSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(321, 165);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(100, 48);
            btnSub.TabIndex = 17;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += OperatorClick;
            // 
            // btnMul
            // 
            btnMul.Dock = DockStyle.Fill;
            btnMul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMul.Location = new Point(321, 111);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(100, 48);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += OperatorClick;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(3, 219);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 48);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberClick;
            // 
            // btnDiv
            // 
            btnDiv.Dock = DockStyle.Fill;
            btnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(321, 57);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(100, 48);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += OperatorClick;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Dock = DockStyle.Fill;
            btnBinhPhuong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBinhPhuong.Location = new Point(109, 57);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(100, 48);
            btnBinhPhuong.TabIndex = 24;
            btnBinhPhuong.Text = "x^2";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Dock = DockStyle.Fill;
            btnSquareRoot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSquareRoot.Location = new Point(215, 57);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(100, 48);
            btnSquareRoot.TabIndex = 25;
            btnSquareRoot.Text = "sqrt(x)";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // screenLabel
            // 
            screenLabel.AutoSize = true;
            screenLabel.Dock = DockStyle.Fill;
            screenLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            screenLabel.ForeColor = SystemColors.ButtonShadow;
            screenLabel.Location = new Point(3, 46);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new Size(424, 47);
            screenLabel.TabIndex = 23;
            screenLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 487);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private TextBox Screen;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnEqual;
        private Button btn0;
        private Button btnSign;
        private Button btnSub;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMul;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDiv;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDelete;
        private Button btnClear;
        private Button btnCE;
        private Button btnDot;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnMod;
        private Button btn1PhanX;
        private Button btnBinhPhuong;
        private Button btnSquareRoot;
        private Label screenLabel;
    }
}