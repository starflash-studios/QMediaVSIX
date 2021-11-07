// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  [Guid(369587663, 46488, 17583, 164, 136, 195, 206, 42, 246, 211, 240)]
  internal interface IMenuFlyoutItem
  {
    string Text { get; set; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    event RoutedEventHandler Click;
  }
}
