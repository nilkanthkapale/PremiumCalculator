namespace PC.Business.MudBlazorCustomization.MudBlazorCustomization
{
    internal interface IMudSelect
    {
        void CheckGenericTypeMatch(object select_item);
        bool MultiSelection { get; set; }
    }

    internal interface IMudShadowSelect
    {
    }
}
