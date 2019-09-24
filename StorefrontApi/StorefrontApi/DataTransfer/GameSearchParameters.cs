using System;
using System.Collections.Generic;

namespace StorefrontApi.DataTransfer
{
    public class GameSearchParameters
    {
        public string SearchTerm { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public uint Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> Tags { get; set; }
    }
}
