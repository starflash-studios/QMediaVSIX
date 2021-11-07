// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioPlaybackConnectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (AudioPlaybackConnection))]
  [Guid(3859375010, 27110, 24572, 158, 19, 130, 74, 133, 33, 61, 175)]
  internal interface IAudioPlaybackConnectionStatics
  {
    string GetDeviceSelector();

    AudioPlaybackConnection TryCreateFromId(string id);
  }
}
