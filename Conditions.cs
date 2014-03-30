using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    static class Conditions
    {
        static Boolean CloseEnough(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
            float avgx = 0, avgy = 0, avgz = 0;
            foreach (JointType jointType in joinList)
            {
                avgx += skeleton.Joints[jointType].Position.X;
                avgy += skeleton.Joints[jointType].Position.Y;
                avgz += skeleton.Joints[jointType].Position.Z;
            }
            avgx /= joinList.Count;
            avgy /= joinList.Count;
            avgz /= joinList.Count;
            foreach (JointType jointType in joinList)
            {
                if (!Points.Equals(skeleton.Joints[jointType].Position.X, avgx))
                {
                    return false;
                }
                if (!Points.Equals(skeleton.Joints[jointType].Position.Y, avgy))
                {
                    return false;
                }
                if (!Points.Equals(skeleton.Joints[jointType].Position.Z, avgz))
                {
                    return false;
                }
            }
            return true;
        }
        static Boolean CloseEnoughX(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
            float avgx = 0;
            foreach (JointType jointType in joinList)
            {
                avgx += skeleton.Joints[jointType].Position.X;
            }
            avgx /= joinList.Count;
            foreach (JointType jointType in joinList)
            {
                if (!Points.Equals(skeleton.Joints[jointType].Position.X, avgx))
                {
                    return false;
                }

            }
            return true;
        }
        static Boolean CloseEnoughY(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
            float avgy = 0;
            foreach (JointType jointType in joinList)
            {
                avgy += skeleton.Joints[jointType].Position.Y;
            }
            avgy /= joinList.Count;
            foreach (JointType jointType in joinList)
            {
                if (!Points.Equals(skeleton.Joints[jointType].Position.Y, avgy))
                {
                    return false;
                }

            }
            return true;
        }
        static Boolean CloseEnoughZ(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
            float avgz = 0;
            foreach (JointType jointType in joinList)
            {
                avgz += skeleton.Joints[jointType].Position.Y;
            }
            avgz /= joinList.Count;
            foreach (JointType jointType in joinList)
            {
                if (!Points.Equals(skeleton.Joints[jointType].Position.Z, avgz))
                {
                    return false;
                }

            }
            return true;
        }
        static Boolean IsLeft(Skeleton skeleton, JointType l,JointType r)
        {
            return Points.IsLesser(skeleton.Joints[l].Position.X, skeleton.Joints[r].Position.X);
        }
        static Boolean IsRight(Skeleton skeleton, JointType l, JointType r)
        {
            return Points.IsGreater(skeleton.Joints[l].Position.X, skeleton.Joints[r].Position.X);
        }
        static Boolean IsUp(Skeleton skeleton, JointType l, JointType r)
        {
            return Points.IsGreater(skeleton.Joints[l].Position.Y, skeleton.Joints[r].Position.Y);
        }
        static Boolean IsDown(Skeleton skeleton, JointType l, JointType r)
        {
            return Points.IsLesser(skeleton.Joints[l].Position.Y, skeleton.Joints[r].Position.Y);
        }
        static Boolean IsBehind(Skeleton skeleton, JointType l, JointType r)
        {
            return Points.IsGreater(skeleton.Joints[l].Position.Z, skeleton.Joints[r].Position.Z);
        }
        static Boolean IsInFrontOf(Skeleton skeleton, JointType l, JointType r)
        {
            return Points.IsLesser(skeleton.Joints[l].Position.Z, skeleton.Joints[r].Position.Z);
        }

        static Boolean SameX(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
        }
        static Boolean SameY(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
        }
        static Boolean SameZ(Skeleton skeleton, List<Microsoft.Kinect.JointType> joinList)
        {
        }


    }

}
