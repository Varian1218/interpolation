using System;

namespace Interpolations
{
    public static class InterpolationUtility
    {
        public static float EaseInBack(float val, float period = 1.70158f)
        {
            var s = period + 1;
            return s * val * val * val - period * val * val;
        }

        public static float EaseOutBack(float val, float period = 1.70158f)
        {
            var s = period + 1;
            return (float)(1 + s * Math.Pow(val - 1, 3) + period * Math.Pow(val - 1, 2));
        }

        public static float Linear(float value)
        {
            return value;
        }
    }
}