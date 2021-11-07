// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSwitch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(857575168, 50681, 18085, 182, 200, 237, 229, 57, 48, 69, 103)]
  [ExclusiveTo(typeof (ToggleSwitch))]
  internal interface IToggleSwitch
  {
    bool IsOn { get; set; }

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    object OnContent { get; set; }

    DataTemplate OnContentTemplate { get; set; }

    object OffContent { get; set; }

    DataTemplate OffContentTemplate { get; set; }

    ToggleSwitchTemplateSettings TemplateSettings { get; }

    event RoutedEventHandler Toggled;
  }
}
