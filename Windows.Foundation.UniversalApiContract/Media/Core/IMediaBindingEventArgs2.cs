// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBindingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;

namespace Windows.Media.Core
{
  [Guid(73714923, 47962, 18479, 184, 186, 240, 40, 76, 105, 101, 103)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaBindingEventArgs))]
  internal interface IMediaBindingEventArgs2
  {
    void SetAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    void SetStorageFile(IStorageFile file);
  }
}
