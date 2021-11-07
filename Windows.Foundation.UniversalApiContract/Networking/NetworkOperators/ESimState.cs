// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify the state of an eSIM, including its presence and working status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimState
  {
    /// <summary>Indicates that the state of the eSIM is not known.</summary>
    Unknown,
    /// <summary>Indicates that the eSIM is idle.</summary>
    Idle,
    /// <summary>Indicates that the eSIM has been removed.</summary>
    Removed,
    /// <summary>Indicates that the eSIM is busy.</summary>
    Busy,
  }
}
