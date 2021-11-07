// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CameraCaptureUIMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Determines whether the user interface for capturing from the attached camera allows capture of photos, videos, or both photos and videos.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CameraCaptureUIMode
  {
    /// <summary>Either a photo or video can be captured.</summary>
    PhotoOrVideo,
    /// <summary>The user can only capture a photo.</summary>
    Photo,
    /// <summary>The user can only capture a video.</summary>
    Video,
  }
}
