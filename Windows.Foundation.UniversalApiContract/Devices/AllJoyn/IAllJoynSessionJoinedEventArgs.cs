// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionJoinedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2661243856, 46551, 18373, 141, 171, 176, 64, 204, 25, 40, 113)]
  [Deprecated("AllJoynSessionJoinedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynSessionJoinedEventArgs))]
  internal interface IAllJoynSessionJoinedEventArgs
  {
    AllJoynSession Session { [Deprecated("AllJoynSessionJoinedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
