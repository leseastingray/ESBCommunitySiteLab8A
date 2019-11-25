using System;
using ESBCommunitySite.Models;
using System.Collections.Generic;

namespace ESBCommunitySite.Repositories
{
    public interface IMailRepository
    {
        List<MessageInfo> Messages { get; }
        void AddMail(MessageInfo message);
        List<MessageInfo> GetMessageByPriority(string priority);
    }
}
