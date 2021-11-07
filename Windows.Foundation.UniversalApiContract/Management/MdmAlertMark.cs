// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmAlertMark
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>Values indicating priority or criticality of the MDM alert.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MdmAlertMark
  {
    /// <summary>No information.</summary>
    None,
    /// <summary>The alert is fatal.</summary>
    Fatal,
    /// <summary>The alert is critical.</summary>
    Critical,
    /// <summary>The alert is a warning.</summary>
    Warning,
    /// <summary>The alert is informational.</summary>
    Informational,
  }
}
