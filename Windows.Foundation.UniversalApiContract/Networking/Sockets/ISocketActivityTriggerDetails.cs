// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (SocketActivityTriggerDetails))]
  [Guid(1173620391, 64671, 20353, 172, 173, 53, 95, 239, 81, 230, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISocketActivityTriggerDetails
  {
    SocketActivityTriggerReason Reason { get; }

    SocketActivityInformation SocketInformation { get; }
  }
}
