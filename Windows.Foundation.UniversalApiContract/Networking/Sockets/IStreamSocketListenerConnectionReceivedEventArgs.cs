// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerConnectionReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(205991593, 14143, 17531, 133, 177, 221, 212, 84, 136, 3, 186)]
  [ExclusiveTo(typeof (StreamSocketListenerConnectionReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListenerConnectionReceivedEventArgs
  {
    StreamSocket Socket { get; }
  }
}
