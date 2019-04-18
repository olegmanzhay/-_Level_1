namespace Homework5
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
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Surname1,
            this.Course1,
            this.Age1});
            this.dataStudent.Location = new System.Drawing.Point(21, 12);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.Size = new System.Drawing.Size(444, 184);
            this.dataStudent.TabIndex = 0;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Имя";
            this.Name1.Name = "Name1";
            // 
            // Surname1
            // 
            this.Surname1.HeaderText = "Фамилия";
            this.Surname1.Name = "Surname1";
            // 
            // Course1
            // 
            this.Course1.HeaderText = "Курс";
            this.Course1.Name = "Course1";
            // 
            // Age1
            // 
            this.Age1.HeaderText = "Возраст";
            this.Age1.Name = "Age1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(316, 220);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 35);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить базу";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(68, 220);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(118, 35);
            this.btnXML.TabIndex = 2;
            this.btnXML.Text = "Cоздать файл XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 267);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXML;
    }
}

