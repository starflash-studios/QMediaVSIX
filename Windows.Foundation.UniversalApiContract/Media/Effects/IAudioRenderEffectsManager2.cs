// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioRenderEffectsManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Effects
{
  [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioRenderEffectsManager))]
  [Guid(2823081225, 24268, 17587, 187, 78, 29, 176, 114, 135, 19, 156)]
  internal interface IAudioRenderEffectsManager2
  {
    IRandomAccessStreamWithContentType EffectsProviderThumbnail { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string EffectsProviderSettingsLabel { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ShowSettingsUI();
  }
}
