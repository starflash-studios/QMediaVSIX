// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFileOutputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioFileOutputNode))]
  [Guid(1356863872, 20838, 16531, 128, 248, 173, 160, 0, 137, 233, 207)]
  internal interface IAudioFileOutputNode : IAudioNode, IClosable
  {
    IStorageFile File { get; }

    MediaEncodingProfile FileEncodingProfile { get; }

    [RemoteAsync]
    IAsyncOperation<TranscodeFailureReason> FinalizeAsync();
  }
}
