// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceLocation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [Guid(1281822789, 14615, 16636, 169, 172, 49, 201, 207, 95, 249, 27)]
  [ExclusiveTo(typeof (SpatialInteractionSourceLocation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISpatialInteractionSourceLocation2
  {
    IReference<Quaternion> Orientation { get; }
  }
}
