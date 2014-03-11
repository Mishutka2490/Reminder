namespace Reminder {
    partial class Form1 {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.noteTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.noteDatePicker = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highlightOldNotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesListBox
            // 
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.Location = new System.Drawing.Point(8, 25);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(158, 186);
            this.notesListBox.TabIndex = 0;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заметки";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(172, 25);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(238, 186);
            this.noteTextBox.TabIndex = 2;
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(8, 263);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(158, 40);
            this.addNoteButton.TabIndex = 3;
            this.addNoteButton.Text = "Добавить заметку";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Location = new System.Drawing.Point(8, 217);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(158, 40);
            this.deleteNoteButton.TabIndex = 4;
            this.deleteNoteButton.Text = "Удалить заметку";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // noteTimePicker
            // 
            this.noteTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.noteTimePicker.Location = new System.Drawing.Point(176, 232);
            this.noteTimePicker.Name = "noteTimePicker";
            this.noteTimePicker.ShowUpDown = true;
            this.noteTimePicker.Size = new System.Drawing.Size(70, 20);
            this.noteTimePicker.TabIndex = 6;
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.Location = new System.Drawing.Point(8, 309);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(158, 40);
            this.saveNoteButton.TabIndex = 7;
            this.saveNoteButton.Text = "Сохранить заметку";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // noteDatePicker
            // 
            this.noteDatePicker.Location = new System.Drawing.Point(254, 232);
            this.noteDatePicker.MaxSelectionCount = 1;
            this.noteDatePicker.Name = "noteDatePicker";
            this.noteDatePicker.ShowWeekNumbers = true;
            this.noteDatePicker.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата";
            // 
            // highlightOldNotesButton
            // 
            this.highlightOldNotesButton.Location = new System.Drawing.Point(8, 355);
            this.highlightOldNotesButton.Name = "highlightOldNotesButton";
            this.highlightOldNotesButton.Size = new System.Drawing.Size(158, 40);
            this.highlightOldNotesButton.TabIndex = 9;
            this.highlightOldNotesButton.Text = "Показать прошедшие";
            this.highlightOldNotesButton.UseVisualStyleBackColor = true;
            this.highlightOldNotesButton.Click += new System.EventHandler(this.highlightOldNotesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 404);
            this.Controls.Add(this.highlightOldNotesButton);
            this.Controls.Add(this.noteDatePicker);
            this.Controls.Add(this.saveNoteButton);
            this.Controls.Add(this.noteTimePicker);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.DateTimePicker noteTimePicker;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.MonthCalendar noteDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button highlightOldNotesButton;
    }
}

