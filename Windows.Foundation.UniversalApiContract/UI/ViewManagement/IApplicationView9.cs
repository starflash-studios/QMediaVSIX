// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.ViewManagement
{
  [Guid(2623870713, 538, 24321, 147, 229, 155, 218, 210, 100, 117, 116)]
  [ExclusiveTo(typeof (ApplicationView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IApplicationView9
  {
    WindowingEnvironment WindowingEnvironment { get; }

    IVectorView<DisplayRegion> GetDisplayRegions();
  }
}
