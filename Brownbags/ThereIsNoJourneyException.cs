using System;

namespace Brownbags
{
    public class ThereIsNoJourneyException : Exception
    {
        private static string MESSAGE = "There is no journey";

        public ThereIsNoJourneyException() : base(MESSAGE)
        {
            
        }
    }
}