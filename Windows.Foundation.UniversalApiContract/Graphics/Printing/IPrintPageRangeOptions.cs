// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintPageRangeOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(3463296808, 4951, 18098, 169, 35, 121, 249, 149, 244, 72, 252)]
  [ExclusiveTo(typeof (PrintPageRangeOptions))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintPageRangeOptions
  {
    bool AllowAllPages { set; get; }

    bool AllowCurrentPage { set; get; }

    bool AllowCustomSetOfPages { set; get; }
  }
}
