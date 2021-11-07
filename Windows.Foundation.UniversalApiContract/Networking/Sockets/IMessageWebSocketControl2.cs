// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (MessageWebSocketControl))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3809466257, 2060, 16394, 167, 18, 39, 223, 169, 231, 68, 216)]
  internal interface IMessageWebSocketControl2
  {
    TimeSpan DesiredUnsolicitedPongInterval { get; set; }

    TimeSpan ActualUnsolicitedPongInterval { get; }

    MessageWebSocketReceiveMode ReceiveMode { get; set; }

    Certificate ClientCertificate { get; set; }
  }
}
