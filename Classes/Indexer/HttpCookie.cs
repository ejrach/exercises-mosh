using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    public class HttpCookie
    {
        //declare a dictionary which is like a hash table. In hash table, we look up things by a key, not an index.
        //Adding the readonly modifier because we only want one instance of Dictionary
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }    //to create autoimplemented property, start typing "prop" which is a code snippet


        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //declare an indexer
        public string this[string key]
        {
            get 
            {
                return _dictionary[key];
            }

            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
