using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_GenericsDictionary
{
    public class Book
    {
        private BookStory bookStory;
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public EnumBookCategory Category { get; private set; }

        public Book(string title, string author, EnumBookCategory category)
        {
            Title = title;
            Content = bookStory.BookText(this);
            Author = author;
            Category = category;
        }
        public override string ToString()
        {
            return $"Book: {Title}\n" +     
                $"Written By: {Author}\n" +
                $"Category: {Category}\n";
        }

        private class BookStory
        {
            public string theJazzSinger = "DARLENE: (Laughs) So you never knew that she took out your name " +
                                       "and put Priscilla’s and my name in there.It’s themoney that she had in there we used to" +
                                       " bury her.We are using the balance to send Wella to school. BANJO: (Stands up) Both of you are lying." +
                                       " The amount of money that was in the account would bury Roselyn and still leave money to educate Wella" +
                                       " up to University level. I bet that it will soon finish.I bet that both of you went in there and used it" +
                                       " off.When it finishes, don’t come to me for any money for Wella.I’m going to the bank on Monday to find out about it.";


            public string theBlackTiger = "He sighed, reached for one of a number of remarkablydirtyrags on the workbench," +
                                        " and thrust it into the float chamberof the carburetor.He'd have used a clean rag if one was available." +
                                        " Clean rags were delivered every Monday to the McNess UnionService Station, but Mondays were Woody's days" +
                                        " off.Whenhearrived for work on Tuesday the rags were all uniformlydirty. This was one of the minor" +
                                        " oddities about the service stationthat Woody had long ago ceased to trouble himself over.";

            public string martinValliant = "Brother Geraint had no care for any of these things. Heswungalong toward Paradise like a dog returning froman adventure," +
                                        " his fat chin showing white under his cowl, his arms foldedacross his chest." +
                                        " The cluster of hovels and cottages thatstretched between the river and the priory gate was discreetlydark and silent," +
                                        " with no Peeping Tomto watch the devoutfigure moving between the hedges " +
                                        "and under the orchardtrees. Paradise slept peacefully in its v";
            public string BookText(Book book)
            {
                if (book.Title == "theJazzSinger")
                {
                    return theJazzSinger;
                }
                if (book.Title == "theBlackTiger")
                {
                    return theBlackTiger;
                }
                if (book.Title == "martinValliant")
                {
                    return martinValliant;
                }
                else
                {
                    return null;
                }

            }

        }
    }
}
