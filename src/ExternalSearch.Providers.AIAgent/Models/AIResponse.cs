using System.Collections.Generic;

namespace CluedIn.ExternalSearch.Providers.AIAgent.Models
{
    public class Message
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    public class AIPost
    {
        public List<Message> messages { get; set; }
        public double temperature { get; set; }
        public int max_tokens { get; set; }
        public bool stream { get; set; }
    }



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Choice
    {
        public int index { get; set; }
        public ResponseMessage message { get; set; }
        public string finish_reason { get; set; }
    }

    public class ResponseMessage
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    public class AIResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public List<Choice> choices { get; set; }
        public Usage usage { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }

}