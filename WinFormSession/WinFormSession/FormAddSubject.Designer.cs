namespace WinFormSession
{
    partial class FormAddSubject
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
            this.buttonSaveSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveSubject
            // 
            this.buttonSaveSubject.Location = new System.Drawing.Point(49, 130);
            this.buttonSaveSubject.Name = "buttonSaveSubject";
            this.buttonSaveSubject.Size = new System.Drawing.Size(139, 23);
            this.buttonSaveSubject.TabIndex = 0;
            this.buttonSaveSubject.Text = "Сохранить предмет";
            this.buttonSaveSubject.UseVisualStyleBackColor = true;
            this.buttonSaveSubject.Click += new System.EventHandler(this.buttonSaveSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Впишите предмет";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(49, 79);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(139, 20);
            this.textSubject.TabIndex = 2;
            // 
            // FormAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 195);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveSubject);
            this.Name = "FormAddSubject";
            this.Text = "добавить предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSubject;
    }
}