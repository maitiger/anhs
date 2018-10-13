using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Entity
{
    class Song
    {
        private string _id;
        private string _songname;
        private string _songthumnail;
        private string _singer;
        private string _songt;

        public string songname { get => _songname; set => _songname = value; }
        public string songthumnail { get => _songthumnail; set => _songthumnail = value; }
        public string singer { get => _singer; set => _singer = value; }
        public string songt { get => _songt; set => _songt = value; }
        public string id { get => _id; set => _id = value; }
    }
}
