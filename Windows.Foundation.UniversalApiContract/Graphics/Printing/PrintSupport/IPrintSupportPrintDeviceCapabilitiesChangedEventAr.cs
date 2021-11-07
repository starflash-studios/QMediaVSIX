// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportPrintDeviceCapabilitiesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintSupport
{
  [ExclusiveTo(typeof (PrintSupportPrintDeviceCapabilitiesChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(362191856, 36904, 22306, 138, 55, 125, 124, 52, 180, 29, 214)]
  internal interface IPrintSupportPrintDeviceCapabilitiesChangedEventArgs
  {
    XmlDocument GetCurrentPrintDeviceCapabilities();

    void UpdatePrintDeviceCapabilities(XmlDocument updatedPdc);

    Deferral GetDeferral();
  }
}
