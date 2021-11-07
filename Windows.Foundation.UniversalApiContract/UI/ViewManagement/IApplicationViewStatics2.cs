// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2939390693, 53092, 16956, 133, 229, 243, 231, 36, 72, 251, 35)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  internal interface IApplicationViewStatics2
  {
    ApplicationView GetForCurrentView();

    bool TerminateAppOnFinalViewClose { get; set; }
  }
}
