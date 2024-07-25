using System.Collections.Generic;
using CluedIn.Core.Crawling;

namespace CluedIn.ExternalSearch.Providers.AIAgent
{
    public class AIAgentExternalSearchJobData : CrawlJobData
    {
        public AIAgentExternalSearchJobData(IDictionary<string, object> configuration)
        {
            AIModel = GetValue<string>(configuration, Constants.KeyName.AIModel);
            AcceptedEntityType = GetValue<string>(configuration, Constants.KeyName.AcceptedEntityType);
            Prompt = GetValue<string>(configuration, Constants.KeyName.Prompt);
            ResponseVocabularyKey = GetValue<string>(configuration, Constants.KeyName.ResponseVocabularyKey);
        }

        public IDictionary<string, object> ToDictionary()
        {
            return new Dictionary<string, object> {
                { Constants.KeyName.AIModel, AIModel },
                { Constants.KeyName.AcceptedEntityType, AcceptedEntityType },
                { Constants.KeyName.Prompt, Prompt },
                { Constants.KeyName.ResponseVocabularyKey, ResponseVocabularyKey }
            };
        }

        public string AIModel { get; set; }
        public string AcceptedEntityType { get; set; }
        public string Prompt { get; set; }

        public string ResponseVocabularyKey { get; set; }

    }
}
