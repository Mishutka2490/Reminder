using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 1) удалены лишние функции из loadFormDisk(),
    связанные с выдачей информации о колличестве считаных заметок
    требуемой для отладки на этапе разработки
 2) удалены лишние функции из saveToDisk(),
    связанные с выдачей информации о колличестве записаных заметок
    требуемой для отладки на этапе разработки
 */

namespace Reminder {
    class NotesController {
        private List<Note> notes; //коллекция, содержащая объекты заметок
        private const string notesBaseName = "NotesBase.db"; //имя файла базы на диске
        
        //базовый конструктор
        public NotesController() {
            notes = new List<Note>();
            loadFromDisk();
        }

        //добавление заметки по тексту заметки и даты окончания
        public void addNote(string name, string text, DateTime date) {
            notes.Add(new Note(name, text, date));
        }

        //добавление через объект заметки, созданный заранее
        public void addNote(Note n) {
            notes.Add(n);
        }

        //возврат всех заметок в массиве
        public Note[] getNotes() {
            return notes.ToArray();
        }

        //получение заметки по индексу
        public Note getNote(string name) {
            foreach (Note n in notes) {
                if (n.getName() == name)
                    return n;
            }
            return null;
        }

        //удаление заметки по имени
        public bool deleteNote(string name) {
            for (int i = 0; i < notes.Count; i++) {
                if (notes[i].getName() == name) {
                    notes.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        //загрузка заметки с диска
        public void loadFromDisk() {
            //считываем сериализованные строки заметок
            //и добавляем созданные объекты в коллекцию
            if (File.Exists(notesBaseName)) {
                foreach (string line in File.ReadAllLines(notesBaseName)) {
                    notes.Add(new Note(line));
                }
            }
        }

        //сохранение заметки на диск
        public void saveToDisk() {
            //удаляем предыдущий файл базы, если существует
            if (File.Exists(notesBaseName)) 
                File.Delete(notesBaseName);

            //создаем средства для записи, записываем заметки
            StreamWriter sw = new StreamWriter(File.Create(notesBaseName));
            List<string> to_write = new List<string>();
            foreach (Note n in notes) {
                sw.WriteLine(n.serialize());
            }

            //записываем буфер записи, закрываем поток
            sw.Flush();
            sw.Close();
        }

        //обновления данных заметки
        public bool updateNote(string name, string text, DateTime date) {
            for (int i = 0; i < notes.Count; i++) {
                if (notes[i].getName() == name) {
                    notes[i].setText(text);
                    notes[i].setDate(date);
                    return true;
                }
            }
            return false;
        }

        //получения коллекции устаревших заметок (текущая дата > даты заметки)
        public List<Note> getOldNotes() {
            List<Note> oldNotes = new List<Note>();
            foreach (Note note in notes) {
                if (note.getDate() < DateTime.Now) {
                    oldNotes.Add(note);
                }
            }
            return oldNotes;
        }

    }
}
