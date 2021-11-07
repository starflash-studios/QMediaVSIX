// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceFacade
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(3759547080, 9010, 21959, 136, 104, 167, 49, 44, 92, 34, 157)]
  [WebHostHidden]
  public interface ICompositionSurfaceFacade
  {
    ICompositionSurface GetRealSurface();
  }
}
