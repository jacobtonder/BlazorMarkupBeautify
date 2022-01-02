using Microsoft.AspNetCore.Components;

namespace BlazorMarkupBeautify
{
    public partial class ForEach<T> : ComponentBase
    {
        [Parameter]
        [EditorRequired]
        public IEnumerable<T>? Collection { get; set; }

        [Parameter]
        public RenderFragment<T>? ChildContent { get; set; }
    }
}
