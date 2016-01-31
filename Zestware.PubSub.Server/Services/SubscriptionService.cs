using Zestware.PubSub.Server.Repositories;

namespace Zestware.PubSub.Server.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _repository;

        public SubscriptionService(ISubscriptionRepository repository)
        {
            _repository = repository;
        }

        public void Subscribe(string endpoint, params string[] topics)
        {
            _repository.AddSubscriptions(endpoint, topics);
        }


    }
}
