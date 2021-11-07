// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ProfileMediaType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes network types for provisioned network connectivity profiles.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ProfileMediaType
  {
    /// <summary>The profile is for a wireless local area network (WLAN).</summary>
    Wlan,
    /// <summary>The profile is for a wireless wide area network (WWAN).</summary>
    Wwan,
  }
}
