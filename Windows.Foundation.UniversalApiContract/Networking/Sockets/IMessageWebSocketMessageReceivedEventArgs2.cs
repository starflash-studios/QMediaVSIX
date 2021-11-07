// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketMessageReceivedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2311980797, 56687, 18951, 135, 249, 249, 235, 77, 137, 216, 61)]
  [ExclusiveTo(typeof (MessageWebSocketMessageReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMessageWebSocketMessageReceivedEventArgs2 : 
    IMessageWebSocketMessageReceivedEventArgs
  {
    bool IsMessageComplete { get; }
  }
}
