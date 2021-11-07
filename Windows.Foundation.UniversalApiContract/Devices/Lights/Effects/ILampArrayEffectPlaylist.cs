// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayEffectPlaylist
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [ExclusiveTo(typeof (LampArrayEffectPlaylist))]
  [Guid(2112195582, 28513, 16643, 152, 199, 214, 99, 47, 123, 145, 105)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArrayEffectPlaylist
  {
    void Append(ILampArrayEffect effect);

    void OverrideZIndex(int zIndex);

    void Start();

    void Stop();

    void Pause();

    LampArrayEffectStartMode EffectStartMode { get; set; }

    int Occurrences { get; set; }

    LampArrayRepetitionMode RepetitionMode { get; set; }
  }
}
