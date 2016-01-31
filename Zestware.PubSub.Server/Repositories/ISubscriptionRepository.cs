namespace Zestware.PubSub.Server.Repositories
{
    public interface ISubscriptionRepository
    {
        void AddSubscriptions(string endpoint, params string[] topics);
    }
}
