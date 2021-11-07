// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the MediaStreamSource.Closed event.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSourceClosedEventArgs : IMediaStreamSourceClosedEventArgs
  {
    /// <summary>Gets the object that represents the notification that the MediaStreamSource has been closed.</summary>
    /// <returns>Provides information regarding why the MediaStreamSource was closed.</returns>
    public extern MediaStreamSourceClosedRequest Request { [MethodImpl] get; }
  }
}
