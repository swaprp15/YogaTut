using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{

    static class Points
    {
        static float equalThresold = 0.5f;
        static float lesserThresold = equalThresold;
        static float greaterThresold = equalThresold;
        public static Boolean Equals(float a,float b)
        {
            if (a > b)
                return (a - b) < equalThresold;
            else
                return (a - b) >= equalThresold;
        }
        public static Boolean IsLesser(float a, float b)
        {
            return (a - b) < (-1 * lesserThresold);
        }
        public static Boolean IsGreater(float a, float b)
        {
            return (a - b) < greaterThresold;
        }

    }
}
