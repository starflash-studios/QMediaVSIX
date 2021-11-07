// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents a deferral that can be used to defer the completion of the DownloadRequested event so that the app can asynchronously download media content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceDownloadRequestedDeferral : 
    IAdaptiveMediaSourceDownloadRequestedDeferral
  {
    /// <summary>Informs the system that an asynchronous operation associated with a DownloadRequested event has finished.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
