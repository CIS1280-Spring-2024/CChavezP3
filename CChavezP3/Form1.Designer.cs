namespace CChavezP3
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
            btnSumbit = new Button();
            btnClear = new Button();
            txtOutput = new TextBox();
            label1 = new Label();
            txtNumColors = new TextBox();
            chbLogo = new CheckBox();
            txtCustom = new TextBox();
            lblEngraveText = new Label();
            groupBox1 = new GroupBox();
            rbPen = new RadioButton();
            rbMug = new RadioButton();
            rbUsb = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txtOrderNum = new TextBox();
            txtNumItems = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(184, 441);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(112, 34);
            btnSumbit.TabIndex = 0;
            btnSumbit.Text = "Submit";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(400, 441);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(106, 504);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(470, 110);
            txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 402);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 3;
            label1.Text = "Number of colors:";
            // 
            // txtNumColors
            // 
            txtNumColors.Location = new Point(362, 396);
            txtNumColors.Name = "txtNumColors";
            txtNumColors.Size = new Size(150, 31);
            txtNumColors.TabIndex = 4;
            // 
            // chbLogo
            // 
            chbLogo.AutoSize = true;
            chbLogo.Location = new Point(362, 361);
            chbLogo.Name = "chbLogo";
            chbLogo.Size = new Size(87, 29);
            chbLogo.TabIndex = 5;
            chbLogo.Text = "Logo?";
            chbLogo.UseVisualStyleBackColor = true;
            // 
            // txtCustom
            // 
            txtCustom.Location = new Point(106, 309);
            txtCustom.Multiline = true;
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(470, 46);
            txtCustom.TabIndex = 6;
            // 
            // lblEngraveText
            // 
            lblEngraveText.AutoSize = true;
            lblEngraveText.Location = new Point(106, 281);
            lblEngraveText.Name = "lblEngraveText";
            lblEngraveText.Size = new Size(200, 25);
            lblEngraveText.TabIndex = 7;
            lblEngraveText.Text = "Text to engrave or print:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPen);
            groupBox1.Controls.Add(rbMug);
            groupBox1.Controls.Add(rbUsb);
            groupBox1.Location = new Point(326, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 167);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Type";
            // 
            // rbPen
            // 
            rbPen.AutoSize = true;
            rbPen.Location = new Point(36, 124);
            rbPen.Name = "rbPen";
            rbPen.Size = new Size(65, 29);
            rbPen.TabIndex = 2;
            rbPen.TabStop = true;
            rbPen.Text = "Pen";
            rbPen.UseVisualStyleBackColor = true;
            // 
            // rbMug
            // 
            rbMug.AutoSize = true;
            rbMug.Location = new Point(36, 83);
            rbMug.Name = "rbMug";
            rbMug.Size = new Size(74, 29);
            rbMug.TabIndex = 1;
            rbMug.TabStop = true;
            rbMug.Text = "Mug";
            rbMug.UseVisualStyleBackColor = true;
            // 
            // rbUsb
            // 
            rbUsb.AutoSize = true;
            rbUsb.Location = new Point(36, 42);
            rbUsb.Name = "rbUsb";
            rbUsb.Size = new Size(69, 29);
            rbUsb.TabIndex = 0;
            rbUsb.TabStop = true;
            rbUsb.Text = "USB";
            rbUsb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 46);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 9;
            label2.Text = "Order Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 88);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 10;
            label3.Text = "Number of items:";
            // 
            // txtOrderNum
            // 
            txtOrderNum.Location = new Point(326, 40);
            txtOrderNum.Name = "txtOrderNum";
            txtOrderNum.Size = new Size(250, 31);
            txtOrderNum.TabIndex = 11;
            // 
            // txtNumItems
            // 
            txtNumItems.Location = new Point(326, 82);
            txtNumItems.Name = "txtNumItems";
            txtNumItems.Size = new Size(250, 31);
            txtNumItems.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 635);
            Controls.Add(txtNumItems);
            Controls.Add(txtOrderNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lblEngraveText);
            Controls.Add(txtCustom);
            Controls.Add(chbLogo);
            Controls.Add(txtNumColors);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(btnClear);
            Controls.Add(btnSumbit);
            Name = "Form1";
            Text = "Logo Item Order Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumbit;
        private Button btnClear;
        private TextBox txtOutput;
        private Label label1;
        private TextBox txtNumColors;
        private CheckBox chbLogo;
        private TextBox txtCustom;
        private Label lblEngraveText;
        private GroupBox groupBox1;
        private RadioButton rbPen;
        private RadioButton rbMug;
        private RadioButton rbUsb;
        private Label label2;
        private Label label3;
        private TextBox txtOrderNum;
        private TextBox txtNumItems;
    }
}
