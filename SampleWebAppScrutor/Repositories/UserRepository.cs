using System;

namespace SampleWebAppScrutor.Repositories
{
    public class UserRepository : IUserRepository
    {
        public string GetUserName(Guid id)
        {
            return $"Name_{id}";
        }
    }

}
