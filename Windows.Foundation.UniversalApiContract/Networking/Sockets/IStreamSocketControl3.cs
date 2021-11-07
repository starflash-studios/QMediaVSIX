// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  [Guid(3312075852, 20084, 16446, 137, 76, 179, 28, 174, 92, 115, 66)]
  internal interface IStreamSocketControl3
  {
    bool SerializeConnectionAttempts { get; set; }

    Certificate ClientCertificate { get; set; }
  }
}
