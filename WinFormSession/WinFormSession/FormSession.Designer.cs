namespace WinFormSession
{
    partial class FormSession
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
            this.listBoxExams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonSetDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxExams
            // 
            this.listBoxExams.FormattingEnabled = true;
            this.listBoxExams.Location = new System.Drawing.Point(59, 80);
            this.listBoxExams.Name = "listBoxExams";
            this.listBoxExams.Size = new System.Drawing.Size(220, 329);
            this.listBoxExams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список предметов";
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Location = new System.Drawing.Point(348, 104);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(152, 23);
            this.buttonAddSubject.TabIndex = 2;
            this.buttonAddSubject.Text = "Добавить предмет";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonSetDate
            // 
            this.buttonSetDate.Location = new System.Drawing.Point(348, 168);
            this.buttonSetDate.Name = "buttonSetDate";
            this.buttonSetDate.Size = new System.Drawing.Size(152, 23);
            this.buttonSetDate.TabIndex = 3;
            this.buttonSetDate.Text = "Добавить дату";
            this.buttonSetDate.UseVisualStyleBackColor = true;
            this.buttonSetDate.Click += new System.EventHandler(this.buttonSetDate_Click);
            // 
            // FormSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.buttonSetDate);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxExams);
            this.Name = "FormSession";
            this.Text = "Сессия 11 группа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonSetDate;
    }
}

