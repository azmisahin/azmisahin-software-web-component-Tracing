namespace @as.Tracing
{
    /// <summary>
    /// Log Base
    /// </summary>
    public class LogBase
    {
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            Write(message: string.Format("Tracing.Log.Error : {0}", message));
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
        }

        /// <summary>
        /// Info
        /// </summary>
        /// <param name="message"></param>
        public static void Info(string message)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            Write(message: string.Format("Tracing.Log.Info : {0}", message));
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
        }

        /// <summary>
        /// Warning
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(string message)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Magenta;
            Write(message: string.Format("Tracing.Log.Warning : {0}", message));
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
        }

        /// <summary>
        /// Write
        /// </summary>
        /// <param name="message"></param>
        public static void Write(string message)
        {
            System.Diagnostics.Trace.Write(message: message);
            System.Console.WriteLine(value: message);
            Push.StartAsync(message).Wait();
        }

        /// <summary>
        /// Write
        /// </summary>
        /// <param name="value"></param>
        public static void Write(object value)
        {
            System.Diagnostics.Trace.Write(value: value);
            System.Console.WriteLine(value: value);
            Push.StartAsync(value.ToString()).Wait();            
        }
    }
}
