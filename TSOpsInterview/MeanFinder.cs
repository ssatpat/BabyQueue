using System;
using System.Collections.Generic;
using System.Text;

namespace TSOpsInterview
{
    public class MeanFinder
    {
        private Queue<int> myQueue;

        /***
         * You are attempting to keep track of the rolling mean over a fixed window of a 
         * sequence of integers.
         * 
         * This MeanFinder() class implements two methods - AddNumber(int) and FindMean()
         * 
         * AddNumber takes an integer and adds to the queue which has predetermined size.
         * Once the queue is full, it removes the first element of the queue and inserts
         * the incoming number at the end.
         * 
         * FindMean attempts to find the mean of this rolling window and returns the
         * current mean to the caller.
         * 
         * ***/


        public MeanFinder(int window)
        {
            myQueue = new Queue<int>(window);
        }

        public void AddNumber(int num)
        {
            if (myQueue.Count < 3)
            {
                myQueue.Enqueue(num);
            }
            else
            {
                myQueue.Dequeue();
                myQueue.Enqueue(num);
            }
        }

        public double FindMean()
        {
            int mean = 0;
            int sum = 0;
            foreach (int val in myQueue)
            {
                sum += val;
            }
            mean = sum / myQueue.Count;

            return mean;
        }
    }
}
