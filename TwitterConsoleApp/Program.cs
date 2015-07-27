using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var twitter = new Twitter
            {
                OAuthConsumerKey = "AFYOwlijtZRkJI5AwwMsFFvl8",
                OAuthConsumerSecret = "2aUM9J5xuDNrvNU4FoEYGcMyKtbD1MCTi4KR5TGX9g6CrNqdeY"
            };

            IEnumerable<string> tweets = twitter.GetTweets("lukekava", 10).Result;

            foreach (var t in tweets)
            {
                Console.WriteLine(t+"\n");
            }

            Console.ReadKey();

          }
        }
    }

