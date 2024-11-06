namespace WindowsFormsApp1
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
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.textBoxWindowTitle = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelAction = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.textBoxNewTitle = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Location = new System.Drawing.Point(141, 9);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(151, 13);
            this.labelWindowTitle.TabIndex = 0;
            this.labelWindowTitle.Text = "Заголовок окна для поиска:";
            // 
            // textBoxWindowTitle
            // 
            this.textBoxWindowTitle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWindowTitle.Location = new System.Drawing.Point(144, 54);
            this.textBoxWindowTitle.Name = "textBoxWindowTitle";
            this.textBoxWindowTitle.Size = new System.Drawing.Size(115, 20);
            this.textBoxWindowTitle.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(144, 102);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 50);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти окно";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);  // Добавлен обработчик события
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(141, 182);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(110, 13);
            this.labelAction.TabIndex = 3;
            this.labelAction.Text = "Выберите действие:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Изменить заголовок",
            "Закрыть окно"});
            this.comboBoxAction.Location = new System.Drawing.Point(144, 218);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(123, 21);
            this.comboBoxAction.TabIndex = 4;
            // 
            // textBoxNewTitle
            // 
            this.textBoxNewTitle.Location = new System.Drawing.Point(144, 277);
            this.textBoxNewTitle.Name = "textBoxNewTitle";
            this.textBoxNewTitle.Size = new System.Drawing.Size(108, 20);
            this.textBoxNewTitle.TabIndex = 5;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(144, 337);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(125, 28);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);  // Добавлен обработчик события
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxNewTitle);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxWindowTitle);
            this.Controls.Add(this.labelWindowTitle);
            this.Name = "Form1";
            this.Text = "Window Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.TextBox textBoxWindowTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.TextBox textBoxNewTitle;
        private System.Windows.Forms.Button buttonExecute;
    }
}

