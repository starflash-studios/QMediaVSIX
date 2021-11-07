// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIMaxPhotoResolution
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Determines the highest resolution the user can select for capturing photos.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CameraCaptureUIMaxPhotoResolution
  {
    /// <summary>The user can select any resolution.</summary>
    HighestAvailable,
    /// <summary>The user can select resolutions up to 320 X 240, or a similar 16:9 resolution.</summary>
    VerySmallQvga,
    /// <summary>The user can select resolutions up to 320 X 240, or a similar 16:9 resolution.</summary>
    SmallVga,
    /// <summary>The user can select resolutions up to 1024 X 768, or a similar 16:9 resolution.</summary>
    MediumXga,
    /// <summary>The user can select resolutions up to 1920 X 1080, or a similar 4:3 resolution.</summary>
    Large3M,
    /// <summary>The user can select resolutions up to 5 MP.</summary>
    VeryLarge5M,
  }
}
