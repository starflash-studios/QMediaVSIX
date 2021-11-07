// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementSoundPlayerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (ElementSoundPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4065352022, 60737, 18647, 170, 232, 242, 171, 203, 68, 73, 41)]
  [WebHostHidden]
  internal interface IElementSoundPlayerStatics2
  {
    ElementSpatialAudioMode SpatialAudioMode { get; set; }
  }
}
