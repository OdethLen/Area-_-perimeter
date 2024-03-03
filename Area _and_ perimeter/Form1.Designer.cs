namespace Area__and__perimeter
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSide = new TextBox();
            txtApothem = new TextBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            btnCalculate = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Pentagon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Side:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 109);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Apothem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 162);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Area:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 191);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Perimeter:";
            // 
            // txtSide
            // 
            txtSide.Location = new Point(119, 71);
            txtSide.Name = "txtSide";
            txtSide.Size = new Size(100, 23);
            txtSide.TabIndex = 5;
            // 
            // txtApothem
            // 
            txtApothem.Location = new Point(119, 101);
            txtApothem.Name = "txtApothem";
            txtApothem.Size = new Size(100, 23);
            txtApothem.TabIndex = 6;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(119, 154);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 7;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(119, 188);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(100, 23);
            txtPerimeter.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("PMingLiU-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(243, 71);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // button2
            // 
            button2.Font = new Font("PMingLiU-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(243, 109);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("PMingLiU-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(243, 154);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 255);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCalculate);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(txtApothem);
            Controls.Add(txtSide);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSide;
        private TextBox txtApothem;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Button btnCalculate;
        private Button button2;
        private Button button3;
    }
}
