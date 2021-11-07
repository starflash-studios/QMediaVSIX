// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the MediaStreamSource.SampleRendered event, which occurs when a sample from a MediaStreamSource is rendered. Use SampleLag property to determine if there is a lag in the rendering of a sample, in which case you may decide to switch to a lower-bandwidth stream.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaStreamSourceSampleRenderedEventArgs : 
    IMediaStreamSourceSampleRenderedEventArgs
  {
    /// <summary>Gets a time span representing the lag with which a sample was rendered.</summary>
    /// <returns>The lag with which a sample was rendered.</returns>
    public extern TimeSpan SampleLag { [MethodImpl] get; }
  }
}
