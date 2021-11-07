// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceClosedRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents an object to be used by the MediaStreamSource.closed event to provide information to the application.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSourceClosedRequest : IMediaStreamSourceClosedRequest
  {
    /// <summary>Gets the reason why the media stream source was closed.</summary>
    /// <returns>The reason why the media stream source was closed.</returns>
    public extern MediaStreamSourceClosedReason Reason { [MethodImpl] get; }
  }
}
