/*
 * Author of the program: Jonathan A. Ramírez Colón
 * Updated Date: 8/26/2024
 */
namespace Calculator
{
    partial class Calculator1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator1));
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number0 = new Button();
            dot = new Button();
            multiply = new Button();
            subtract = new Button();
            plus = new Button();
            equal = new Button();
            textTotal = new TextBox();
            clear = new Button();
            SuspendLayout();
            // 
            // number7
            // 
            number7.Location = new Point(30, 188);
            number7.Name = "number7";
            number7.Size = new Size(94, 30);
            number7.TabIndex = 0;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += number7_Click;
            // 
            // number8
            // 
            number8.Location = new Point(149, 188);
            number8.Name = "number8";
            number8.Size = new Size(94, 30);
            number8.TabIndex = 1;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += number8_Click;
            // 
            // number9
            // 
            number9.Location = new Point(266, 188);
            number9.Name = "number9";
            number9.Size = new Size(94, 30);
            number9.TabIndex = 2;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += number9_Click;
            // 
            // number4
            // 
            number4.Location = new Point(30, 252);
            number4.Name = "number4";
            number4.Size = new Size(94, 29);
            number4.TabIndex = 3;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += number4_Click;
            // 
            // number5
            // 
            number5.Location = new Point(149, 252);
            number5.Name = "number5";
            number5.Size = new Size(94, 29);
            number5.TabIndex = 4;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += number5_Click;
            // 
            // number6
            // 
            number6.Location = new Point(266, 252);
            number6.Name = "number6";
            number6.Size = new Size(94, 29);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += number6_Click;
            // 
            // number1
            // 
            number1.Location = new Point(30, 319);
            number1.Name = "number1";
            number1.Size = new Size(94, 29);
            number1.TabIndex = 6;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += number1_Click;
            // 
            // number2
            // 
            number2.Location = new Point(149, 319);
            number2.Name = "number2";
            number2.Size = new Size(94, 29);
            number2.TabIndex = 7;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += number2_Click;
            // 
            // number3
            // 
            number3.Location = new Point(266, 319);
            number3.Name = "number3";
            number3.Size = new Size(94, 29);
            number3.TabIndex = 8;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += number3_Click_1;
            // 
            // number0
            // 
            number0.Location = new Point(149, 391);
            number0.Name = "number0";
            number0.Size = new Size(94, 29);
            number0.TabIndex = 9;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = true;
            number0.Click += number0_Click;
            // 
            // dot
            // 
            dot.Location = new Point(266, 391);
            dot.Name = "dot";
            dot.Size = new Size(94, 29);
            dot.TabIndex = 10;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(385, 188);
            multiply.Name = "multiply";
            multiply.Size = new Size(94, 29);
            multiply.TabIndex = 11;
            multiply.Text = "X";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // subtract
            // 
            subtract.Location = new Point(385, 252);
            subtract.Name = "subtract";
            subtract.Size = new Size(94, 29);
            subtract.TabIndex = 12;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // plus
            // 
            plus.Location = new Point(385, 319);
            plus.Name = "plus";
            plus.Size = new Size(94, 29);
            plus.TabIndex = 13;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // equal
            // 
            equal.Location = new Point(385, 391);
            equal.Name = "equal";
            equal.Size = new Size(94, 29);
            equal.TabIndex = 14;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // textTotal
            // 
            textTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotal.Location = new Point(30, 53);
            textTotal.Multiline = true;
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(449, 64);
            textTotal.TabIndex = 15;
            textTotal.TextAlign = HorizontalAlignment.Right;
            textTotal.TextChanged += textTotal_TextChanged;
            // 
            // clear
            // 
            clear.Location = new Point(30, 391);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 16;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Calculator1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 548);
            Controls.Add(clear);
            Controls.Add(textTotal);
            Controls.Add(equal);
            Controls.Add(plus);
            Controls.Add(subtract);
            Controls.Add(multiply);
            Controls.Add(dot);
            Controls.Add(number0);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator1";
            Text = "Calculator1";
            Load += Calculator1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //Initialize buttons of the calculator.
        private Button number7;
        private Button number8;
        private Button number9;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button number1;
        private Button number2;
        private Button number3;
        private Button number0;
        private Button dot;
        private Button multiply;
        private Button subtract;
        private Button plus;
        private Button equal;
        private TextBox textTotal;
        private Button clear;
    }
}
