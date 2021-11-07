// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.GCPressureAmount
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Microsoft internal use only.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum GCPressureAmount
  {
    /// <summary>Less than 10k of memory pressure.</summary>
    Low,
    /// <summary>Between 10k and 100k of memory pressure.</summary>
    Medium,
    /// <summary>Over 100k of memory pressure.</summary>
    High,
  }
}
