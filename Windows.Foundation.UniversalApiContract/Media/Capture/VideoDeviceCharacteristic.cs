// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.VideoDeviceCharacteristic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Indicates which video streams are independent of each other.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoDeviceCharacteristic
  {
    /// <summary>All streams are independent.</summary>
    AllStreamsIndependent,
    /// <summary>Preview video streams are identical.</summary>
    PreviewRecordStreamsIdentical,
    /// <summary>Preview photo streams are identical</summary>
    PreviewPhotoStreamsIdentical,
    /// <summary>Video and photo streams are identical</summary>
    RecordPhotoStreamsIdentical,
    /// <summary>All streams are identical</summary>
    AllStreamsIdentical,
  }
}
