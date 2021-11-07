// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IRoutePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(296469676, 4039, 17124, 135, 66, 86, 153, 35, 177, 202, 17)]
  [ExclusiveTo(typeof (RoutePolicy))]
  internal interface IRoutePolicy
  {
    ConnectionProfile ConnectionProfile { get; }

    HostName HostName { get; }

    DomainNameType HostNameType { get; }
  }
}
