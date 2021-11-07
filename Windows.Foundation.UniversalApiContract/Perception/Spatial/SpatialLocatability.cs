// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocatability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Indicates the lifecycle state of the device's spatial location system. This lets an app know whether it can reason about the device's orientation or its position in the user's surroundings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum SpatialLocatability
  {
    /// <summary>The device's spatial location system is not available.</summary>
    Unavailable,
    /// <summary>The device is reporting its orientation, and has not been asked to report its position in the user's surroundings.</summary>
    OrientationOnly,
    /// <summary>The device is reporting its orientation, and is preparing to locate its position in the user's surroundings.</summary>
    PositionalTrackingActivating,
    /// <summary>The device is reporting its orientation and position in the user's surroundings.</summary>
    PositionalTrackingActive,
    /// <summary>The device is reporting its orientation, but cannot locate its position in the user's surroundings due to external factors, like lighting conditions.</summary>
    PositionalTrackingInhibited,
  }
}
