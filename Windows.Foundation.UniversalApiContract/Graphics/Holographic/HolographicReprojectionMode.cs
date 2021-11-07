// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicReprojectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents the kind of reprojection an app is requesting to stabilize its holographic rendering relative to the user's head motion.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum HolographicReprojectionMode
  {
    /// <summary>The image should be stabilized for changes to both the user's head position and orientation.  This is best for world-locked content that should remain physically stationary as the user walks around.</summary>
    PositionAndOrientation,
    /// <summary>The image should be stabilized only for changes to both the user's head orientation, ignoring positional changes.  This is best for body-locked content that should tag along with the user as they walk around, such as 360-degree video.</summary>
    OrientationOnly,
    /// <summary>The image should not be stabilized for the user's head motion, instead remaining fixed in the display.  This is generally discouraged, as it is only comfortable for users when used sparingly, such as when the only visible content is a small cursor.</summary>
    Disabled,
  }
}
