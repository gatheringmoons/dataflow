using DataFlow.Models;
using Microsoft.AspNetCore.Components;

namespace DataFlow.Components
{
    public partial class Box
    {        
        [Parameter]
        public required DataFlowItem Item { get; set; }

        [Parameter]
        public EventCallback<DataFlowItem> OnBoxClicked { get; set; }

        private async Task OnBoxClick()
        {
            await OnBoxClicked.InvokeAsync(Item);
        }
    }
}
