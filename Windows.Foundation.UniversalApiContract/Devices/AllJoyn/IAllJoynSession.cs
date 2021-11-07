// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(3906018060, 49364, 16492, 136, 169, 169, 62, 250, 133, 212, 177)]
  [ExclusiveTo(typeof (AllJoynSession))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynSession
  {
    int Id { [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    int Status { [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<int> RemoveMemberAsync(string uniqueName);

    event TypedEventHandler<AllJoynSession, AllJoynSessionMemberAddedEventArgs> MemberAdded;

    event TypedEventHandler<AllJoynSession, AllJoynSessionMemberRemovedEventArgs> MemberRemoved;

    event TypedEventHandler<AllJoynSession, AllJoynSessionLostEventArgs> Lost;
  }
}
