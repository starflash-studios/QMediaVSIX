// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimAuthenticationPreference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify under what conditions the user should be challenged for eSIM authentication credentials.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimAuthenticationPreference
  {
    /// <summary>Indicates that credentials should be requested when the eSIM is entered.</summary>
    OnEntry,
    /// <summary>Indicates that credentials should be requested when the eSIM is involved in an action.</summary>
    OnAction,
    /// <summary>Indicates that credentials should never be requested.</summary>
    Never,
  }
}
