// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketErrorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.Sockets
{
  [Guid(667808603, 8033, 18185, 142, 2, 97, 40, 58, 218, 78, 157)]
  [ExclusiveTo(typeof (WebSocketError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebSocketErrorStatics
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
