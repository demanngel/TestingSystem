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
        public byte[] Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int LB { get; }

        public Question() { }

        public Question(int Id, byte[] Text, string Answer1, string Answer2, string Answer3, string Answer4, int LB)
        {
            this.Id = Id;
            //this.Picture = Picture;
            this.Text = Text;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
            this.LB = LB;
        }
    }
}
