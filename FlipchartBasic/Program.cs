﻿using System;

namespace FlipchartBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Flipchart flipchart = new Flipchart();
            flipchart.AddPaperBlock(20);
            flipchart.WriteNote("First note.");
            flipchart.WriteNote("Second note.");
            flipchart.WriteNote("Third note.");
            flipchart.PagingPaperBlock();
            flipchart.ReadNotes();
            flipchart.PrintNotes();
            flipchart.WriteNote("Fourth note");
            flipchart.ReadNotes();
            flipchart.PrintNotes();
            for (int i = 0; i < 20; i++) //Test the exception
            {
                flipchart.PagingPaperBlock();
            }
            flipchart.PrintNotes();
            Console.ReadKey();
        }
    }
}
