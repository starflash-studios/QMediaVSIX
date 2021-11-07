// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToConnection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(288341960, 62005, 20446, 141, 65, 155, 242, 124, 158, 154, 64)]
  internal interface IPlayToConnection
  {
    PlayToConnectionState State { [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

    event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

    event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;
  }
}
