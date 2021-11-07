// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintPageRangeOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ExclusiveTo(typeof (PrintPageRangeOptionDetails))]
  [Guid(1511646391, 11240, 19111, 158, 165, 222, 251, 232, 113, 59, 78)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintPageRangeOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
