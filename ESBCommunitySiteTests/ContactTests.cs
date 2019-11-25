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
                MessageText = "",
                Sender = "",
                MessagePriority = "1",
                MessageDate = DateTime.Now
            };
            // Add test message 1 to the repo
            repo.AddMail(message1);
            // Test message 2
        }
    }
}
