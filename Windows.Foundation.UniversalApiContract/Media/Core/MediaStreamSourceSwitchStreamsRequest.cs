// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceSwitchStreamsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents an object to be used by the MediaStreamSource.SwitchStreamsRequest event to provide information to the application.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSourceSwitchStreamsRequest : IMediaStreamSourceSwitchStreamsRequest
  {
    /// <summary>Gets the stream descriptor for the stream which is no longer selected by the MediaStreamSource.</summary>
    /// <returns>The previously selected stream.</returns>
    public extern IMediaStreamDescriptor OldStreamDescriptor { [MethodImpl] get; }

    /// <summary>Gets the stream descriptor for the stream that is now selected by the MediaStreamSource.</summary>
    /// <returns>The selected stream.</returns>
    public extern IMediaStreamDescriptor NewStreamDescriptor { [MethodImpl] get; }

    /// <summary>Defers completing the MediaStreamSource.SwitchStreamsRequested event.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern MediaStreamSourceSwitchStreamsRequestDeferral GetDeferral();
  }
}
