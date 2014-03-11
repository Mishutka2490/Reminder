using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 refactoring:
 1) создание DateTime при создании заметки оптимизировано
    получение даты и времени с визуальных элементов вынесено в отдельный метод
 */ 

namespace Reminder {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        private NotesController notesController;

        private void Form1_Load(object sender, EventArgs e) {
            notesController = new NotesController();
            notesListBox.Items.AddRange(notesController.getNotes());
        }

        //функция добавления заметки
        private void addNoteButton_Click(object sender, EventArgs e) {
            noteTextBox.Clear();
            string added_name = null;
            using (GetNameForm nameForm = new GetNameForm()) { //создаем диалог получения имени
                nameForm.ShowDialog(); 
                if (nameForm.DialogResult == DialogResult.OK) {
                    string name = nameForm.getName();
                    foreach (Note n in notesController.getNotes()) { //проверяем, не дублируется ли имя
                        if (n.getName() == name) {
                            MessageBox.Show("Такое имя заметки существует!");
                            updateNotesList();
                            return;
                        }
                    }

                    //создаем заметку
                    string text = noteTextBox.Text;
                    DateTime date = generateDateTime(noteDatePicker, noteTimePicker);

                    //добавляем заметку в коллекцию
                    notesController.addNote(name, text, date);
                    added_name = name;
                    
                }
            }
            updateNotesList();
            notesListBox.SelectedItem = added_name;
        }

        //создание DateTime используя данные MonthCalendar и DateTimePicker
        private DateTime generateDateTime(MonthCalendar calender, DateTimePicker time) {
            int year = noteDatePicker.SelectionRange.Start.Year;
            int month = noteDatePicker.SelectionRange.Start.Month;
            int day = noteDatePicker.SelectionRange.Start.Day;
            int hour = noteTimePicker.Value.Hour;
            int minute = noteTimePicker.Value.Minute;
            int second = noteTimePicker.Value.Second;
            return new DateTime(year, month, day, hour, minute, second);
        }

        //обновить список имен в списке заметок
        private void updateNotesList() {
            if (notesListBox.SelectedItem != null) {
                string selected_item_name = notesListBox.SelectedItem.ToString();
                notesListBox.Items.Clear();
                notesListBox.Items.AddRange(notesController.getNotes());
                notesListBox.SelectedItem = selected_item_name;
            } else {
                notesListBox.Items.Clear();
                notesListBox.Items.AddRange(notesController.getNotes());
            }
        }

        //функция удаления заметки
        private void deleteNoteButton_Click(object sender, EventArgs e) {
            if (notesListBox.SelectedItem != null) {
                string name_to_delete = notesListBox.SelectedItem.ToString();
                notesController.deleteNote(name_to_delete);
                updateNotesList();
            }
        }

        //выбрана заметка в списке
        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (notesListBox.SelectedItem == null) {
                noteTextBox.Clear();
                noteTextBox.Enabled = false;
                noteDatePicker.Enabled = false;
                noteTimePicker.Enabled = false;
            } else {
                noteTextBox.Enabled = true;
                noteDatePicker.Enabled = true;
                noteTimePicker.Enabled = true;

                string selected_name = notesListBox.SelectedItem.ToString();
                Note note = notesController.getNote(selected_name);
                noteTextBox.Text = note.getText();
                noteDatePicker.SetDate(note.getDate());
                noteTimePicker.Value = note.getDate();
            }
        }

        //обновить текущую редактируюмую заметку, при нажатии сохраненияs
        private void saveNoteButton_Click(object sender, EventArgs e) {
            if (notesListBox.SelectedItem != null) {
                string name = notesListBox.SelectedItem.ToString();
                string text = noteTextBox.Text;
                DateTime date = generateDateTime(noteDatePicker, noteTimePicker);
                
                notesController.updateNote(name, text, date);
                updateNotesList();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            notesController.saveToDisk();
        }

        private void highlightOldNotesButton_Click(object sender, EventArgs e) {
            string names = "";
            foreach (Note note in notesController.getOldNotes()) {
                names += note.getName() + "\n";
            }
            MessageBox.Show(names);
        }


    }
}
