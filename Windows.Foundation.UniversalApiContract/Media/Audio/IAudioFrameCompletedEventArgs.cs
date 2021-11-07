// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFrameCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(3699147422, 520, 17668, 165, 168, 240, 242, 104, 146, 10, 101)]
  [ExclusiveTo(typeof (AudioFrameCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioFrameCompletedEventArgs
  {
    AudioFrame Frame { get; }
  }
}
