// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [ExclusiveTo(typeof (DnssdRegistrationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1031301842, 58886, 21328, 115, 234, 126, 151, 240, 102, 22, 47)]
  internal interface IDnssdRegistrationResult
  {
    DnssdRegistrationStatus Status { get; }

    HostName IPAddress { get; }

    bool HasInstanceNameChanged { get; }
  }
}
