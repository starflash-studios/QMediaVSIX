// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (HandwritingView))]
  [WebHostHidden]
  [Guid(1271896347, 3553, 23710, 137, 112, 55, 185, 135, 143, 225, 113)]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IHandwritingView2
  {
    bool IsSwitchToKeyboardEnabled { get; set; }

    bool IsCommandBarOpen { get; set; }

    CoreInputDeviceTypes InputDeviceTypes { get; set; }

    event TypedEventHandler<HandwritingView, HandwritingViewCandidatesChangedEventArgs> CandidatesChanged;

    event TypedEventHandler<HandwritingView, HandwritingViewTextSubmittedEventArgs> TextSubmitted;

    IVectorView<string> GetCandidates(uint candidatesSessionId);

    void SelectCandidate(uint candidatesSessionId, uint selectedCandidateIndex);
  }
}
