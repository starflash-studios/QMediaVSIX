// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides a way for the application to asynchronously report that it has completed the MediaStreamSource.SwitchStreamsRequested event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class MediaStreamSourceSwitchStreamsRequestDeferral : 
    IMediaStreamSourceSwitchStreamsRequestDeferral
  {
    /// <summary>Reports that the application has completed processing the MediaStreamSource.SwitchStreamsRequested event.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
