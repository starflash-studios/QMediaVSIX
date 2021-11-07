// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkCostType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines the network cost types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkCostType
  {
    /// <summary>Cost information is not available.</summary>
    Unknown,
    /// <summary>The connection is unlimited and has unrestricted usage charges and capacity constraints.</summary>
    Unrestricted,
    /// <summary>The use of this connection is unrestricted up to a specific limit.</summary>
    Fixed,
    /// <summary>The connection is costed on a per-byte basis.</summary>
    Variable,
  }
}
