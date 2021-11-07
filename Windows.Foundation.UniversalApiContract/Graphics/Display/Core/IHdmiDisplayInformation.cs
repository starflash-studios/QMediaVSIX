// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.IHdmiDisplayInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ExclusiveTo(typeof (HdmiDisplayInformation))]
  [Guid(319503370, 62821, 18286, 171, 213, 234, 5, 174, 231, 76, 105)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHdmiDisplayInformation
  {
    IVectorView<HdmiDisplayMode> GetSupportedDisplayModes();

    HdmiDisplayMode GetCurrentDisplayMode();

    [RemoteAsync]
    IAsyncAction SetDefaultDisplayModeAsync();

    [Overload("RequestSetCurrentDisplayModeAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(HdmiDisplayMode mode);

    [RemoteAsync]
    [Overload("RequestSetCurrentDisplayModeWithHdrAsync")]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption);

    [Overload("RequestSetCurrentDisplayModeWithHdrAndMetadataAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption,
      HdmiDisplayHdr2086Metadata hdrMetadata);

    event TypedEventHandler<HdmiDisplayInformation, object> DisplayModesChanged;
  }
}
