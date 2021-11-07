// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(3359629309, 17577, 18338, 191, 150, 3, 57, 139, 75, 250, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadRequestedEventArgs))]
  internal interface IAdaptiveMediaSourceDownloadRequestedEventArgs
  {
    AdaptiveMediaSourceResourceType ResourceType { get; }

    Uri ResourceUri { get; }

    IReference<ulong> ResourceByteRangeOffset { get; }

    IReference<ulong> ResourceByteRangeLength { get; }

    AdaptiveMediaSourceDownloadResult Result { get; }

    AdaptiveMediaSourceDownloadRequestedDeferral GetDeferral();
  }
}
