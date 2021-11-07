// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamWebSocket2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamWebSocket))]
  [Guid(2857175243, 37877, 18040, 130, 54, 87, 204, 229, 65, 126, 213)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStreamWebSocket2 : IStreamWebSocket, IWebSocket, IClosable
  {
    event TypedEventHandler<StreamWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
