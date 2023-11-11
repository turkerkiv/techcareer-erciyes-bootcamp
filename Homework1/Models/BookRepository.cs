using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Homework1.Models
{
    public class BookRepository
    {
        private static List<Book> _books;
        public static List<Book> Books
        {
            get
            {
                return _books;
            }
        }

        static BookRepository()
        {
            _books = new List<Book>(){
                new Book(1, "In Search Of Lost Time", "Marcel Proust", "https://d3i5mgdwi2ze58.cloudfront.net/7hqv6ddaqv363p4hadx6lymotow1"),
                new Book(2, "Ulysses", "James Joyce", "https://d3i5mgdwi2ze58.cloudfront.net/f7nkbyqfsnrrlct3hs01jkrz2vdi"),
                new Book(3, "Don Quixote", "Miguel De Cervantes", "https://d3i5mgdwi2ze58.cloudfront.net/gvx0r9lfgd8w3mm2ef7vssyi2aaz"),
                new Book(4, "One Hundred Years Of Solitude", "Gabriel Garcia Marquez", "https://d3i5mgdwi2ze58.cloudfront.net/evtw45j15ooutm5tnz3ev1r9lk0e"),
                new Book(5, "The Great Gatsby", "F. Scott Fitzgerald", "https://d3i5mgdwi2ze58.cloudfront.net/4hkku1sl8y3fh8ggaazav5o65uqp"),
            };
        }

        public static List<Book> GetBookByName(string word)
        {
            List<Book> result = BookRepository.Books.Where(b => b.Name.ToLower().Split(" ").Contains(word.ToLower())).ToList();
            return result;
        }
    }
}