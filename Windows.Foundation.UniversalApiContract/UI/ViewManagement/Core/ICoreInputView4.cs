// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputView4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [Guid(2646998, 55791, 22507, 140, 239, 119, 246, 206, 27, 126, 231)]
  [ExclusiveTo(typeof (CoreInputView))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ICoreInputView4
  {
    event TypedEventHandler<CoreInputView, CoreInputViewShowingEventArgs> PrimaryViewShowing;

    event TypedEventHandler<CoreInputView, CoreInputViewHidingEventArgs> PrimaryViewHiding;
  }
}
