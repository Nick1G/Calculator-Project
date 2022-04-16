﻿namespace Calculator_Project
{
    partial class CalculatorForm
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
            this.NumPanel = new System.Windows.Forms.Panel();
            this.NumOneButton = new System.Windows.Forms.Button();
            this.NumFourButton = new System.Windows.Forms.Button();
            this.NumNineButton = new System.Windows.Forms.Button();
            this.NumZeroButton = new System.Windows.Forms.Button();
            this.NumSixButton = new System.Windows.Forms.Button();
            this.NumSevenButton = new System.Windows.Forms.Button();
            this.NumThreeButton = new System.Windows.Forms.Button();
            this.NumTwoButton = new System.Windows.Forms.Button();
            this.NumEightButton = new System.Windows.Forms.Button();
            this.NumFiveButton = new System.Windows.Forms.Button();
            this.NumDisplay = new System.Windows.Forms.TextBox();
            this.OperatorPanel = new System.Windows.Forms.Panel();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.OperatorDisplay = new System.Windows.Forms.TextBox();
            this.NumPanel.SuspendLayout();
            this.OperatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumPanel
            // 
            this.NumPanel.AccessibleDescription = "Panel that serves to group number buttons";
            this.NumPanel.AccessibleName = "Number Panel";
            this.NumPanel.Controls.Add(this.NumOneButton);
            this.NumPanel.Controls.Add(this.NumFourButton);
            this.NumPanel.Controls.Add(this.NumNineButton);
            this.NumPanel.Controls.Add(this.NumZeroButton);
            this.NumPanel.Controls.Add(this.NumSixButton);
            this.NumPanel.Controls.Add(this.NumSevenButton);
            this.NumPanel.Controls.Add(this.NumThreeButton);
            this.NumPanel.Controls.Add(this.NumTwoButton);
            this.NumPanel.Controls.Add(this.NumEightButton);
            this.NumPanel.Controls.Add(this.NumFiveButton);
            this.NumPanel.Location = new System.Drawing.Point(12, 222);
            this.NumPanel.Name = "NumPanel";
            this.NumPanel.Size = new System.Drawing.Size(192, 255);
            this.NumPanel.TabIndex = 0;
            this.NumPanel.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumOneButton
            // 
            this.NumOneButton.AccessibleDescription = "Button that enters a one into the number display";
            this.NumOneButton.AccessibleName = "One Button";
            this.NumOneButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumOneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumOneButton.Location = new System.Drawing.Point(0, 0);
            this.NumOneButton.Name = "NumOneButton";
            this.NumOneButton.Size = new System.Drawing.Size(60, 60);
            this.NumOneButton.TabIndex = 1;
            this.NumOneButton.Text = "1";
            this.NumOneButton.UseVisualStyleBackColor = false;
            this.NumOneButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumFourButton
            // 
            this.NumFourButton.AccessibleDescription = "Button that enters a four into the number display";
            this.NumFourButton.AccessibleName = "Four Button";
            this.NumFourButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumFourButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumFourButton.Location = new System.Drawing.Point(0, 66);
            this.NumFourButton.Name = "NumFourButton";
            this.NumFourButton.Size = new System.Drawing.Size(60, 60);
            this.NumFourButton.TabIndex = 4;
            this.NumFourButton.Text = "4";
            this.NumFourButton.UseVisualStyleBackColor = false;
            this.NumFourButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumNineButton
            // 
            this.NumNineButton.AccessibleDescription = "Button that enters a nine into the number display";
            this.NumNineButton.AccessibleName = "Nine Button";
            this.NumNineButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumNineButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumNineButton.Location = new System.Drawing.Point(132, 132);
            this.NumNineButton.Name = "NumNineButton";
            this.NumNineButton.Size = new System.Drawing.Size(60, 60);
            this.NumNineButton.TabIndex = 9;
            this.NumNineButton.Text = "9";
            this.NumNineButton.UseVisualStyleBackColor = false;
            this.NumNineButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumZeroButton
            // 
            this.NumZeroButton.AccessibleDescription = "Button that enters a zero into the number display";
            this.NumZeroButton.AccessibleName = "Zero Button";
            this.NumZeroButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumZeroButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumZeroButton.Location = new System.Drawing.Point(66, 195);
            this.NumZeroButton.Name = "NumZeroButton";
            this.NumZeroButton.Size = new System.Drawing.Size(60, 60);
            this.NumZeroButton.TabIndex = 10;
            this.NumZeroButton.Text = "0";
            this.NumZeroButton.UseVisualStyleBackColor = false;
            this.NumZeroButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumSixButton
            // 
            this.NumSixButton.AccessibleDescription = "Button that enters a six into the number display";
            this.NumSixButton.AccessibleName = "Six Button";
            this.NumSixButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumSixButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumSixButton.Location = new System.Drawing.Point(132, 66);
            this.NumSixButton.Name = "NumSixButton";
            this.NumSixButton.Size = new System.Drawing.Size(60, 60);
            this.NumSixButton.TabIndex = 6;
            this.NumSixButton.Text = "6";
            this.NumSixButton.UseVisualStyleBackColor = false;
            this.NumSixButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumSevenButton
            // 
            this.NumSevenButton.AccessibleDescription = "Button that enters a seven into the number display";
            this.NumSevenButton.AccessibleName = "Seven Button";
            this.NumSevenButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumSevenButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumSevenButton.Location = new System.Drawing.Point(0, 132);
            this.NumSevenButton.Name = "NumSevenButton";
            this.NumSevenButton.Size = new System.Drawing.Size(60, 60);
            this.NumSevenButton.TabIndex = 7;
            this.NumSevenButton.Text = "7";
            this.NumSevenButton.UseVisualStyleBackColor = false;
            this.NumSevenButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumThreeButton
            // 
            this.NumThreeButton.AccessibleDescription = "Button that enters a three into the number display";
            this.NumThreeButton.AccessibleName = "Three Button";
            this.NumThreeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumThreeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumThreeButton.Location = new System.Drawing.Point(132, 0);
            this.NumThreeButton.Name = "NumThreeButton";
            this.NumThreeButton.Size = new System.Drawing.Size(60, 60);
            this.NumThreeButton.TabIndex = 3;
            this.NumThreeButton.Text = "3";
            this.NumThreeButton.UseVisualStyleBackColor = false;
            this.NumThreeButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumTwoButton
            // 
            this.NumTwoButton.AccessibleDescription = "Button that enters a two into the number display";
            this.NumTwoButton.AccessibleName = "Two Button";
            this.NumTwoButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumTwoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTwoButton.Location = new System.Drawing.Point(66, 0);
            this.NumTwoButton.Name = "NumTwoButton";
            this.NumTwoButton.Size = new System.Drawing.Size(60, 60);
            this.NumTwoButton.TabIndex = 2;
            this.NumTwoButton.Text = "2";
            this.NumTwoButton.UseVisualStyleBackColor = false;
            this.NumTwoButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumEightButton
            // 
            this.NumEightButton.AccessibleDescription = "Button that enters an eight into the number display";
            this.NumEightButton.AccessibleName = "Eight Button";
            this.NumEightButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumEightButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumEightButton.Location = new System.Drawing.Point(66, 132);
            this.NumEightButton.Name = "NumEightButton";
            this.NumEightButton.Size = new System.Drawing.Size(60, 60);
            this.NumEightButton.TabIndex = 8;
            this.NumEightButton.Text = "8";
            this.NumEightButton.UseVisualStyleBackColor = false;
            this.NumEightButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumFiveButton
            // 
            this.NumFiveButton.AccessibleDescription = "Button that enters a five into the number display";
            this.NumFiveButton.AccessibleName = "Five Button";
            this.NumFiveButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NumFiveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumFiveButton.Location = new System.Drawing.Point(66, 66);
            this.NumFiveButton.Name = "NumFiveButton";
            this.NumFiveButton.Size = new System.Drawing.Size(60, 60);
            this.NumFiveButton.TabIndex = 5;
            this.NumFiveButton.Text = "5";
            this.NumFiveButton.UseVisualStyleBackColor = false;
            this.NumFiveButton.Click += new System.EventHandler(this.NumPanel_Click);
            // 
            // NumDisplay
            // 
            this.NumDisplay.AccessibleDescription = "Display for number inputs and equation results";
            this.NumDisplay.AccessibleName = "Number Display";
            this.NumDisplay.BackColor = System.Drawing.Color.White;
            this.NumDisplay.Enabled = false;
            this.NumDisplay.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumDisplay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.NumDisplay.Location = new System.Drawing.Point(12, 52);
            this.NumDisplay.Multiline = true;
            this.NumDisplay.Name = "NumDisplay";
            this.NumDisplay.ReadOnly = true;
            this.NumDisplay.Size = new System.Drawing.Size(411, 70);
            this.NumDisplay.TabIndex = 11;
            this.NumDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OperatorPanel
            // 
            this.OperatorPanel.AccessibleDescription = "Panel used to group operators together";
            this.OperatorPanel.AccessibleName = "Operator Panel";
            this.OperatorPanel.Controls.Add(this.DivideButton);
            this.OperatorPanel.Controls.Add(this.MultiplyButton);
            this.OperatorPanel.Controls.Add(this.MinusButton);
            this.OperatorPanel.Controls.Add(this.AddButton);
            this.OperatorPanel.Location = new System.Drawing.Point(261, 222);
            this.OperatorPanel.Name = "OperatorPanel";
            this.OperatorPanel.Size = new System.Drawing.Size(162, 162);
            this.OperatorPanel.TabIndex = 12;
            this.OperatorPanel.Click += new System.EventHandler(this.OperatorPanel_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.AccessibleDescription = "Button that divides the current number display by the next number input";
            this.DivideButton.AccessibleName = "Division Button";
            this.DivideButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(84, 84);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(78, 78);
            this.DivideButton.TabIndex = 14;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.OperatorPanel_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.AccessibleDescription = "Button that multiplies the current number display by the next number input";
            this.MultiplyButton.AccessibleName = "Multiplication Button";
            this.MultiplyButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(0, 84);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(78, 78);
            this.MultiplyButton.TabIndex = 14;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorPanel_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.AccessibleDescription = "Button that subtracts the next input number from the current number display";
            this.MinusButton.AccessibleName = "Subtraction Button";
            this.MinusButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(84, 0);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(78, 78);
            this.MinusButton.TabIndex = 14;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.OperatorPanel_Click);
            // 
            // AddButton
            // 
            this.AddButton.AccessibleDescription = "Button that adds the current number display to the next input";
            this.AddButton.AccessibleName = "Addition Button";
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 78);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.OperatorPanel_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.AccessibleDescription = "Button that resolves the operation within the number display";
            this.EqualButton.AccessibleName = "Equal Button";
            this.EqualButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualButton.Location = new System.Drawing.Point(261, 390);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(162, 87);
            this.EqualButton.TabIndex = 14;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // OperatorDisplay
            // 
            this.OperatorDisplay.AccessibleDescription = "Display for the currently saved operator";
            this.OperatorDisplay.AccessibleName = "Operator Display";
            this.OperatorDisplay.BackColor = System.Drawing.Color.White;
            this.OperatorDisplay.Enabled = false;
            this.OperatorDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OperatorDisplay.Location = new System.Drawing.Point(389, 12);
            this.OperatorDisplay.Multiline = true;
            this.OperatorDisplay.Name = "OperatorDisplay";
            this.OperatorDisplay.ReadOnly = true;
            this.OperatorDisplay.Size = new System.Drawing.Size(34, 34);
            this.OperatorDisplay.TabIndex = 15;
            this.OperatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculatorForm
            // 
            this.AccessibleDescription = "Form that functions as a simple calculator with operators, operands, and a number" +
    " display";
            this.AccessibleName = "Calculator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 499);
            this.Controls.Add(this.OperatorDisplay);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.NumDisplay);
            this.Controls.Add(this.NumPanel);
            this.Controls.Add(this.OperatorPanel);
            this.Name = "CalculatorForm";
            this.RightToLeftLayout = true;
            this.Text = "Calculator";
            this.NumPanel.ResumeLayout(false);
            this.OperatorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel NumPanel;
        private Button NumOneButton;
        private Button NumTwoButton;
        private Button NumThreeButton;
        private Button NumFourButton;
        private Button NumFiveButton;
        private Button NumSixButton;
        private Button NumSevenButton;
        private Button NumEightButton;
        private Button NumNineButton;
        private Button NumZeroButton;
        private TextBox NumDisplay;
        private Panel OperatorPanel;
        private Button EqualButton;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button MinusButton;
        private Button AddButton;
        private TextBox OperatorDisplay;
    }
}