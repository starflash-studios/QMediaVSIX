// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialLocator))]
  [Guid(3077452608, 42946, 13851, 187, 130, 86, 233, 59, 137, 177, 187)]
  internal interface ISpatialLocatorStatics
  {
    SpatialLocator GetDefault();
  }
}
