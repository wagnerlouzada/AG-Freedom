using Microsoft.ML.Data;

namespace EnterpriseApp1.ML.Consume.DataStructure
{
    public class SentimentIssue
    {
        [LoadColumn(0)]
        public bool Label { get; set; }
        [LoadColumn(2)]
        public string Text { get; set; }
    }
}