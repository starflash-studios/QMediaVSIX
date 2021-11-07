// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(902492368, 18416, 17260, 175, 151, 13, 216, 143, 111, 95, 2)]
  [ExclusiveTo(typeof (CoreWindow))]
  [WebHostHidden]
  internal interface ICoreWindow4
  {
    event TypedEventHandler<CoreWindow, object> ResizeStarted;

    event TypedEventHandler<CoreWindow, object> ResizeCompleted;
  }
}
