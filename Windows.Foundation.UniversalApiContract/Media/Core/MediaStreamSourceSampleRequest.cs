// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceSampleRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents an object to be used by the MediaStreamSource.SampleRequest event to provide information to the application.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSourceSampleRequest : IMediaStreamSourceSampleRequest
  {
    /// <summary>Gets the IMediaStreamDescriptor interface of the stream for which a MediaStreamSample is being requested.</summary>
    /// <returns>The stream for which the MediaStreamSample is being requested.</returns>
    public extern IMediaStreamDescriptor StreamDescriptor { [MethodImpl] get; }

    /// <summary>Defers assigning a MediaStreamSample to MediaStreamSourceSampleRequest object.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern MediaStreamSourceSampleRequestDeferral GetDeferral();

    /// <summary>Sets the MediaStreamSample requested by the MediaStreamSource. Applications deliver a MediaStreamSample to the MediaStreamSource by assigning a value to this property.</summary>
    /// <returns>The sample which is delivered to the MediaStreamSource when this property is set. The default value is **null**.</returns>
    public extern MediaStreamSample Sample { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Provides a status update to the MediaStreamSource while the application is temporarily unable to deliver a requested MediaStreamSample.</summary>
    /// <param name="progress">A value between 0 to 100 that indicates the progress towards being able to deliver the requested MediaStreamSample.</param>
    [MethodImpl]
    public extern void ReportSampleProgress(uint progress);
  }
}
