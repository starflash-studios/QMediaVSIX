// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynSession))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2651182596, 41068, 18132, 180, 108, 11, 11, 84, 16, 91, 68)]
  internal interface IAllJoynSessionStatics
  {
    [Overload("GetFromServiceInfoAsync")]
    [RemoteAsync]
    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo);

    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("GetFromServiceInfoAndBusAttachmentAsync")]
    IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo,
      AllJoynBusAttachment busAttachment);
  }
}
