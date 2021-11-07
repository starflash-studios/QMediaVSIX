// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.CaptureSceneMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the possible capture scene modes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CaptureSceneMode
  {
    /// <summary>Indicates that the best settings and exposure optimization are automatically performed.</summary>
    Auto,
    /// <summary>Indicates that no optimization is performed on the captured frame.</summary>
    Manual,
    /// <summary>Indicates that the captured framed is optimized for macro photos.</summary>
    Macro,
    /// <summary>Indicates that the captured framed is optimized for portrait photos.</summary>
    Portrait,
    /// <summary>Indicates that the captured framed is optimized for sports photos.</summary>
    Sport,
    /// <summary>Indicates that the captured framed is optimized for photos that include snow.</summary>
    Snow,
    /// <summary>Indicates that the captured framed is optimized for night photos</summary>
    Night,
    /// <summary>Indicates that the captured framed is optimized for beach photos.</summary>
    Beach,
    /// <summary>Indicates that the captured framed is optimized for sunset photos.</summary>
    Sunset,
    /// <summary>Indicates that the captured framed is optimized for candlelight photos.</summary>
    Candlelight,
    /// <summary>Indicates that the captured framed is optimized for photos of landscape.</summary>
    Landscape,
    /// <summary>Indicates that the captured framed is optimized for low-light portrait photos.</summary>
    NightPortrait,
    /// <summary>Indicates that the captured framed is optimized for photos that are backlit.</summary>
    Backlit,
  }
}
