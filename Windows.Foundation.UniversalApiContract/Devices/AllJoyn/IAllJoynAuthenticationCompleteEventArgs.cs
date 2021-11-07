// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAuthenticationCompleteEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(2545184796, 5596, 19283, 182, 164, 125, 19, 67, 0, 215, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynAuthenticationCompleteEventArgs))]
  internal interface IAllJoynAuthenticationCompleteEventArgs
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string PeerUniqueName { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    bool Succeeded { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
