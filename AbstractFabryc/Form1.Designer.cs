namespace AbstractFabryc
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
            ComboColorBox = new ComboBox();
            ButtonDraw = new Button();
            RedRadBut = new RadioButton();
            BlueRadBut = new RadioButton();
            NumericY = new NumericUpDown();
            NumericX = new NumericUpDown();
            XLabel = new Label();
            YLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericX).BeginInit();
            SuspendLayout();
            // 
            // ComboColorBox
            // 
            ComboColorBox.FormattingEnabled = true;
            ComboColorBox.Items.AddRange(new object[] { "Круг", "Квадрат", "Треугольник" });
            ComboColorBox.Location = new Point(12, 12);
            ComboColorBox.Name = "ComboColorBox";
            ComboColorBox.Size = new Size(151, 28);
            ComboColorBox.TabIndex = 0;
            // 
            // ButtonDraw
            // 
            ButtonDraw.Location = new Point(12, 46);
            ButtonDraw.Name = "ButtonDraw";
            ButtonDraw.Size = new Size(94, 29);
            ButtonDraw.TabIndex = 1;
            ButtonDraw.Text = "button1";
            ButtonDraw.UseVisualStyleBackColor = true;
            ButtonDraw.Click += ButtonDraw_Click;
            // 
            // RedRadBut
            // 
            RedRadBut.AutoSize = true;
            RedRadBut.Location = new Point(169, 12);
            RedRadBut.Name = "RedRadBut";
            RedRadBut.Size = new Size(90, 24);
            RedRadBut.TabIndex = 2;
            RedRadBut.TabStop = true;
            RedRadBut.Text = "красный";
            RedRadBut.UseVisualStyleBackColor = true;
            // 
            // BlueRadBut
            // 
            BlueRadBut.AutoSize = true;
            BlueRadBut.Location = new Point(169, 42);
            BlueRadBut.Name = "BlueRadBut";
            BlueRadBut.Size = new Size(73, 24);
            BlueRadBut.TabIndex = 3;
            BlueRadBut.TabStop = true;
            BlueRadBut.Text = "синий";
            BlueRadBut.UseVisualStyleBackColor = true;
            // 
            // NumericY
            // 
            NumericY.Location = new Point(91, 101);
            NumericY.Name = "NumericY";
            NumericY.Size = new Size(73, 27);
            NumericY.TabIndex = 5;
            // 
            // NumericX
            // 
            NumericX.Location = new Point(12, 101);
            NumericX.Name = "NumericX";
            NumericX.Size = new Size(73, 27);
            NumericX.TabIndex = 7;
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(33, 78);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(18, 20);
            XLabel.TabIndex = 9;
            XLabel.Text = "X";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(113, 78);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(17, 20);
            YLabel.TabIndex = 10;
            YLabel.Text = "Y";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 427);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Controls.Add(NumericX);
            Controls.Add(NumericY);
            Controls.Add(BlueRadBut);
            Controls.Add(RedRadBut);
            Controls.Add(ButtonDraw);
            Controls.Add(ComboColorBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumericY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboColorBox;
        private Button ButtonDraw;
        private RadioButton RedRadBut;
        private RadioButton BlueRadBut;
        private NumericUpDown NumericY;
        private NumericUpDown NumericX;
        private Label XLabel;
        private Label YLabel;
    }
}
