// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3449099859, 49905, 17560, 139, 120, 95, 180, 205, 54, 64, 221)]
  [ExclusiveTo(typeof (CastingConnection))]
  internal interface ICastingConnection : IClosable
  {
    CastingConnectionState State { get; }

    CastingDevice Device { get; }

    CastingSource Source { get; set; }

    event TypedEventHandler<CastingConnection, object> StateChanged;

    event TypedEventHandler<CastingConnection, CastingConnectionErrorOccurredEventArgs> ErrorOccurred;

    [RemoteAsync]
    IAsyncOperation<CastingConnectionErrorStatus> RequestStartCastingAsync(
      CastingSource value);

    [RemoteAsync]
    IAsyncOperation<CastingConnectionErrorStatus> DisconnectAsync();
  }
}
