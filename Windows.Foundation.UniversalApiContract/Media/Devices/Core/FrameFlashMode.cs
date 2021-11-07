// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFlashMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Specifies the flash mode for a frame in a variable photo sequence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FrameFlashMode
  {
    /// <summary>The flash is disabled.</summary>
    Disable,
    /// <summary>The flash is enabled.</summary>
    Enable,
    /// <summary>The flash uses the global flash mode.</summary>
    Global,
  }
}
