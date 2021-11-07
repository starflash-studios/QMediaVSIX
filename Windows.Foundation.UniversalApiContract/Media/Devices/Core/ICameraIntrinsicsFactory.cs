// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsicsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (CameraIntrinsics))]
  [Guid(3235759238, 8498, 18996, 166, 89, 155, 254, 42, 5, 87, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICameraIntrinsicsFactory
  {
    CameraIntrinsics Create(
      Vector2 focalLength,
      Vector2 principalPoint,
      Vector3 radialDistortion,
      Vector2 tangentialDistortion,
      uint imageWidth,
      uint imageHeight);
  }
}
