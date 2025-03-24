using DataFlow.Models;
using Microsoft.AspNetCore.Components;

namespace DataFlow.Components
{
    public partial class Chart
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        [Parameter]
        public List<DataFlowItem>? Items { get; set; }

        [Parameter]
        public bool IsLoading { get; set; } = true;

        [Parameter]
        public EventCallback<DataFlowItem?> OnBoxClicked { get; set; }

        [Parameter]
        public bool AutoStrokeWidth { get; set; } = true;

        private async Task OnBoxClick(DataFlowItem? args)
        {
            await OnBoxClicked.InvokeAsync(args);
        }
        private double? GetStrokeWidth(DataFlowItem item)
        {
            if (AutoStrokeWidth)
            {
                var total = Items?.Max(m => m.Total);
                if (total.HasValue && item.Total.HasValue)
                {
                    var result = 8 * ((double)item.Total / (double)total);
                    return result < 1 ? 1 : result;
                }
                return null;
            }
            else
            {
                return item.StrokeWidth;
            }
        }
    }
}
