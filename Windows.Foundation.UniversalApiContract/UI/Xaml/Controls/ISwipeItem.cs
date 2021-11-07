// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2205080284, 17864, 18944, 144, 160, 113, 7, 250, 137, 74, 27)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SwipeItem))]
  internal interface ISwipeItem
  {
    string Text { get; set; }

    IconSource IconSource { get; set; }

    Brush Background { get; set; }

    Brush Foreground { get; set; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    SwipeBehaviorOnInvoked BehaviorOnInvoked { get; set; }

    event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked;
  }
}
