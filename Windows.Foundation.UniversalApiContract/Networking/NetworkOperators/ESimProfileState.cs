// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfileState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify the state of an eSIM profile, including its presence and enabled status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimProfileState
  {
    /// <summary>Indicates that the state of the eSIM profile is not known.</summary>
    Unknown,
    /// <summary>Indicates that the eSIM profile is disabled.</summary>
    Disabled,
    /// <summary>Indicates that the eSIM profile is enabled.</summary>
    Enabled,
    /// <summary>Indicates that the eSIM profile has been deleted.</summary>
    Deleted,
  }
}
