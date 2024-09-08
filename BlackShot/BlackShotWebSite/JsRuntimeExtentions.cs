using Microsoft.JSInterop;

namespace BlackShotWebSite
{
    public static class JsRuntimeExtentions
    {
        public static ValueTask ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static ValueTask ToastrError(this IJSRuntime jsSRuntime, string message)
        {
            return jsSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
