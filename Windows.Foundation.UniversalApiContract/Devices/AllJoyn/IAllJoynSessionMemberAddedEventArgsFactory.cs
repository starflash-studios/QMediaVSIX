// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionMemberAddedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(874373970, 7475, 16545, 161, 211, 229, 119, 112, 32, 225, 241)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynSessionMemberAddedEventArgs))]
  internal interface IAllJoynSessionMemberAddedEventArgsFactory
  {
    [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynSessionMemberAddedEventArgs Create(string uniqueName);
  }
}
