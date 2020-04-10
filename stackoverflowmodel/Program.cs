using System;

namespace stackoverflowmodel
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Post();

            Console.WriteLine("this is a post that models a stackoverflow post\n you can create a post, you can upvote and downvote a post\nyou can view your post also");
            Console.WriteLine();

            //Console.WriteLine("enter the word 'createpost' to craete a post");
            Console.WriteLine("enter your post: ");
            var input = Console.ReadLine();
            user.Title = input;
            Console.WriteLine();

            Console.WriteLine("enter post description");
            var describe = Console.ReadLine();
            user.Description = describe;
            Console.WriteLine();

            Console.WriteLine("you can upvote your post, enter 'vote' to upvote your post\n enter 'no vote' to downvote your post");
            var Like = Console.ReadLine();
            if (Like == "vote")
              {
                  user.Upvote();
              }
            else if (Like == "note vote")
              {
                  user.Downvote();
              }

            

            Console.WriteLine("congrat you have successfully create a post.\nenter 'print' to print post");
            var userpost = Console.ReadLine();
            if (userpost == "print")
            {
                user.printpost();
            }



        }
    }
}
