// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UiccAppKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the kinds of UICC applications.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UiccAppKind
  {
    /// <summary>An unknown kind.</summary>
    Unknown,
    /// <summary>Master File application.</summary>
    MF,
    /// <summary>A GSM application.</summary>
    MFSim,
    /// <summary>Removable user identity card application.</summary>
    MFRuim,
    /// <summary>UMTS application.</summary>
    USim,
    /// <summary>CDMA application.</summary>
    CSim,
    /// <summary>IP multimedia services application.</summary>
    ISim,
  }
}
