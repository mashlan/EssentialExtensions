
namespace EssentialExtensions
{
    /// <summary>
    /// Useful <see cref="int"/> extensions
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Returns the <see cref="int"/>? value or default value as a <see cref="string"/>
        /// </summary>
        /// <param name="integer"><see cref="int"/> object</param>
        /// <returns><see cref="string"/></returns>
        public static string ToDefaultString(this int? integer)
        {
            return integer.GetValueOrDefault().ToString();
        }

        /// <summary>
        /// Returns true if the <see cref="int"/> object's value is greater than the
        /// passed in <see cref="int"/> value, else false.
        /// </summary>
        /// <param name="integer"><see cref="int"/> object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsGreaterThan(this int integer, int value)
        {
            return integer > value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/>? object's value is greater than the
        /// passed in <see cref="int"/> value, else false. Null values also return false.
        /// </summary>
        /// <param name="integer"><see cref="int"/>? object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsGreaterThan(this int? integer, int value)
        {
            return integer.HasValue && integer.Value > value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/> object's value is less than the
        /// passed in <see cref="int"/> value, else false.
        /// </summary>
        /// <param name="integer"><see cref="int"/> object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLessThan(this int integer, int value)
        {
            return integer < value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/>? object's value is less than the
        /// passed in <see cref="int"/> value, else false. Null values also return false.
        /// </summary>
        /// <param name="integer"><see cref="int"/>? object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLessThan(this int? integer, int value)
        {
            return integer.HasValue && integer.Value < value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/> object's value is greater than or equal the
        /// passed in <see cref="int"/> value, else false.
        /// </summary>
        /// <param name="integer"><see cref="int"/> object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsGreaterThanOrEqual(this int integer, int value)
        {
            return integer >= value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/>? object's value is greater than or equal the
        /// passed in <see cref="int"/> value, else false. Null values also return false.
        /// </summary>
        /// <param name="integer"><see cref="int"/>? object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsGreaterThanOrEqual(this int? integer, int value)
        {
            return integer.HasValue && integer.Value >= value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/> object's value is less than or equal the
        /// passed in <see cref="int"/> value, else false.
        /// </summary>
        /// <param name="integer"><see cref="int"/> object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLessThanOrEqual(this int integer, int value)
        {
            return integer <= value;
        }

        /// <summary>
        /// Returns true if the <see cref="int"/>? object's value is less than or equal the
        /// passed in <see cref="int"/> value, else false. Null values also return false.
        /// </summary>
        /// <param name="integer"><see cref="int"/>? object</param>
        /// <param name="value"><see cref="int"/> value to compare</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLessThanOrEqual(this int? integer, int value)
        {
            return integer.HasValue && integer.Value <= value;
        }
    }
}