// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachmentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1680798116, 44421, 19935, 144, 174, 96, 68, 82, 178, 34, 136)]
  [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  internal interface IAllJoynBusAttachmentFactory
  {
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynBusAttachment Create(string connectionSpecification);
  }
}
