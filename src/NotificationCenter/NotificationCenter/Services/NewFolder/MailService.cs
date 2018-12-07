namespace NotificationCenter.Services.NewFolder
{
    public class MailService : INotificationService
    {
        public void Notify()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface INotificationService
    {
        void Notify();
    }
}
