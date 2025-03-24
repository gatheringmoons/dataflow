using DataFlow.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;

namespace DataFlow.Pages
{
    public partial class Home
    {
        [Inject]
        HttpClient Http { get; set; }

        [Parameter]
        public int SelectedOption { get; set; } = 1;


        private bool chartIsLoading = true;
        private List<DataFlowItem>? items;
        private string? message;

        private readonly JsonSerializerOptions jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        protected override async Task OnInitializedAsync()
        {
            items = await LoadData("sample1");
            chartIsLoading = false;
        }

        private async Task OnOptionChanged(ChangeEventArgs e)
        {
            chartIsLoading = true;
            StateHasChanged();

            await Task.Delay(1000);

            items = await LoadData(e.Value?.ToString() ?? "sample1");

            chartIsLoading = false;
            StateHasChanged();
        }        
        private async Task<List<DataFlowItem>?> LoadData(string name)
        {
            var data = await Http.GetFromJsonAsync<List<DataFlowItem>>($"assets/{name}.json");
            
            return data;
        }
        private void OnBoxClick(DataFlowItem arg)
        {
            message = $"Category {arg.Text} has been clicked.";
            StateHasChanged();
        }
    }
}
