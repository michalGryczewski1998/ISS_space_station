
namespace ISS_space_station.Services
{
    public class SpaceHostedService : IHostedService, IDisposable
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            /*
             * KOd umieszczam tutaj
             * TODO !!!!
             * Jak sprawić aby działało to asynchronicznie 
             */

            Console.WriteLine("Wykonywanie cyklicznego zadania o czasie: " + DateTime.Now);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
