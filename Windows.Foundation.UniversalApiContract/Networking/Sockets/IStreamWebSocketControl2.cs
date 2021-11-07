// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamWebSocketControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(559783806, 64088, 16602, 159, 17, 164, 141, 175, 233, 80, 55)]
  [ExclusiveTo(typeof (StreamWebSocketControl))]
  internal interface IStreamWebSocketControl2
  {
    TimeSpan DesiredUnsolicitedPongInterval { get; set; }

    TimeSpan ActualUnsolicitedPongInterval { get; }

    Certificate ClientCertificate { get; set; }
  }
}
