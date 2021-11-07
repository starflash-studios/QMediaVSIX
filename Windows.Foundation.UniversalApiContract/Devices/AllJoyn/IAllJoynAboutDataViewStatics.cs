// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutDataViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynAboutDataView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1475196552, 3166, 16750, 136, 181, 57, 179, 45, 37, 196, 125)]
  [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynAboutDataViewStatics
  {
    [Overload("GetDataBySessionPortAsync")]
    [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort);

    [Overload("GetDataBySessionPortWithLanguageAsync")]
    [RemoteAsync]
    [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort,
      Language language);
  }
}
