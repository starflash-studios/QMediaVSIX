// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialPerceptionAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>This enumeration describes an app's ability to see the user's surroundings in ways that require the spatialPerception capability. This includes use of either SpatialSurfaceObserver or SpatialAnchorTransferManager.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum SpatialPerceptionAccessStatus
  {
    /// <summary>The user has not yet decided whether the app can use this spatial perception functionality.</summary>
    Unspecified,
    /// <summary>The user has allowed the app to use this spatial perception functionality.</summary>
    Allowed,
    /// <summary>The user has denied the app use of this spatial perception functionality.</summary>
    DeniedByUser,
    /// <summary>The system has denied the app use of this spatial perception functionality.</summary>
    DeniedBySystem,
  }
}
