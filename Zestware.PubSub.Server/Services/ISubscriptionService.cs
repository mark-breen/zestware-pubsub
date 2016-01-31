namespace Zestware.PubSub.Server.Services
{
    public interface ISubscriptionService
    {
        void Subscribe(string endpoint, params string[] topics);
    }
}
