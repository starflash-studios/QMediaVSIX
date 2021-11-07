// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapturePauseResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaCapturePauseResult))]
  [Guid(2932112547, 17527, 19204, 160, 111, 44, 28, 81, 130, 254, 157)]
  internal interface IMediaCapturePauseResult
  {
    VideoFrame LastFrame { get; }

    TimeSpan RecordDuration { get; }
  }
}
