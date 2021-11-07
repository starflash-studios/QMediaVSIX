// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynSessionMemberAddedEventArgs))]
  [Guid(1235384714, 3537, 18113, 156, 214, 39, 25, 14, 80, 58, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynSessionMemberAddedEventArgs
  {
    string UniqueName { [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
