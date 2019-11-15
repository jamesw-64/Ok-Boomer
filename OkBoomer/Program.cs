using System;

namespace OkBoomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //thanks Reddit: https://www.reddit.com/r/NavySealCopypasta/comments/8xeqar/civil_discoursebaby_boomer_copypasta/
            const string s = "What on earth did you just snark at me, you lazy millennial? I'll have you know I am a top member of my homeowner's association, and I've received numerous pre-screened offers for ultra-premium credit cards, and I have over 300 cleared transactions. I was brought up in a culture of civility and I'm the most respected mediator of lunch-related conflicts in the entire HR department. You are nothing to me but just another entitled youth. I will tell you how my attitude and hard work led to my success with precision the likes of which has never been seen before on this Earth, you listen and you listen good. You think you can get away with purchasing avocado toast and still afford a down payment? Think again, child. As we speak I am logged into my 401k and my returns are outpacing your base wage so you better prepare for the right to work, freeloader. The legislation that wipes out the pathetic thing you call organized labor. You're out in the cold, kid. I can get any job, anytime, and I can attach over seven hundred references to my resume, and that's just with my LinkedIn network. Not only do I have twenty years of experience, but I have access to all the equipment in my father in-law's tool shed and I will use it to its full extent to reduce the height of your miserable oleander to the 3.5 feet above grade mandated by local ordinance, you little disappointment. If only you could have known what civil discourse your whiny disrespect was about to bring down upon you, maybe you would have held your cultural marxism. But you couldn't, you didn't, and now you're paying the price, you sorry barista. I will reply to every one of your comments with supreme confidence and the connection to whatever you were angry about will be tenuous at best. You're hopelessly unemployable, kiddo.";

            foreach (char c in s)
            {
                Console.Write(c);
                if (c.Equals(','))
                {
                    System.Threading.Thread.Sleep(500);
                }
                if (c.Equals('.') || c.Equals('?') || c.Equals('!'))
                {
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    System.Threading.Thread.Sleep(rnd.Next(10, 100));
                }
            }
        }
    }
}
