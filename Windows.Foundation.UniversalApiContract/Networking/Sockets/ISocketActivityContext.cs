// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1135627620, 19589, 17302, 166, 55, 29, 151, 63, 110, 189, 73)]
  [ExclusiveTo(typeof (SocketActivityContext))]
  internal interface ISocketActivityContext
  {
    IBuffer Data { get; }
  }
}
