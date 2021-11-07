// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4117891825, 43166, 17062, 129, 175, 248, 224, 16, 179, 138, 104)]
  [ExclusiveTo(typeof (PrintTaskOptionDetails))]
  internal interface IPrintTaskOptionDetails
  {
    IMapView<string, IPrintOptionDetails> Options { get; }

    PrintCustomItemListOptionDetails CreateItemListOption(
      string optionId,
      string displayName);

    PrintCustomTextOptionDetails CreateTextOption(
      string optionId,
      string displayName);

    event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

    event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;
  }
}
