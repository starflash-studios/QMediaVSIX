// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerInteractionSourcePose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialPointerInteractionSourcePose))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2802860807, 11307, 19770, 146, 167, 128, 206, 215, 196, 160, 208)]
  internal interface ISpatialPointerInteractionSourcePose
  {
    Vector3 Position { get; }

    Vector3 ForwardDirection { get; }

    Vector3 UpDirection { get; }
  }
}
