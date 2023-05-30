using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem
{
    internal class Question
    {
        public int Id { get; set; }

        //private byte[] Picture;

        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public Question() { }

        public Question(int Id, string Text, string Answer1, string Answer2, string Answer3, string Answer4)
        {
            this.Id = Id;
            //this.Picture = Picture;
            this.Text = Text;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
        }
    }
}
