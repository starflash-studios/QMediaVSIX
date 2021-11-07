// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UiccAccessCondition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the conditions placed on operations using a UICC application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UiccAccessCondition
  {
    /// <summary>Access is always allowed.</summary>
    AlwaysAllowed,
    /// <summary>Access requires PIN 1.</summary>
    Pin1,
    /// <summary>Access requires PIN 2.</summary>
    Pin2,
    /// <summary>Access requires PIN 3.</summary>
    Pin3,
    /// <summary>Access requires PIN 4.</summary>
    Pin4,
    /// <summary>Access requires Administrative 5.</summary>
    Administrative5,
    /// <summary>Access requires Administrative 6.</summary>
    Administrative6,
    /// <summary>Access is never allowed.</summary>
    NeverAllowed,
  }
}
