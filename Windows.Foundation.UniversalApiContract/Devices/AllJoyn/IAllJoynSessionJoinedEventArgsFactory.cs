// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionJoinedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AllJoynSessionJoinedEventArgs))]
  [Guid(1747244681, 54987, 19870, 160, 158, 53, 128, 104, 112, 177, 127)]
  [Deprecated("AllJoynSessionJoinedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynSessionJoinedEventArgsFactory
  {
    [Deprecated("AllJoynSessionJoinedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynSessionJoinedEventArgs Create(AllJoynSession session);
  }
}
