// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketErrorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2189637620, 32086, 19854, 183, 180, 160, 125, 215, 193, 188, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SocketError))]
  internal interface ISocketErrorStatics
  {
    SocketErrorStatus GetStatus(int hresult);
  }
}
