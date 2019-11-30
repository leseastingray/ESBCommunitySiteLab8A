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
        // Check Contact HttpPost method adds a MessageInfo object
        [Fact]
        public void ContactTest()
        {
            // Arrange
            var repo = new FakeMailRepository();
            var contactController = new ContactController(repo);
            var testMessage = new MessageInfo()
            {
                Recipient = "Steve Maricle",
                MessageText = "Have you talked to FB about the Winter Concert time?",
                Sender = "David Holmes",
                MessagePriority = "3",
                //MessageDate = new DateTime(2019, 9, 15, 10, 0, 0, 0)
            };
            // Act
            contactController.Contact(testMessage);
            // Assert
            Assert.Equal("Steve Maricle", repo.Messages[repo.Messages.Count - 1].Recipient);
        }
        // Check GetMail HttpGet method returns list of sorted MessageInfo objects
        [Fact]
        public void GetMailTest()
        {
            // Arrange
            var repo = new FakeMailRepository();
            AddTestMessages(repo);
            var contactController = new ContactController(repo);
            // Act - get a list of messages in the correct order
            var result = (ViewResult)contactController.GetMail();
            var messages = (List<MessageInfo>)result.Model;
            // Assert that the messages are in the correct order by DateTime and also
            // that there are the same amount of messages, s1 > s2 returns -1
            Assert.True(DateTime.Compare(messages[0].MessageDate, messages[1].MessageDate) < 0 &&
                        DateTime.Compare(messages[1].MessageDate, messages[2].MessageDate) < 0);
        }
        // Check that GetMailByPriority returns list of MessageInfo objects by priority
        [Fact]
        public void GetPriorityMailTest()
        {
            // Arrange
            var repo = new FakeMailRepository();
            AddTestMessages(repo);
            var contactController = new ContactController(repo);
            // Act
            var result = (ViewResult)contactController.GetPriorityMail();
            var messages = (List<MessageInfo>)result.Model;
            // Assert - Check that the list is in priority order, s2 > s1 returns 1, s2 = s1 returns 0
            Assert.True(String.Compare(messages[0].MessagePriority, messages[1].MessagePriority) >= 0 &&
                        String.Compare(messages[1].MessagePriority, messages[2].MessagePriority) >= 0);
        }

        // Method to add test messages
        private void AddTestMessages(FakeMailRepository repo)
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
