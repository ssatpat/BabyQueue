using System;

namespace TSOpsInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            MeanFinder myMeanFinder = new MeanFinder(3);
           
            myMeanFinder.AddNumber(1);
            myMeanFinder.AddNumber(2);
            double myFirstMean = myMeanFinder.FindMean();
            Console.WriteLine(myFirstMean);

            myMeanFinder.AddNumber(3);
            double mySecondMean = myMeanFinder.FindMean();
            Console.WriteLine(mySecondMean);

            myMeanFinder.AddNumber(4);
            double myThirdMean = myMeanFinder.FindMean();
            Console.WriteLine(myThirdMean);

            myMeanFinder.AddNumber(5);
            double myFourthMean = myMeanFinder.FindMean();
            Console.WriteLine(myFourthMean);



        }
    }
}
