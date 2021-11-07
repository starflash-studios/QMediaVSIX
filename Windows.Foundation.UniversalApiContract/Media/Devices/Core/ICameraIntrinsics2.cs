// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (CameraIntrinsics))]
  [Guid(215655495, 1944, 19277, 131, 159, 197, 236, 65, 77, 178, 122)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICameraIntrinsics2
  {
    Matrix4x4 UndistortedProjectionTransform { get; }

    Point DistortPoint(Point input);

    void DistortPoints(Point[] inputs, [Out] Point[] results);

    Point UndistortPoint(Point input);

    void UndistortPoints(Point[] inputs, [Out] Point[] results);
  }
}
