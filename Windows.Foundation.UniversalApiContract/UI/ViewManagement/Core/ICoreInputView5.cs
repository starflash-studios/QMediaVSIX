// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputView5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ExclusiveTo(typeof (CoreInputView))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(325261024, 50901, 23639, 129, 30, 26, 216, 169, 155, 166, 171)]
  internal interface ICoreInputView5
  {
    bool IsKindSupported(CoreInputViewKind type);

    event TypedEventHandler<CoreInputView, object> SupportedKindsChanged;

    event TypedEventHandler<CoreInputView, CoreInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;
  }
}
