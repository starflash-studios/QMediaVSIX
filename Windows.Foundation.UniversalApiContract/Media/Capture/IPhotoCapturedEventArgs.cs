// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IPhotoCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(926677953, 38990, 20464, 191, 133, 28, 0, 170, 188, 90, 69)]
  [ExclusiveTo(typeof (PhotoCapturedEventArgs))]
  internal interface IPhotoCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    CapturedFrame Thumbnail { get; }

    TimeSpan CaptureTimeOffset { get; }
  }
}
