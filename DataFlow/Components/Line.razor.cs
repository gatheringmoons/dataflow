using Microsoft.AspNetCore.Components;

namespace DataFlow.Components
{
    public partial class Line
    {
        [Parameter]
        public required int Index { get; set; }

        [Parameter]
        public double? StrokeWidth { get; set; }

        [Parameter]
        public string StrokeColor { get; set; } = "#000000";

        [Parameter]
        public int? ZIndex { get; set; }

        [Parameter]
        public bool IsLoading { get; set; } = true;
    }
}
