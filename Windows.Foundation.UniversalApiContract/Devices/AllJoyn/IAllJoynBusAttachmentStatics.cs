// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2208124221, 4177, 16599, 135, 42, 141, 1, 65, 17, 91, 31)]
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  internal interface IAllJoynBusAttachmentStatics
  {
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynBusAttachment GetDefault();

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    DeviceWatcher GetWatcher(IIterable<string> requiredInterfaces);
  }
}
