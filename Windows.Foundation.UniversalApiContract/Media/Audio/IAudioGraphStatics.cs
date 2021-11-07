// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1995190578, 57689, 19127, 168, 42, 23, 190, 180, 179, 30, 148)]
  [ExclusiveTo(typeof (AudioGraph))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioGraphStatics
  {
    [RemoteAsync]
    IAsyncOperation<CreateAudioGraphResult> CreateAsync(
      AudioGraphSettings settings);
  }
}
