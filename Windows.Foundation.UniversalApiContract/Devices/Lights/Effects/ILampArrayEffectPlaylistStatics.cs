// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayEffectPlaylistStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [Guid(4212466524, 59957, 19583, 160, 22, 243, 191, 198, 166, 196, 125)]
  [ExclusiveTo(typeof (LampArrayEffectPlaylist))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArrayEffectPlaylistStatics
  {
    void StartAll(IIterable<LampArrayEffectPlaylist> value);

    void StopAll(IIterable<LampArrayEffectPlaylist> value);

    void PauseAll(IIterable<LampArrayEffectPlaylist> value);
  }
}
