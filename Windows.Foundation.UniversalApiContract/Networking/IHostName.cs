// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IHostName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3213806253, 60822, 18855, 144, 132, 212, 22, 202, 232, 141, 203)]
  [ExclusiveTo(typeof (HostName))]
  internal interface IHostName
  {
    IPInformation IPInformation { get; }

    string RawName { get; }

    string DisplayName { get; }

    string CanonicalName { get; }

    HostNameType Type { get; }

    bool IsEqual(HostName hostName);
  }
}
