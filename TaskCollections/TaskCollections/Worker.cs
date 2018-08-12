using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCollections
{
    class Worker
    {
        public string FullName { get; set; }
        public string Post { get; set; }
        public int Position { get; set; }

        public Worker(string FullName, string Post, int Position)
        {
            this.FullName = FullName;
            this.Post = Post;
            this.Position = Position;
        }
    }
}
