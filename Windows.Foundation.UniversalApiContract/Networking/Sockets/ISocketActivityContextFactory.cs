// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketActivityContextFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (SocketActivityContext))]
  [Guid(3114255299, 2188, 17288, 131, 174, 37, 37, 19, 142, 4, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISocketActivityContextFactory
  {
    SocketActivityContext Create(IBuffer data);
  }
}
