// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FocusPreset
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the values for the possible focus presets.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FocusPreset
  {
    /// <summary>Indicates that focus is automatically set by the capture.</summary>
    Auto,
    /// <summary>Indicates that focus is manually set.</summary>
    Manual,
    /// <summary>Indicates that the capture device uses a close autofocus range.</summary>
    AutoMacro,
    /// <summary>Indicates that the capture device uses a normal autofocus range.</summary>
    AutoNormal,
    /// <summary>Indicates that the capture device uses an infinite autofocus range.</summary>
    AutoInfinity,
    /// <summary>Indicates that the capture device uses a hyperfocal autofocus range.</summary>
    AutoHyperfocal,
  }
}
