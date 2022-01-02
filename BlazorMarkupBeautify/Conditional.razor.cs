using Microsoft.AspNetCore.Components;

namespace BlazorMarkupBeautify
{
    public partial class Conditional : ComponentBase
    {
        [Parameter]
        public bool Condition { get; set; }

        [Parameter]
        public RenderFragment? True { get; set; }

        [Parameter]
        public RenderFragment? False { get; set; }
    }
}
