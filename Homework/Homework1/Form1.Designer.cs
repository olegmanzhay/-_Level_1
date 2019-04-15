namespace Homework1
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
            this.btnDateTime = new System.Windows.Forms.Button();
            this.rtxtDateTime = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(169, 248);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(157, 83);
            this.btnDateTime.TabIndex = 2;
            this.btnDateTime.Text = "Получить Свойства и Методы";
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click_1);
            // 
            // rtxtDateTime
            // 
            this.rtxtDateTime.Location = new System.Drawing.Point(42, 12);
            this.rtxtDateTime.Name = "rtxtDateTime";
            this.rtxtDateTime.Size = new System.Drawing.Size(414, 217);
            this.rtxtDateTime.TabIndex = 1;
            this.rtxtDateTime.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 343);
            this.Controls.Add(this.rtxtDateTime);
            this.Controls.Add(this.btnDateTime);
            this.Name = "Form1";
            this.Text = "Задача1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.RichTextBox rtxtDateTime;
    }
}

