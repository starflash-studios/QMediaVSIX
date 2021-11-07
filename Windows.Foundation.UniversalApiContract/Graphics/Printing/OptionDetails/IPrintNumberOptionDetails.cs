// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintNumberOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents objects that define the enumerated values of the print task options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1291959215, 25692, 19945, 150, 95, 111, 198, 187, 196, 124, 171)]
  public interface IPrintNumberOptionDetails : IPrintOptionDetails
  {
    /// <summary>Gets the minimum enumerated value of the print task option.</summary>
    /// <returns>The minimum enumerated value of the print task option.</returns>
    uint MinValue { get; }

    /// <summary>Gets the maximum enumerated value of the print task option.</summary>
    /// <returns>The maximum enumerated value of the print task option.</returns>
    uint MaxValue { get; }
  }
}
