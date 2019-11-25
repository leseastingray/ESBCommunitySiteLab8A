using System;
using System.Collections.Generic;
using ESBCommunitySite.Controllers;
using ESBCommunitySite.Models;
using ESBCommunitySite.Repositories;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace ESBCommunitySiteTests
{
    // This set of tests works with the ContactController
    public class ContactTests
    {
        // Check AddMail (if we have it in the ContactController)
        [Fact]
        public void AddMailTest()
        {
            // Arrange
            var repo = new FakeMailRepository();
            var contactController = new ContactController(repo);
            // Act
            // contactController.AddMail(Recipient, MessageText, Sender, MessagePriority, MessageDate);
            // Assert
            // Assert.Equal(Recipient, repo.Messages[repo.Messages.Count - 1].Recipient);
        }
        // Check GetMail HttpPost method adds a MessageInfo object to the repository
        [Fact]
        public void ContactTest()
        {
            // Arrange
            var repo = new FakeMailRepository();
            var contactController = new ContactController(repo);
            // Act - get a list of messages in the correct order
            var result = (ViewResult)contactController.Contact();
            var messages = (List<MessageInfo>)result.Model;
            // Assert that the messages are in the correct order and also
            // that there are the same amount of messages
            //Assert.True();
        }

        // Check that GetMailByPriority returns list of MessageInfo objects by priority
        [Fact]
        public void GetPriorityMailTest()
        {
            // Arrange
            // Act
            // Assert
        }

        // Method to add test messages
        private void AddMessage(FakeMailRepository repo)
        {
            // Test message 1
            MessageInfo message1 = new MessageInfo()
            {
                Recipient = "Loren Berry",
                MessageText = "Do you and I need both mutes for rehearsal tonight?",
                Sender = "Amy Lese",
                MessagePriority = "2",
                MessageDate = DateTime.Now
            };
            // Add test message 1 to the repo
            repo.AddMail(message1);
            // Test message 2
            MessageInfo message2 = new MessageInfo()
            {
                Recipient = "Sherry Cosey",
                MessageText = "Please let the conductor know that I won't be at rehearsal tonight.",
                Sender = "David Holmes",
                MessagePriority = "3",
                MessageDate = DateTime.Now
            };
            // Add test message 2 to the repo
            repo.AddMail(message2);
            // Test message 3
            MessageInfo message3 = new MessageInfo()
            {
                Recipient = "David Holmes",
                MessageText = "Will you have a sub player coming in your place tonight?",
                Sender = "Steve Maricle",
                MessagePriority = "1",
                MessageDate = DateTime.Now
            };
            // Add test message 3 to the repo
            repo.AddMail(message3);
        }
    }
}
