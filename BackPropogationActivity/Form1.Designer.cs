namespace BackPropogationActivity
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
            trainButton = new Button();
            outputBox = new RichTextBox();
            inputBox1 = new RichTextBox();
            inputBox2 = new RichTextBox();
            inputBox3 = new RichTextBox();
            resetButton = new Button();
            createButton = new Button();
            testButton = new Button();
            inputBox4 = new RichTextBox();
            outputBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // trainButton
            // 
            trainButton.Location = new Point(325, 361);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(143, 60);
            trainButton.TabIndex = 0;
            trainButton.Text = "Train the Neural Net";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += trainButton_Click;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputBox.Location = new Point(502, 141);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(143, 63);
            outputBox.TabIndex = 1;
            outputBox.Text = "";
            outputBox.TextChanged += outputBox_TextChanged;
            // 
            // inputBox1
            // 
            inputBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBox1.Location = new Point(128, 74);
            inputBox1.Multiline = false;
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(143, 50);
            inputBox1.TabIndex = 2;
            inputBox1.Text = "";
            inputBox1.TextChanged += inputBox1_TextChanged;
            // 
            // inputBox2
            // 
            inputBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBox2.Location = new Point(128, 141);
            inputBox2.Multiline = false;
            inputBox2.Name = "inputBox2";
            inputBox2.Size = new Size(143, 51);
            inputBox2.TabIndex = 3;
            inputBox2.Text = "";
            inputBox2.TextChanged += inputBox2_TextChanged;
            // 
            // inputBox3
            // 
            inputBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBox3.Location = new Point(128, 209);
            inputBox3.Multiline = false;
            inputBox3.Name = "inputBox3";
            inputBox3.Size = new Size(143, 48);
            inputBox3.TabIndex = 4;
            inputBox3.Text = "";
            inputBox3.TextChanged += inputBox3_TextChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(143, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(111, 37);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(128, 368);
            createButton.Name = "createButton";
            createButton.Size = new Size(128, 46);
            createButton.TabIndex = 6;
            createButton.Text = "Create BPNN";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // testButton
            // 
            testButton.Location = new Point(517, 368);
            testButton.Name = "testButton";
            testButton.Size = new Size(128, 46);
            testButton.TabIndex = 7;
            testButton.Text = "Test";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // inputBox4
            // 
            inputBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputBox4.Location = new Point(128, 276);
            inputBox4.Multiline = false;
            inputBox4.Name = "inputBox4";
            inputBox4.Size = new Size(143, 46);
            inputBox4.TabIndex = 8;
            inputBox4.Text = "";
            // 
            // outputBox2
            // 
            outputBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputBox2.Location = new Point(434, 236);
            outputBox2.Name = "outputBox2";
            outputBox2.ReadOnly = true;
            outputBox2.Size = new Size(290, 63);
            outputBox2.TabIndex = 9;
            outputBox2.Text = "";
            outputBox2.TextChanged += outputBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputBox2);
            Controls.Add(inputBox4);
            Controls.Add(testButton);
            Controls.Add(createButton);
            Controls.Add(resetButton);
            Controls.Add(inputBox3);
            Controls.Add(inputBox2);
            Controls.Add(inputBox1);
            Controls.Add(outputBox);
            Controls.Add(trainButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button trainButton;
        private RichTextBox outputBox;
        private RichTextBox inputBox1;
        private RichTextBox inputBox2;
        private RichTextBox inputBox3;
        private Button resetButton;
        private Button createButton;
        private Button testButton;
        private RichTextBox inputBox4;
        private RichTextBox outputBox2;
    }
}
