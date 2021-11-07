// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialLocation))]
  [Guid(495047325, 9377, 14293, 143, 161, 57, 180, 249, 173, 103, 226)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialLocation
  {
    Vector3 Position { get; }

    Quaternion Orientation { get; }

    Vector3 AbsoluteLinearVelocity { get; }

    Vector3 AbsoluteLinearAcceleration { get; }

    Quaternion AbsoluteAngularVelocity { [Deprecated("Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] get; }

    Quaternion AbsoluteAngularAcceleration { [Deprecated("Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
