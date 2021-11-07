// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTaskOptions))]
  [Guid(1510631099, 53897, 16827, 150, 221, 87, 226, 131, 56, 174, 63)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPrintTaskOptions
  {
    PrintBordering Bordering { set; get; }

    IRandomAccessStream GetPagePrintTicket(PrintPageInfo printPageInfo);
  }
}
