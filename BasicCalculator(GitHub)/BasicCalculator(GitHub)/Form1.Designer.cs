namespace BasicCalculator_GitHub_
{
    partial class Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.ceroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.cEntryButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ceroButton
            // 
            this.ceroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceroButton.Location = new System.Drawing.Point(12, 268);
            this.ceroButton.Name = "ceroButton";
            this.ceroButton.Size = new System.Drawing.Size(126, 60);
            this.ceroButton.TabIndex = 0;
            this.ceroButton.Text = "0";
            this.ceroButton.UseVisualStyleBackColor = true;
            this.ceroButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(144, 268);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(60, 60);
            this.decimalButton.TabIndex = 2;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(210, 268);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(60, 60);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operat_clicked);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(276, 202);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(60, 126);
            this.equalsButton.TabIndex = 4;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 202);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(60, 60);
            this.oneButton.TabIndex = 5;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(78, 202);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(60, 60);
            this.twoButton.TabIndex = 6;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(144, 202);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(60, 60);
            this.threeButton.TabIndex = 7;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(210, 202);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(60, 60);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operat_clicked);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 136);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(60, 60);
            this.fourButton.TabIndex = 10;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(78, 136);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(60, 60);
            this.fiveButton.TabIndex = 11;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(144, 136);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(60, 60);
            this.sixButton.TabIndex = 12;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(210, 136);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(60, 60);
            this.multButton.TabIndex = 13;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.operat_clicked);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(276, 136);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 60);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(12, 70);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(60, 60);
            this.sevenButton.TabIndex = 15;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(78, 70);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(60, 60);
            this.eightButton.TabIndex = 16;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(144, 70);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(60, 60);
            this.nineButton.TabIndex = 17;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.number_clicked);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.Location = new System.Drawing.Point(210, 70);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(60, 60);
            this.divButton.TabIndex = 18;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.operat_clicked);
            // 
            // cEntryButton
            // 
            this.cEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEntryButton.Location = new System.Drawing.Point(276, 70);
            this.cEntryButton.Name = "cEntryButton";
            this.cEntryButton.Size = new System.Drawing.Size(60, 60);
            this.cEntryButton.TabIndex = 19;
            this.cEntryButton.Text = "CE";
            this.cEntryButton.UseVisualStyleBackColor = true;
            this.cEntryButton.Click += new System.EventHandler(this.cEntryButton_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 38);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(324, 29);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.Location = new System.Drawing.Point(12, 9);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(0, 20);
            this.operationLabel.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 338);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.cEntryButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.ceroButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ceroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button cEntryButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label operationLabel;
    }
}

