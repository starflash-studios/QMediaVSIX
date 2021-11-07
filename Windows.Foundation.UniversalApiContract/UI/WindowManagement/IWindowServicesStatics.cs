// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IWindowServicesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (WindowServices))]
  [Guid(3488929049, 20646, 23652, 151, 246, 194, 217, 106, 221, 127, 66)]
  internal interface IWindowServicesStatics
  {
    IVectorView<WindowId> FindAllTopLevelWindowIds();
  }
}
