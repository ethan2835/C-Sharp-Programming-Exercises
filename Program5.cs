namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types Lecture Code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrate integer data types
        /// </summary>
        /// <param name="args">commnad line args</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            // calculate mintues and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            // print mintues and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
        }
    }
}
