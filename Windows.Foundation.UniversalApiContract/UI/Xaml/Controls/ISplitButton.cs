// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SplitButton))]
  [Guid(1488695398, 49898, 21657, 129, 80, 64, 250, 167, 95, 107, 181)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface ISplitButton
  {
    FlyoutBase Flyout { get; set; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> Click;
  }
}
