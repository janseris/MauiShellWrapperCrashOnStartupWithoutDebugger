namespace MauiApp4;

/// <summary>
/// Provides means for centralized control of loading overlay
/// </summary>
public partial class AppShellWrapper : ContentPage
{
    public double LoadingOverlayOpacity
    {
        get => loadingOverlay.Opacity;
        set => loadingOverlay.Opacity = value;
    }

    public AppShellWrapper()
    {
        InitializeComponent();
        LoadingOverlayOpacity = 0.5;
    }
}