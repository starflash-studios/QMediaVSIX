// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberRemovedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynSessionMemberRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynSessionMemberRemovedEventArgs))]
  [Guid(3302184424, 17080, 19303, 183, 87, 208, 207, 202, 213, 146, 128)]
  internal interface IAllJoynSessionMemberRemovedEventArgsFactory
  {
    [Deprecated("AllJoynSessionMemberRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynSessionMemberRemovedEventArgs Create(
      string uniqueName);
  }
}
