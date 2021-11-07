// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppAttributeError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (IppAttributeError))]
  [Guid(1963978145, 40687, 23609, 147, 228, 70, 20, 155, 188, 239, 39)]
  internal interface IIppAttributeError
  {
    IppAttributeErrorReason Reason { get; }

    HResult ExtendedError { get; }

    IVectorView<IppAttributeValue> GetUnsupportedValues();
  }
}
