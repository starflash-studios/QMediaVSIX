// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerEffects2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4198603385, 7102, 18117, 174, 31, 142, 230, 159, 179, 194, 199)]
  internal interface IMediaPlayerEffects2
  {
    void AddVideoEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet effectConfiguration);
  }
}
