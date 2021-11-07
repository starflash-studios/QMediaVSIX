// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(3344602117, 51201, 16682, 131, 91, 131, 252, 14, 98, 42, 142)]
  [ExclusiveTo(typeof (MediaPlayerDataReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayerDataReceivedEventArgs
  {
    ValueSet Data { get; }
  }
}
