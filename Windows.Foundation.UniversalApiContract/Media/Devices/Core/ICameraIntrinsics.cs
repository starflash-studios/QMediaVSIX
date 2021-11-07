// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.ICameraIntrinsics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  [Guid(178711858, 25993, 18906, 175, 222, 89, 66, 112, 202, 10, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CameraIntrinsics))]
  internal interface ICameraIntrinsics
  {
    Vector2 FocalLength { get; }

    Vector2 PrincipalPoint { get; }

    Vector3 RadialDistortion { get; }

    Vector2 TangentialDistortion { get; }

    uint ImageWidth { get; }

    uint ImageHeight { get; }

    Point ProjectOntoFrame(Vector3 coordinate);

    Vector2 UnprojectAtUnitDepth(Point pixelCoordinate);

    void ProjectManyOntoFrame(Vector3[] coordinates, [Out] Point[] results);

    void UnprojectPixelsAtUnitDepth(Point[] pixelCoordinates, [Out] Vector2[] results);
  }
}
