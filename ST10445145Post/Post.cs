using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10445145Post
{
    public class Post
    {
        private int _id;
        private string _content;
        private int _likes;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public int Likes
        {
            get { return _likes; }
            set { _likes = value; }
        }
    }
}
