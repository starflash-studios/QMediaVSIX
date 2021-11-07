// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2744644763, 5482, 18183, 172, 44, 211, 29, 87, 14, 211, 153)]
  [ExclusiveTo(typeof (SpatialEntityAddedEventArgs))]
  internal interface ISpatialEntityAddedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}
