namespace SecretTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Op zoek naar secret...");
                var mySecret = Environment.GetEnvironmentVariable("CONNECT_WEBSOCKET", EnvironmentVariableTarget.Process);
                var tt = Environment.GetEnvironmentVariables();

                if (mySecret == null)
                {
                    Console.WriteLine("Secret is null.");
                }
                else
                {
                    Console.WriteLine($"Secret: {mySecret}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uitzondering gevangen: {ex.Message}");
            }

            Console.WriteLine("Druk op Enter om af te sluiten...");
            Console.ReadLine();
        }
    }
}
