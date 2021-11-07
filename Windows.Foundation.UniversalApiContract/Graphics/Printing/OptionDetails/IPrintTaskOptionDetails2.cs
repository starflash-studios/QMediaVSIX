// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1400048137, 63848, 18066, 161, 119, 192, 116, 89, 113, 134, 219)]
  [ExclusiveTo(typeof (PrintTaskOptionDetails))]
  internal interface IPrintTaskOptionDetails2
  {
    PrintCustomToggleOptionDetails CreateToggleOption(
      string optionId,
      string displayName);
  }
}
