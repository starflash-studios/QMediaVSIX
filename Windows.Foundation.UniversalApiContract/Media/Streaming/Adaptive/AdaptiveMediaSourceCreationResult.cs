// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents the result of the creation of a AdaptiveMediaSource object.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdaptiveMediaSourceCreationResult : 
    IAdaptiveMediaSourceCreationResult,
    IAdaptiveMediaSourceCreationResult2
  {
    /// <summary>Gets the status of an attempt to create a AdaptiveMediaSource object.</summary>
    /// <returns>A AdaptiveMediaSourceCreationStatus -typed value that specifies the result of an attempt to create a AdaptiveMediaSource object.</returns>
    public extern AdaptiveMediaSourceCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the AdaptiveMediaSource object that represents the source of adaptive streaming content.</summary>
    /// <returns>The AdaptiveMediaSource object that represents the source of adaptive streaming content.</returns>
    public extern AdaptiveMediaSource MediaSource { [MethodImpl] get; }

    /// <summary>Gets the HTTP response message, if any, returned from an attempt to create a AdaptiveMediaSource object.</summary>
    /// <returns>The HTTP response message returned from an attempt to create a AdaptiveMediaSource object.</returns>
    public extern HttpResponseMessage HttpResponseMessage { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a AdaptiveMediaSource object.</summary>
    /// <returns>The extended error code associated with the creation of a AdaptiveMediaSource object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
