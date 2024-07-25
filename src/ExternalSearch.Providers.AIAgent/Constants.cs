using System;
using System.Collections.Generic;
using CluedIn.Core.Data.Relational;
using CluedIn.Core.Providers;

namespace CluedIn.ExternalSearch.Providers.AIAgent
{
    public static class Constants
    {
        public const string ComponentName = "AIAgent";
        public const string ProviderName = "AI Agent";
        public static readonly Guid ProviderId = Guid.Parse("E8A38984-BFA0-4EB8-9255-BDB1B25C756F");

        public struct KeyName
        {
            public const string AIModel = "apiToken";
            public const string AcceptedEntityType = "acceptedEntityType";
            public const string Prompt = "imageSearchKey";
            public const string ResponseVocabularyKey = "responseVocabularyKey";
        }

        public static string About { get; set; } = "AI Agents are ways to automatically have AI running jobs in the background";
        public static string Icon { get; set; } = "Resources.cluedin.png";
        public static string Domain { get; set; } = "N/A";

        public static AuthMethods AuthMethods { get; set; } = new AuthMethods
        {
            token = new List<Control>()
            {
                new Control()
                {
                    displayName = "AI Model",
                    type = "input",
                    isRequired = true,
                    name = KeyName.AIModel
                },
                new Control()
                {
                    displayName = "Accepted Entity Type",
                    type = "input",
                    isRequired = true,
                    name = KeyName.AcceptedEntityType
                },
                new Control()
                {
                    displayName = "Prompt",
                    type = "input",
                    isRequired = true,
                    name = KeyName.Prompt
                },
                new Control()
                {
                    displayName = "Response Vocabulary Key",
                    type = "input",
                    isRequired = true,
                    name = KeyName.ResponseVocabularyKey
                }

            }
        };

        public static IEnumerable<Control> Properties { get; set; } = new List<Control>()
        {
            // NOTE: Leaving this commented as an example - BF
            //new()
            //{
            //    displayName = "Some Data",
            //    type = "input",
            //    isRequired = true,
            //    name = "someData"
            //}
        };

        public static Guide Guide { get; set; } = null;
        public static IntegrationType IntegrationType { get; set; } = IntegrationType.Enrichment;
    }
}