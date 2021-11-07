// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSource3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionSource))]
  [Guid(67557881, 39677, 17657, 133, 220, 112, 0, 35, 169, 98, 227)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISpatialInteractionSource3 : 
    ISpatialInteractionSource2,
    ISpatialInteractionSource
  {
    SpatialInteractionSourceHandedness Handedness { get; }
  }
}
