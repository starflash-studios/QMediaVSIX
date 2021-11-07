// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(4077515091, 7917, 17091, 162, 14, 67, 109, 65, 254, 98, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynBusAttachment
  {
    AllJoynAboutData AboutData { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string ConnectionSpecification { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    AllJoynBusAttachmentState State { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string UniqueName { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<int> PingAsync(string uniqueName);

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void Connect();

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void Disconnect();

    event TypedEventHandler<AllJoynBusAttachment, AllJoynBusAttachmentStateChangedEventArgs> StateChanged;

    IVector<AllJoynAuthenticationMechanism> AuthenticationMechanisms { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsRequestedEventArgs> CredentialsRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsVerificationRequestedEventArgs> CredentialsVerificationRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynAuthenticationCompleteEventArgs> AuthenticationComplete;
  }
}
