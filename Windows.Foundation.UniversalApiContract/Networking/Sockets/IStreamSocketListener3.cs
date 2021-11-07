// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1201152028, 48632, 18713, 133, 66, 40, 212, 80, 231, 69, 7)]
  [ExclusiveTo(typeof (StreamSocketListener))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListener3
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
  }
}
