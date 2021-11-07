// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureSharingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies the media frame source sharing mode for a MediaCapture object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaCaptureSharingMode
  {
    /// <summary>The MediaCapture should have exclusive control of one or more of the frame sources specified in SourceGroup.</summary>
    ExclusiveControl,
    /// <summary>The MediaCapture can acquire frames from the frame sources specified in SourceGroup but can't adjust the configuration of the frame sources.</summary>
    SharedReadOnly,
  }
}
