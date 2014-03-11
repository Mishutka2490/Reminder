using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Reminder {
    class NotesController {
        private List<Note> notes;
        private const string notesBaseName = "NotesBase.db";
        
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
        public int loadFromDisk() {
            string[] lines;

            if (File.Exists(notesBaseName)) {
                lines = File.ReadAllLines(notesBaseName);
                foreach (string line in lines) {
                    notes.Add(new Note(line));
                }
                return lines.Length;
            } else {
                return 0;
            }
        }

        //сохранение заметки на диск
        public int saveToDisk() {
            if (File.Exists(notesBaseName)) 
                File.Delete(notesBaseName);
            StreamWriter sw = new StreamWriter(File.Create(notesBaseName));
            List<string> to_write = new List<string>();
            foreach (Note n in notes) {
                sw.WriteLine(n.serialize());
            }
            sw.Flush();
            sw.Close();
            return notes.Count;
        }

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
