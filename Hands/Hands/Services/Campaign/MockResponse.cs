using System;
using System.Collections.Generic;
using System.Linq;

using Hands.Models.Campaign;

namespace Hands.Services.Campaign
{
    public static class MockResponse
    {
        public static List<CampaignCategory> categories = new List<CampaignCategory>
        {
            new CampaignCategory{ Id = 1, Name = "Medical" },
            new CampaignCategory{ Id = 2, Name = "Emergency" },
            new CampaignCategory{ Id = 3, Name = "Education" },
            new CampaignCategory{ Id = 4, Name = "Wishes" },
        };

        public static List<CampaignOwner> owners = new List<CampaignOwner> {
            new CampaignOwner{ Id = 1, IsVerified = true, Name = "Kelly Daspit", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 2, IsVerified = true, Name = "Ashley Hirst", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 3, IsVerified = true, Name = "Gerardo Navas", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 4, IsVerified = true, Name = "Eric Solera", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 5, IsVerified = true, Name = "Brian Smith", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 6, IsVerified = true, Name = "Natalie Mandina", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 7, IsVerified = true, Name = "Andres Fernandez", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 8, IsVerified = true, Name = "Nicole Fox", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 9, IsVerified = true, Name = "Tori Sullivant", AvatarUrl = String.Empty },
            new CampaignOwner{ Id = 10, IsVerified = true, Name = "Haley Hamilton", AvatarUrl = String.Empty },
        };

        public static Campaigns campaigns = new Campaigns
        {
            Items = new List<CampaignItem> {
                // Category: Medical
                new CampaignItem
                {
                    Id = 1,
                    Title = "Help for Pippa Daspit",
                    Owner = owners[0],
                    Category = categories[0],
                    TargetAmount = 25_000,
                    RaisedAmount = 16_933,
                    ThumbnailUrl = "https://www.gofundme.com/f/help-for-pippa-daspit",
                    EndAt = DateTime.Today.AddDays(10),
                },
                new CampaignItem
                {
                    Id = 2,
                    Title = "Laugh Like Lilly",
                    Owner = owners[1],
                    Category = categories[0],
                    TargetAmount = 65_000,
                    RaisedAmount = 58_723,
                    ThumbnailUrl = "https://www.gofundme.com/f/laugh-like-lilly",
                    EndAt = DateTime.Today.AddDays(4),
                },
                new CampaignItem
                {
                    Id = 3,
                    Title = "Guillermo Navas’ Medical Expenses",
                    Owner = owners[2],
                    Category = categories[0],
                    TargetAmount = 140_000,
                    RaisedAmount = 111_551,
                    ThumbnailUrl = "https://www.gofundme.com/f/guillermo-navas-medical-expenses",
                    EndAt = DateTime.Today.AddDays(8),
                },
                // Category: Emergency
                new CampaignItem
                {
                    Id = 4,
                    Title = "Bryan & Su’s Burn Fund",
                    Owner = owners[3],
                    Category = categories[1],
                    TargetAmount = 200_000,
                    RaisedAmount = 88_366,
                    ThumbnailUrl = "https://www.gofundme.com/f/brian-sues-burn-fund",
                    EndAt = DateTime.Today.AddDays(15),
                },
                new CampaignItem
                {
                    Id = 5,
                    Title = "Meara has been diagnosed with Leukemia",
                    Owner = owners[4],
                    Category = categories[1],
                    TargetAmount = 20_000,
                    RaisedAmount = 41_837,
                    ThumbnailUrl = "https://www.gofundme.com/f/meara-has-been-diagnosed-with-leukemia",
                    EndAt = DateTime.Today.AddDays(-7),
                },
                new CampaignItem
                {
                    Id = 6,
                    Title = "Merc’S medical expenses",
                    Owner = owners[5],
                    Category = categories[1],
                    TargetAmount = 8_000,
                    RaisedAmount = 4_871,
                    ThumbnailUrl = "https://www.gofundme.com/f/mercs-medical-expenses",
                    EndAt = DateTime.Today.AddDays(21),
                },
                // Category: Education
                new CampaignItem
                {
                    Id = 7,
                    Title = "A scholarship fund in honor of Lucy Fernandez",
                    Owner = owners[6],
                    Category = categories[2],
                    TargetAmount = 700_000,
                    RaisedAmount = 633_410,
                    ThumbnailUrl = "https://www.gofundme.com/f/a-scholarship-fund-in-honor-of-lucy-fernandez",
                    EndAt = DateTime.Today.AddDays(263),
                },
                new CampaignItem
                {
                    Id = 8,
                    Title = "Books for Prison Book Club",
                    Owner = owners[7],
                    Category = categories[2],
                    TargetAmount = 3_000,
                    RaisedAmount = 1_695,
                    ThumbnailUrl = "https://www.gofundme.com/f/books-for-prison-book-club",
                    EndAt = DateTime.Today.AddDays(44),
                },
                // Category: Environment
                new CampaignItem
                {
                    Id = 9,
                    Title = "Matt’s most magical trip",
                    Owner = owners[8],
                    Category = categories[3],
                    TargetAmount = 2_000,
                    RaisedAmount = 1_140,
                    ThumbnailUrl = "https://www.gofundme.com/f/matts-most-magical-trip",
                    EndAt = DateTime.Today.AddDays(19),
                },
                new CampaignItem
                {
                    Id = 10,
                    Title = "David’s birthday fundraiser for Rockside Ranch",
                    Owner = owners[9],
                    Category = categories[3],
                    TargetAmount = 5_000,
                    RaisedAmount = 5_640,
                    ThumbnailUrl = "https://www.gofundme.com/f/davids-birthday-fundraiser-for-rockside-ranch",
                    EndAt = DateTime.Today.AddDays(-10),
                },
            },
        };
    }
}
