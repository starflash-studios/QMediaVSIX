// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ITriggeredConnectionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3332866221, 63201, 19796, 150, 226, 51, 246, 32, 188, 168, 138)]
  [ExclusiveTo(typeof (TriggeredConnectionStateChangedEventArgs))]
  internal interface ITriggeredConnectionStateChangedEventArgs
  {
    TriggeredConnectState State { get; }

    uint Id { get; }

    StreamSocket Socket { get; }
  }
}
