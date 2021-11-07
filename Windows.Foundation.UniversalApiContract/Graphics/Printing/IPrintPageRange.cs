// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintPageRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintPageRange))]
  [Guid(4171263060, 28284, 20933, 87, 253, 6, 96, 194, 215, 21, 19)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintPageRange
  {
    int FirstPageNumber { get; }

    int LastPageNumber { get; }
  }
}
