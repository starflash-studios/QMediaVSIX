// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketFeatureSelectionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Contains values that describe the selection type of a print ticket feature. This indicates whether the user can select only one option or multiple for a feature.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum PrintTicketFeatureSelectionType
  {
    /// <summary>The user must select one option for the print feature.</summary>
    PickOne,
    /// <summary>The user can select multiple options for the print feature.</summary>
    PickMany,
  }
}
