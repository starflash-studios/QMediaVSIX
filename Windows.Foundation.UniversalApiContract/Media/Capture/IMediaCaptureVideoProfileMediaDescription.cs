// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfileMediaDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfileMediaDescription))]
  [Guid(2148708335, 46737, 18943, 131, 242, 193, 231, 110, 170, 234, 27)]
  internal interface IMediaCaptureVideoProfileMediaDescription
  {
    uint Width { get; }

    uint Height { get; }

    double FrameRate { get; }

    bool IsVariablePhotoSequenceSupported { [Deprecated("IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsHdrVideoSupported { [Deprecated("IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
