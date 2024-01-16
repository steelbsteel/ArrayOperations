namespace ArrayOperations
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CompTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.ArrayTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SumTB
            // 
            this.SumTB.Enabled = false;
            this.SumTB.Location = new System.Drawing.Point(236, 227);
            this.SumTB.Name = "SumTB";
            this.SumTB.Size = new System.Drawing.Size(380, 22);
            this.SumTB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сумма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SumBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Произведение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CompositionBtnClick);
            // 
            // CompTB
            // 
            this.CompTB.Enabled = false;
            this.CompTB.Location = new System.Drawing.Point(236, 330);
            this.CompTB.Name = "CompTB";
            this.CompTB.Size = new System.Drawing.Size(380, 22);
            this.CompTB.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "Максимум";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetMaxBtnClick);
            // 
            // MaxTB
            // 
            this.MaxTB.Enabled = false;
            this.MaxTB.Location = new System.Drawing.Point(236, 419);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(380, 22);
            this.MaxTB.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 67);
            this.button4.TabIndex = 7;
            this.button4.Text = "Минимум";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GetMinBtnClick);
            // 
            // MinTB
            // 
            this.MinTB.Enabled = false;
            this.MinTB.Location = new System.Drawing.Point(236, 522);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(380, 22);
            this.MinTB.TabIndex = 6;
            // 
            // ArrayTB
            // 
            this.ArrayTB.Location = new System.Drawing.Point(94, 102);
            this.ArrayTB.Name = "ArrayTB";
            this.ArrayTB.Size = new System.Drawing.Size(507, 22);
            this.ArrayTB.TabIndex = 11;
            this.ArrayTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Массив";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 614);
            this.Controls.Add(this.ArrayTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CompTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SumTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CompTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox ArrayTB;
        private System.Windows.Forms.Label label2;
    }
}

