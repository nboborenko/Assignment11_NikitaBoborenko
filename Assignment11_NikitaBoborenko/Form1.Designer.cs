namespace Assignment11_NikitaBoborenko
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
            this.addBtn = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(242, 81);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(56, 19);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(2, 81);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(76, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // typeTextbox
            // 
            this.typeTextbox.Location = new System.Drawing.Point(82, 81);
            this.typeTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(76, 20);
            this.typeTextbox.TabIndex = 2;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(162, 81);
            this.ageTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(76, 20);
            this.ageTextbox.TabIndex = 3;
            // 
            // panelScreen
            // 
            this.panelScreen.Location = new System.Drawing.Point(0, 105);
            this.panelScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(591, 265);
            this.panelScreen.TabIndex = 4;
            this.panelScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelScreen_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.typeTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.addBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

