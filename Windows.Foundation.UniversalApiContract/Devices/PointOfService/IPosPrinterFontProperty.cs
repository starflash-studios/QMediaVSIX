// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterFontProperty
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2817845562, 63660, 24324, 132, 210, 41, 177, 109, 138, 99, 60)]
  [ExclusiveTo(typeof (PosPrinterFontProperty))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IPosPrinterFontProperty
  {
    string TypeFace { get; }

    bool IsScalableToAnySize { get; }

    IVectorView<SizeUInt32> CharacterSizes { get; }
  }
}
