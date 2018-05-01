using System;

namespace Mercator.Mathematics.Calculus
{
    /// <summary>
    /// 反双曲函数
    /// </summary>
    public class InverseHyperbolic
    {
        /// <summary>
        /// 反双曲正弦函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Asinh(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x + 1));
        }

        /// <summary>
        /// 反双曲余弦函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Acosh(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x - 1));
        }

        /// <summary>
        /// 反双曲正切函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Atanh(double x)
        {
            return Math.Log((1 + x) / (1 - x)) / 2;
        }

        /// <summary>
        /// 反双曲正割函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Asech(double x)
        {
            return Math.Log((Math.Sqrt(-x * x + 1) + 1) / x);
        }

        /// <summary>
        /// 反双曲余割函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Acsch(double x)
        {
            return Math.Log((Math.Sin(x) * Math.Sqrt(x * x + 1) + 1) / x);
        }

        /// <summary>
        /// 反双曲余切函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Acoth(double x)
        {
            return Math.Log((x + 1) / (x - 1)) / 2;
        }
    }
}
