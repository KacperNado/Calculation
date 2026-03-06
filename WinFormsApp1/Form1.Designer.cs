namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            txtFirstNo = new TextBox();
            txtSecNo = new TextBox();
            Result = new Label();
            txtResult = new TextBox();
            Dodaj = new Button();
            Odejmij = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 92);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Pierwsza liczba";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Druga liczba";
            label2.Click += label2_Click;
            // 
            // txtFirstNo
            // 
            txtFirstNo.Location = new Point(230, 92);
            txtFirstNo.Name = "txtFirstNo";
            txtFirstNo.Size = new Size(155, 23);
            txtFirstNo.TabIndex = 2;
            // 
            // txtSecNo
            // 
            txtSecNo.Location = new Point(230, 121);
            txtSecNo.Name = "txtSecNo";
            txtSecNo.Size = new Size(154, 23);
            txtSecNo.TabIndex = 3;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(172, 182);
            Result.Name = "Result";
            Result.Size = new Size(39, 15);
            Result.TabIndex = 4;
            Result.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(231, 182);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(154, 23);
            txtResult.TabIndex = 5;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(231, 153);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(75, 23);
            Dodaj.TabIndex = 6;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // Odejmij
            // 
            Odejmij.Location = new Point(310, 153);
            Odejmij.Name = "Odejmij";
            Odejmij.Size = new Size(75, 23);
            Odejmij.TabIndex = 7;
            Odejmij.Text = "Odejmij";
            Odejmij.UseVisualStyleBackColor = true;
            Odejmij.Click += Odejmij_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Odejmij);
            Controls.Add(Dodaj);
            Controls.Add(txtResult);
            Controls.Add(Result);
            Controls.Add(txtSecNo);
            Controls.Add(txtFirstNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstNo;
        private TextBox txtSecNo;
        private Label Result;
        private TextBox txtResult;
        private Button Dodaj;
        private Button Odejmij;
    }
}
