// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IVideoStreamConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [Guid(3631680111, 17296, 19294, 173, 62, 15, 138, 240, 150, 52, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoStreamConfiguration))]
  internal interface IVideoStreamConfiguration
  {
    VideoEncodingProperties InputProperties { get; }

    VideoEncodingProperties OutputProperties { get; }
  }
}
