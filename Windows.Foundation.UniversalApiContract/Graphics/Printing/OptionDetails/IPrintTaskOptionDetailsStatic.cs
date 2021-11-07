// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetailsStatic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ExclusiveTo(typeof (PrintTaskOptionDetails))]
  [Guid(324903315, 2401, 19310, 135, 102, 241, 59, 127, 188, 205, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskOptionDetailsStatic
  {
    PrintTaskOptionDetails GetFromPrintTaskOptions(
      PrintTaskOptions printTaskOptions);
  }
}
