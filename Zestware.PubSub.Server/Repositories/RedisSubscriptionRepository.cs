using StackExchange.Redis;

namespace Zestware.PubSub.Server.Repositories
{
    public class RedisSubscriptionRepository : ISubscriptionRepository
    {
        private ConnectionMultiplexer _redis;

        public RedisSubscriptionRepository(string redisConnection)
        {
            _redis = ConnectionMultiplexer.Connect(redisConnection);
        }

        public void AddSubscriptions(string endpoint, params string[] topics)
        {
            var database = _redis.GetDatabase();
        }
    }
}