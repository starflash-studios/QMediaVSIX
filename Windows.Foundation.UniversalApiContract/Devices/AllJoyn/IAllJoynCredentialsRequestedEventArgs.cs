// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentialsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1787290446, 45161, 19328, 158, 26, 65, 188, 131, 124, 101, 210)]
  [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynCredentialsRequestedEventArgs))]
  internal interface IAllJoynCredentialsRequestedEventArgs
  {
    ushort AttemptCount { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    AllJoynCredentials Credentials { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string PeerUniqueName { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string RequestedUserName { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    Deferral GetDeferral();
  }
}
