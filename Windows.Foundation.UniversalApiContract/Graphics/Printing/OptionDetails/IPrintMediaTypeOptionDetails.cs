// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintMediaTypeOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(4173791243, 44019, 19132, 142, 134, 34, 171, 197, 116, 74, 67)]
  [ExclusiveTo(typeof (PrintMediaTypeOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintMediaTypeOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
