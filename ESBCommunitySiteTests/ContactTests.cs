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
            // Act
            // Assert
        }

        // Check that GetMailByPriority returns list of MessageInfo objects by priority
        [Fact]
        public void GetPriorityMailTest()
        {
            // Arrange
            // Act
            // Assert
        }
    }
}
