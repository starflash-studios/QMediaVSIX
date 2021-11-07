// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.ManeuverWarningSeverity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Specifies the severity of a potential issue along a route leg.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum ManeuverWarningSeverity
  {
    /// <summary>The issue has no impact.</summary>
    None,
    /// <summary>The issue has a low impact.</summary>
    LowImpact,
    /// <summary>The issue has a minor level impact.</summary>
    Minor,
    /// <summary>The issue has a moderate level of impact.</summary>
    Moderate,
    /// <summary>The issue has a high level of impact.</summary>
    Serious,
  }
}
