using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Models
{
    public class Book
    {
        private int _id;
        private string _name;
        private string _author;
        private string _imgUrl;

        public int Id => _id;
        public string Name => _name;
        public string Author => _author;
        public string ImgUrl => _imgUrl;

        public Book(int id, string name, string author, string imgUrl)
        {
            _id = id;
            _name = name;
            _author = author;
            _imgUrl = imgUrl;
        }
    }
}