// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewSelectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationViewSelectionChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1520765344, 14942, 20308, 137, 108, 152, 184, 95, 129, 149, 8)]
  internal interface INavigationViewSelectionChangedEventArgs
  {
    object SelectedItem { get; }

    bool IsSettingsSelected { get; }
  }
}
