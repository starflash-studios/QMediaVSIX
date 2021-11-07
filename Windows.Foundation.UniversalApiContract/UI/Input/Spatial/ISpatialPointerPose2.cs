// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPose2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialPointerPose))]
  [Guid(2636131095, 38222, 19980, 150, 209, 182, 121, 11, 111, 194, 253)]
  internal interface ISpatialPointerPose2 : ISpatialPointerPose
  {
    SpatialPointerInteractionSourcePose TryGetInteractionSourcePose(
      SpatialInteractionSource source);
  }
}
