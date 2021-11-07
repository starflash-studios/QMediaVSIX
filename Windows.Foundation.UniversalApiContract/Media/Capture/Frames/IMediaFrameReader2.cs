// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameReader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameReader))]
  [Guid(2266048435, 34097, 16464, 135, 204, 161, 55, 51, 207, 62, 155)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMediaFrameReader2
  {
    MediaFrameReaderAcquisitionMode AcquisitionMode { set; get; }
  }
}
