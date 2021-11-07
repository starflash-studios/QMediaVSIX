// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferCostPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Defines values used to specify whether transfers can occur on metered networks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTransferCostPolicy
  {
    /// <summary>Allow transfers on metered networks.</summary>
    Default,
    /// <summary>Do not allow transfers on metered networks.</summary>
    UnrestrictedOnly,
    /// <summary>Always download regardless of network cost. (for example, even while a user is roaming)</summary>
    Always,
  }
}
