using System;

namespace Coaching
{
    class CoachingTest
    {
        static void Main(string[] args)
        {
            // Create new coaching object and display the details to console
            Coaching Coach1 = new Coaching("Cricket", 23, "9 am", 95);
            Coach1.DisplayDetails();
        }
    }
}
