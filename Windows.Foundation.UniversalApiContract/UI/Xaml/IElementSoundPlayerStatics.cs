// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementSoundPlayerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(561680388, 38941, 16841, 177, 82, 173, 169, 17, 164, 177, 58)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ElementSoundPlayer))]
  internal interface IElementSoundPlayerStatics
  {
    double Volume { get; set; }

    ElementSoundPlayerState State { get; set; }

    void Play(ElementSoundKind sound);
  }
}
