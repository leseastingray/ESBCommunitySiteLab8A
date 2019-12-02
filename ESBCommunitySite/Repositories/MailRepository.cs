using System;
using System.Collections.Generic;
using ESBCommunitySite.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ESBCommunitySite.Repositories
{
    public class MailRepository : IMailRepository
    {
        // Declare AppDbContext
        private AppDbContext context;
        // List to hold MessageInfo objects
        private static List<MessageInfo> messages = new List<MessageInfo>();
        // Messages getter - altered to work with Db
        public List<MessageInfo> Messages { get { return context.Messages.Include("Messages").ToList(); } }

        // To connect with Db
        public MailRepository(AppDbContext appDb)
        {
            context = appDb;
        }
        // Add a message to the List - altered to work with Db
        public void AddMail(MessageInfo message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
        // Get a list of messages by priority - altered to work with Db
        public List<MessageInfo> GetMessageByPriority(string priority)
        {
            for (int i = 1; i <= context.Messages.Count(); i++)
            {
                MessageInfo priorityMessage = context.Messages.First(m => m.MessagePriority == priority);
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
