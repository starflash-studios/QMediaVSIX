// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(3468135687, 53416, 18179, 160, 145, 200, 194, 192, 145, 91, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebSocketClosedEventArgs))]
  internal interface IWebSocketClosedEventArgs
  {
    ushort Code { get; }

    string Reason { get; }
  }
}
