using System;

namespace Interpolations
{
    public static class InterpolationUtility
    {
        public static float EaseInBack(float value)
        {
            return EaseInBack(value, 1.70158f);
        }

        public static float EaseInBack(float value, float period)
        {
            var s = period + 1;
            return s * value * value * value - period * value * value;
        }

        public static float EaseOutBack(float value)
        {
            return EaseOutBack(value, 1.70158f);
        }

        public static float EaseOutBack(float value, float period)
        {
            var s = period + 1;
            return (float)(1 + s * Math.Pow(value - 1, 3) + period * Math.Pow(value - 1, 2));
        }

        public static float Linear(float value)
        {
            return value;
        }
    }
}