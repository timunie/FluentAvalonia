using CommunityToolkit.Mvvm.ComponentModel;

namespace FAControlsGallery.ViewModels;

public partial class TestVM :ObservableObject
{
    [ObservableProperty] private int? _min;
    [ObservableProperty] private int? _max;
}
