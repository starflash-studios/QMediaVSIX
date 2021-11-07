// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1061358336, 40232, 18516, 186, 195, 35, 1, 148, 30, 194, 35)]
  [ExclusiveTo(typeof (StreamSocket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocket3
  {
    [RemoteAsync]
    IAsyncAction CancelIOAsync();

    [Overload("EnableTransferOwnership")]
    void EnableTransferOwnership(Guid taskId);

    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    [Overload("TransferOwnership")]
    void TransferOwnership(string socketId);

    [Overload("TransferOwnershipWithContext")]
    void TransferOwnership(string socketId, SocketActivityContext data);

    [Overload("TransferOwnershipWithContextAndKeepAliveTime")]
    void TransferOwnership(string socketId, SocketActivityContext data, global::Windows.Foundation.TimeSpan keepAliveTime);
  }
}
