namespace FlipchartBasic
{
    public class Paper
    {
        public string Note { get; private set; }

        public Paper(string note = null)
        {
            Note = note;
        }
    }
}
