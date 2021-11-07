// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppSetAttributesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ExclusiveTo(typeof (IppSetAttributesResult))]
  [Guid(2099019605, 43677, 22691, 144, 233, 23, 189, 197, 40, 31, 7)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IIppSetAttributesResult
  {
    bool Succeeded { get; }

    IMapView<string, IppAttributeError> AttributeErrors { get; }
  }
}
