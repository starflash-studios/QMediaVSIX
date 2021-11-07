// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewInteropStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3292986205, 18323, 18582, 168, 226, 190, 87, 168, 187, 15, 80)]
  internal interface IApplicationViewInteropStatics
  {
    int GetApplicationViewIdForWindow(ICoreWindow window);
  }
}
