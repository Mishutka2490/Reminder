using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1) удаление getFormatNote() в связи с отсутствием использования
 */

namespace Reminder {
    class Note {
        string name;
        private string text;
        private DateTime date;

        //конструктор с текста заметки и даты
        public Note(string name, string text, DateTime date) {
            this.name = name;
            this.text = text;
            this.date = date;
        }

        //конструктор с сериазизованной строки
        public Note(string param) {
            string[] arr = param.Split(new string[] { "%%%%%" }, StringSplitOptions.None);
            name = arr[0];
            text = arr[1];
            date = DateTime.FromBinary(Convert.ToInt64(arr[2]));
        }

        //сериализация данных в строку для записи
        public string serialize() {
            return name + "%%%%%" + text + "%%%%%" + date.ToBinary().ToString();
        }

        //получение форматированной строки
        public override string ToString() {
            return name;
        }

        //getters and setters for class variables
        public string getName(){ return name; }
        public string getText() { return text; }
        public void setText(string text) { this.text = text; }
        public DateTime getDate() { return date; }
        public void setDate(DateTime date) { this.date = date; }
        //end of get-set methods

    }
}
