// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2374648548, 43134, 19316, 153, 104, 24, 91, 37, 17, 222, 254)]
  [ExclusiveTo(typeof (SocketActivityInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISocketActivityInformation
  {
    Guid TaskId { get; }

    string Id { get; }

    SocketActivityKind SocketKind { get; }

    SocketActivityContext Context { get; }

    DatagramSocket DatagramSocket { get; }

    StreamSocket StreamSocket { get; }

    StreamSocketListener StreamSocketListener { get; }
  }
}
