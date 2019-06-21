using System;

namespace EssentialExtensions
{
    /// <summary>
    /// Useful <see cref="DateTime"/> extensions
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns true if this date is after the passed in <see cref="DateTime"/>, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/> object</param>
        /// <param name="after"><see cref="DateTime"/> value to check against the <see cref="DateTime"/> object</param>
        /// <param name="excludeTime">True to exclude the <see cref="TimeSpan"/> from the check. Default is false</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAfter(this DateTime date, DateTime after, bool excludeTime = false)
        {
            return excludeTime
                ? date.Date > after.Date
                : date > after;
        }

        /// <summary>
        /// Returns true if this date is after the passed in <see cref="DateTime"/>?, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/>? object</param>
        /// <param name="after"><see cref="DateTime"/> value to check against the <see cref="DateTime"/>? object</param>
        /// <param name="excludeTime">True to exclude the <see cref="TimeSpan"/> from the check. Default is false</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAfter(this DateTime? date, DateTime after, bool excludeTime = false)
        {
            return excludeTime
                ? date.HasValue && date.Value.Date > after.Date
                : date.HasValue && date.Value > after;
        }

        /// <summary>
        /// Returns true if this date is before the passed in <see cref="DateTime"/>, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/> object</param>
        /// <param name="before"><see cref="DateTime"/> value to check against the <see cref="DateTime"/> object</param>
        /// <param name="excludeTime">True to exclude the <see cref="TimeSpan"/> from the check. Default is false</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsBefore(this DateTime date, DateTime before, bool excludeTime = false)
        {
            return excludeTime
                ? date.Date < before.Date
                : date < before;
        }

        /// <summary>
        /// Returns true if this date is before the passed in <see cref="DateTime"/>, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/>? object</param>
        /// <param name="before"><see cref="DateTime"/> value to check against the <see cref="DateTime"/>? object</param>
        /// <param name="excludeTime">True to exclude the <see cref="TimeSpan"/> from the check. Default is false</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsBefore(this DateTime? date, DateTime before, bool excludeTime = false)
        {
            return excludeTime
                ? date.HasValue && date.Value.Date < before.Date
                : date.HasValue && date.Value < before;
        }

        /// <summary>
        /// Returns true if the <see cref="DateTime"/> object's value is today's date, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/> object</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsToday(this DateTime date)
        {
            return date.Date == DateTime.Today.Date;
        }

        /// <summary>
        /// Returns true if the <see cref="DateTime"/>? object's value is today's date, else false
        /// </summary>
        /// <param name="date"><see cref="DateTime"/>? object</param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsToday(this DateTime? date)
        {
            return date.HasValue && date.Value.Date == DateTime.Today.Date;
        }
    }
}