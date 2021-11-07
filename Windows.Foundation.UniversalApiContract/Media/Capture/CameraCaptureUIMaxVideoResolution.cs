// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIMaxVideoResolution
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Determines the highest resolution the user can select for capturing video.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CameraCaptureUIMaxVideoResolution
  {
    /// <summary>The user can select any resolution.</summary>
    HighestAvailable,
    /// <summary>The user can select resolutions up to low definition resolutions.</summary>
    LowDefinition,
    /// <summary>The user can select resolutions up to standard definition resolutions.</summary>
    StandardDefinition,
    /// <summary>The user can select resolutions up to high definition resolutions.</summary>
    HighDefinition,
  }
}
