// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(3584222136, 9766, 20116, 183, 179, 83, 8, 160, 246, 75, 26)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaCaptureInitializationSettings5
  {
    MediaFrameSourceGroup SourceGroup { get; set; }

    MediaCaptureSharingMode SharingMode { get; set; }

    MediaCaptureMemoryPreference MemoryPreference { get; set; }
  }
}
