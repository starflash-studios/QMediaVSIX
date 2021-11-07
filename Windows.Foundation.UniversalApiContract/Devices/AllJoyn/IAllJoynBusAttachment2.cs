// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachment2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [Guid(880069406, 9064, 17330, 180, 62, 106, 58, 193, 39, 141, 152)]
  internal interface IAllJoynBusAttachment2
  {
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("GetAboutDataAsync")]
    IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo);

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("GetAboutDataWithLanguageAsync")]
    IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo,
      Language language);

    event TypedEventHandler<AllJoynBusAttachment, AllJoynAcceptSessionJoinerEventArgs> AcceptSessionJoinerRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynSessionJoinedEventArgs> SessionJoined;
  }
}
