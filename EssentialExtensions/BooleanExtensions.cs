namespace EssentialExtensions
{
    /// <summary>
    /// Useful <see cref="bool"/> extensions
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Returns the <see cref="bool"/>? value or default as a string
        /// </summary>
        /// <param name="boolean"><see cref="bool"/>? value to convert</param>
        /// <returns><see cref="string"/></returns>
        public static string ToDefaultString(this bool? boolean)
        {
            return boolean.GetValueOrDefault().ToString();
        }

        /// <summary>
        /// Checks <see cref="bool"/>? value for true.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTrue(this bool? boolean)
        {
            return boolean.HasValue && boolean.Value;
        }

        /// <summary>
        /// Checks <see cref="bool"/>? value for false.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFalse(this bool? boolean)
        {
            return boolean.HasValue && !boolean.Value;
        }

        /// <summary>
        /// Returns <see cref="bool"/> value as "1" for true or "0" for false.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToBitString(this bool boolean)
        {
            return boolean ? "1" : "0";
        }

        /// <summary>
        /// Returns <see cref="bool"/>? value as "1" for true or "0" for false.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/>?</param>
        /// <returns><see cref="string"/></returns>
        public static string ToBitString(this bool? boolean)
        {
            return boolean.HasValue && boolean.Value ? "1" : "0";
        }

        /// <summary>
        /// Returns <see cref="bool"/> as 1 for true or 0 for false.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public static int ToInteger(this bool boolean)
        {
            return boolean ? 1 : 0;
        }

        /// <summary>
        /// Returns <see cref="bool"/>? as 1 for true or 0 for false.
        /// </summary>
        /// <param name="boolean"><see cref="bool"/>?</param>
        /// <returns><see cref="string"/></returns>
        public static int ToInteger(this bool? boolean)
        {
            return boolean.HasValue && boolean.Value ? 1 : 0;
        }
    }
}
