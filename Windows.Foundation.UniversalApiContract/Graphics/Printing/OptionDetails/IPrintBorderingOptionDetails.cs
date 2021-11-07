// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintBorderingOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ExclusiveTo(typeof (PrintBorderingOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1299430543, 64339, 20146, 152, 95, 29, 145, 222, 11, 118, 57)]
  internal interface IPrintBorderingOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
