// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Guid(293544982, 14503, 18968, 180, 4, 171, 143, 171, 225, 215, 139)]
  [ExclusiveTo(typeof (SpatialLocation))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISpatialLocation2
  {
    Vector3 AbsoluteAngularVelocityAxisAngle { get; }

    Vector3 AbsoluteAngularAccelerationAxisAngle { get; }
  }
}
