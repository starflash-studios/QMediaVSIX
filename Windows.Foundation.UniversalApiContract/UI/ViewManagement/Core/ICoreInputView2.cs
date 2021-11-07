// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [Guid(248981185, 57498, 19176, 174, 223, 223, 164, 133, 125, 26, 1)]
  [ExclusiveTo(typeof (CoreInputView))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ICoreInputView2
  {
    event TypedEventHandler<CoreInputView, CoreInputViewTransferringXYFocusEventArgs> XYFocusTransferringFromPrimaryView;

    event TypedEventHandler<CoreInputView, object> XYFocusTransferredToPrimaryView;

    bool TryTransferXYFocusToPrimaryView(
      Rect origin,
      CoreInputViewXYFocusTransferDirection direction);
  }
}
