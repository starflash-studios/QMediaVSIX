﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IBackgroundAudioTrackStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (BackgroundAudioTrack))]
  [Guid(3652305111, 53272, 17064, 165, 89, 203, 77, 158, 151, 230, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundAudioTrackStatics
  {
    BackgroundAudioTrack CreateFromEmbeddedAudioTrack(
      EmbeddedAudioTrack embeddedAudioTrack);

    [RemoteAsync]
    IAsyncOperation<BackgroundAudioTrack> CreateFromFileAsync(
      IStorageFile file);
  }
}