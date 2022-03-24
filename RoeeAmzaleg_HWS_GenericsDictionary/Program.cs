
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoeeAmzaleg_HWS_GenericsDictionary
{

    public class Program
    {
        static void Main(string[] args)
        {
            #region Library

            Dictionary<int,Book > books = new Dictionary<int, Book>();
            books.Add(1, new Book("martinValliant", "Warwick Deeping", EnumBookCategory.Romance));
            books.Add(2, new Book("theBlackTiger", "Patrick O'Connor ", EnumBookCategory.Fiction));
            books.Add(3, new Book("theJazzSinger", "Samson Raphaelson", EnumBookCategory.Drama));

            #endregion
        }



    }




}
