using System;
using System.Collections.Generic;
using System.Text;

namespace stackoverflowmodel
{
    public class Post
    {
        public int Votecount { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }



        public void Upvote()
        {
            Votecount++;
        }

        public void Downvote()
        {
            Votecount--;
        }
        
        public void Createpost()
        {
            Console.WriteLine("whats is on your mind: ");
            var userpost = Console.ReadLine();
        }

        public void printpost()
        {
            //Console.WriteLine("date posted: {0}", CreatedTime.ToLongDateString());
            //Console.WriteLine();
            Console.WriteLine(Title);
            Console.WriteLine();
            Console.WriteLine(Description);
            Console.WriteLine();
            Console.WriteLine("votes: {0}", Votecount);
        }


    }
}
