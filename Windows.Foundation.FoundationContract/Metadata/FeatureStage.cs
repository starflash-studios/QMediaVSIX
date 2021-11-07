// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.FeatureStage
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Values that indicate if a Windows feature is enabled or disabled.</summary>
  [ContractVersion(typeof (FoundationContract), 196608)]
  public enum FeatureStage
  {
    /// <summary>The feature is always disabled.</summary>
    AlwaysDisabled,
    /// <summary>The feature is diabled by default.</summary>
    DisabledByDefault,
    /// <summary>The feature is enabled by default.</summary>
    EnabledByDefault,
    /// <summary>The feature is always enabled.</summary>
    AlwaysEnabled,
  }
}
