using System;

namespace EssentialExtensions
{
    /// <summary>
    /// Common string checks and conversion methods
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Shorthand version of <see cref="string"/>.IsNullOrWhiteSpace(str) method
        /// </summary>
        /// <param name="str"><see cref="string"/> value to check</param>
        /// <returns>Returns true or false</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Shorthand and more explicit version of !<see cref="string"/>.IsNullOrWhiteSpace(str) method
        /// </summary>
        /// <param name="str"><see cref="string"/> value to check</param>
        /// <returns>Returns true or false</returns>
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Converts a <see cref="string"/> value to an <see cref="int"/>. If value cannot be
        /// converted, zero is returned.
        /// </summary>
        /// <param name="str"><see cref="string"/> value to convert</param>
        /// <returns><see cref="string"/> value as <see cref="int"/> or zero</returns>
        public static int ToIntOrDefault(this string str)
        {
            return int.TryParse(str, out var value) ? value : 0;
        }

        /// <summary>
        /// Converts a <see cref="string"/> value to an <see cref="int"/>. If value cannot be
        /// converted, an <see cref="ArgumentException"/> is thrown
        /// </summary>
        /// <param name="str"><see cref="string"/> value to convert</param>
        /// <returns>value as <see cref="int"/> or <see cref="ArgumentException"/></returns>
        public static int ToIntOrError(this string str)
        {
            return int.TryParse(str, out var value)
                ? value
                : throw new ArgumentException($"{str} cannot be converted to an integer.");
        }

        /// <summary>
        /// Converts a <see cref="string"/> to a <see cref="bool"/>. If value cannot be converted to
        /// a <see cref="bool"/>, false is returned.
        /// </summary>
        /// <param name="str"><see cref="string"/> value to convert</param>
        /// <returns>Returns true or false. default if false</returns>
        public static bool ToBoolOrDefault(this string str)
        {
            switch (str)
            {
                case "1":
                    return true;
                case "0":
                    return false;
                default:
                    return bool.TryParse(str, out var value) && value;
            }
        }

        /// <summary>
        /// Converts a <see cref="string"/> to a <see cref="bool"/>.
        /// If value cannot be converted to a <see cref="bool"/>, an <see cref="ArgumentException"/> is thrown
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Returns true or false or <see cref="ArgumentException"/> on "bad" value.</returns>
        public static bool ToBoolOrError(this string str)
        {
            return bool.TryParse(str, out var value)
                ? value
                : throw new ArgumentException($"{str} cannot be converted to a boolean.");
        }
    }
}