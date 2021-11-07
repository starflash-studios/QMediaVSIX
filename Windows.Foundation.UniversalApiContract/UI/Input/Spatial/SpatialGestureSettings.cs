// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialGestureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>This enumeration represents the set of gestures that may be recognized by a SpatialGestureRecognizer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Flags]
  public enum SpatialGestureSettings : uint
  {
    /// <summary>Disable support for gestures.</summary>
    None = 0,
    /// <summary>Enable support for the tap gesture.</summary>
    Tap = 1,
    /// <summary>Enable support for the double-tap gesture.</summary>
    DoubleTap = 2,
    /// <summary>Enable support for the hold gesture.</summary>
    Hold = 4,
    /// <summary>Enable support for the manipulation gesture, tracking changes to the hand's position.</summary>
    ManipulationTranslate = 8,
    /// <summary>Enable support for the navigation gesture, in the horizontal axis.</summary>
    NavigationX = 16, // 0x00000010
    /// <summary>Enable support for the navigation gesture, in the vertical axis.</summary>
    NavigationY = 32, // 0x00000020
    /// <summary>Enable support for the navigation gesture, in the depth axis.</summary>
    NavigationZ = 64, // 0x00000040
    /// <summary>Enable support for the navigation gesture, in the horizontal axis using rails (guides).</summary>
    NavigationRailsX = 128, // 0x00000080
    /// <summary>Enable support for the navigation gesture, in the vertical axis using rails (guides).</summary>
    NavigationRailsY = 256, // 0x00000100
    /// <summary>Enable support for the navigation gesture, in the depth axis using rails (guides).</summary>
    NavigationRailsZ = 512, // 0x00000200
  }
}
