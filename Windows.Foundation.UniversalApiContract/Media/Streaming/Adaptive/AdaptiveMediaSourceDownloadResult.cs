// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents the results of a resource download operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceDownloadResult : 
    IAdaptiveMediaSourceDownloadResult,
    IAdaptiveMediaSourceDownloadResult2
  {
    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the downloaded resource.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the downloaded resource.</returns>
    public extern Uri ResourceUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an input stream containing the downloaded resource.</summary>
    /// <returns>An input stream containing the downloaded resource.</returns>
    public extern IInputStream InputStream { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a buffer containing the downloaded resource.</summary>
    /// <returns>A buffer containing the downloaded resource.</returns>
    public extern IBuffer Buffer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that identifies the MIME content type of the downloaded resource.</summary>
    /// <returns>A string that identifies the MIME content type of the downloaded resource.</returns>
    public extern string ContentType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an integer value that represents extended status information about the resource download operation.</summary>
    /// <returns>An integer value that represents extended status information about the resource download operation.</returns>
    public extern uint ExtendedStatus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the requested byte range offset of the resource to be downloaded.</summary>
    /// <returns>The requested byte range offset of the resource to be downloaded.</returns>
    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the requested byte range of the resource to be downloaded.</summary>
    /// <returns>The requested byte range of the resource to be downloaded.</returns>
    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; [MethodImpl] set; }
  }
}
