// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfileClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify an eSIM profile class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimProfileClass
  {
    /// <summary>Indicates the class of an operational eSIM profile.</summary>
    Operational,
    /// <summary>Indicates the class of a test eSIM profile.</summary>
    Test,
    /// <summary>Indicates the class of a provisioning eSIM profile.</summary>
    Provisioning,
  }
}
