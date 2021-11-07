// Decompiled with JetBrains decompiler
// Type: Windows.Networking.HostNameSortOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  /// <summary>Options for how a list of EndpointPair objects is sorted.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HostNameSortOptions : uint
  {
    /// <summary>Sort a list of EndpointPair objects by the default criteria used the system which is to minimize connection delays.</summary>
    None = 0,
    /// <summary>Sort a list of EndpointPair objects to optimize for long connections.</summary>
    OptimizeForLongConnections = 2,
  }
}
