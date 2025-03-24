namespace DataFlow.Models
{
    public class DataFlowItem
    {
        // Index 1 to 10
        public required int Index { get; set; }
        public int StrokeWidth { get; set; } = 1;
        public string StrokeColor { get; set; } = "#000000";
        public string? Text { get; set; }
        public long? Total { get; set; }
        public int? ZIndex { get; set; }
    }
}
