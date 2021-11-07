// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [Guid(3346058618, 28673, 19506, 191, 148, 37, 193, 245, 84, 203, 241)]
  [ExclusiveTo(typeof (CoreInputView))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ICoreInputView
  {
    event TypedEventHandler<CoreInputView, CoreInputViewOcclusionsChangedEventArgs> OcclusionsChanged;

    IVectorView<CoreInputViewOcclusion> GetCoreInputViewOcclusions();

    bool TryShowPrimaryView();

    bool TryHidePrimaryView();
  }
}
