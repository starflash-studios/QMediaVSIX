// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterPrintOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (PosPrinterPrintOptions))]
  [Guid(170792701, 7426, 23128, 157, 89, 191, 205, 231, 111, 222, 134)]
  internal interface IPosPrinterPrintOptions
  {
    string TypeFace { get; set; }

    uint CharacterHeight { get; set; }

    bool Bold { get; set; }

    bool Italic { get; set; }

    bool Underline { get; set; }

    bool ReverseVideo { get; set; }

    bool Strikethrough { get; set; }

    bool Superscript { get; set; }

    bool Subscript { get; set; }

    bool DoubleWide { get; set; }

    bool DoubleHigh { get; set; }

    PosPrinterAlignment Alignment { get; set; }

    uint CharacterSet { get; set; }
  }
}
