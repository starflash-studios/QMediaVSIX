// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ILanIdentifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LanIdentifier))]
  [Guid(1219122090, 4360, 17734, 166, 203, 154, 116, 218, 75, 123, 160)]
  internal interface ILanIdentifier
  {
    LanIdentifierData InfrastructureId { get; }

    LanIdentifierData PortId { get; }

    Guid NetworkAdapterId { get; }
  }
}
