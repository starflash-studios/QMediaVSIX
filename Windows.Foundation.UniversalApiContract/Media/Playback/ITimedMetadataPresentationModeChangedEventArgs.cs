// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.ITimedMetadataPresentationModeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (TimedMetadataPresentationModeChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3512950937, 26079, 17838, 140, 239, 220, 11, 83, 253, 194, 187)]
  internal interface ITimedMetadataPresentationModeChangedEventArgs
  {
    TimedMetadataTrack Track { get; }

    TimedMetadataTrackPresentationMode OldPresentationMode { get; }

    TimedMetadataTrackPresentationMode NewPresentationMode { get; }
  }
}
