// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerEffects
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(2241978074, 51894, 19648, 139, 227, 96, 53, 244, 222, 37, 145)]
  internal interface IMediaPlayerEffects
  {
    void AddAudioEffect(string activatableClassId, bool effectOptional, IPropertySet configuration);

    void RemoveAllEffects();
  }
}
