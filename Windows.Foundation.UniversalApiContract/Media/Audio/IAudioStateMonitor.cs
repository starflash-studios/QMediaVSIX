// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioStateMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(487838006, 409, 19676, 184, 78, 231, 44, 43, 88, 30, 206)]
  [ExclusiveTo(typeof (AudioStateMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAudioStateMonitor
  {
    event TypedEventHandler<AudioStateMonitor, object> SoundLevelChanged;

    SoundLevel SoundLevel { get; }
  }
}
