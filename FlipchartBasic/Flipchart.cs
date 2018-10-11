using System;
using System.Collections.Generic;

namespace FlipchartBasic
{
    public class Flipchart
    {
        public int SerialNumber { get; private set; }
        private static int _Counter = 0;
        public PaperBlock MyPaperBlock { get; private set; }

        public Flipchart()
        {
            SerialNumber = _Counter++;
        }

        public void AddPaperBlock(int numberOfPages)
        {
            MyPaperBlock = new PaperBlock(numberOfPages);
        }

        public void PagingPaperBlock()
        {
            if (MyPaperBlock.CurrentPage >= MyPaperBlock.NumberOfPages)
            {
                throw new ArgumentException();
            }
            else
            {
            MyPaperBlock.CurrentPage++;
            }
        }

        public void WriteNote(string note)
        {
            MyPaperBlock.AddNote(note);
        }

        public List<string> ReadNotes()
        {
            return MyPaperBlock.GetNotes();
        }

        public void PrintNotes()
        {
            List<string> notes = MyPaperBlock.GetNotes();
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine(MyPaperBlock.ToString());
        }
    }
}
