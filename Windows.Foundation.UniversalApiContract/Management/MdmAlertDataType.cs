// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmAlertDataType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>The possible data formats of an MDM alert payload.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MdmAlertDataType
  {
    /// <summary>String data.</summary>
    String,
    /// <summary>Base-64 data.</summary>
    Base64,
    /// <summary>Boolean data.</summary>
    Boolean,
    /// <summary>Integer data.</summary>
    Integer,
  }
}
