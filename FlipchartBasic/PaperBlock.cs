using System.Collections.Generic;

namespace FlipchartBasic
{
    public class PaperBlock
    {
        public int NumberOfPages { get; private set; }
        public int CurrentPage { get; set; }
        public int NumberOfRestPage { get; private set; }
        private readonly List<string> Notes = new List<string>();

        public PaperBlock(int numberOfPages, int currentPage = 1)
        {
            NumberOfPages = numberOfPages;
            CurrentPage = currentPage;
            NumberOfRestPage = NumberOfPages - CurrentPage;
        }

        public void AddNote(string note)
        {
            Notes.Add(note);
        }

        public List<string> GetNotes()
        {
            return Notes;
        }

        public void RemovePaper(Paper paper)
        {
            CurrentPage--;
            NumberOfPages--;
        }

        public override string ToString()
        {
            return $"Current page: {CurrentPage}";
        }
    }
}
