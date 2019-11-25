using System;
using System.Collections.Generic;
using ESBCommunitySite.Models;

namespace ESBCommunitySite.Repositories
{
    public class MailRepository : IMailRepository
    {
        // List to hold MessageInfo objects
        private static List<MessageInfo> messages = new List<MessageInfo>();
        // Messages getter
        public List<MessageInfo> Messages { get { return messages; } }

        // To enable clean testing
        public MailRepository()
        {
            if (messages.Count == 0)
            {
                AddSeedData();
            }
        }
        // Add a message to the List
        public void AddMail(MessageInfo message)
        {
            messages.Add(message);
        }
        // Get a list of messages by priority
        public List<MessageInfo> GetMessageByPriority(string priority)
        {
            for (int i = 1; i <= messages.Count; i++)
            {
                MessageInfo priorityMessage = messages.Find(m => m.MessagePriority == priority);
                messages.Add(priorityMessage);
            }
            return messages;
        }
        // enable enumeration
        public static IEnumerable<MessageInfo> Mail
        {
            get
            {
                return messages;
            }
        }
        // this is for hardcoded data in lieu of database
        private void AddSeedData()
        {
            throw new NotImplementedException();
        }
    }
}
