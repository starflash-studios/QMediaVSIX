// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.IPrepareTranscodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Transcoding
{
  [ExclusiveTo(typeof (PrepareTranscodeResult))]
  [Guid(99769806, 39247, 18996, 157, 104, 151, 204, 206, 23, 48, 214)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrepareTranscodeResult
  {
    bool CanTranscode { get; }

    TranscodeFailureReason FailureReason { get; }

    [RemoteAsync]
    IAsyncActionWithProgress<double> TranscodeAsync();
  }
}
