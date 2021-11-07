// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynMessageInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynMessageInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(879119402, 33417, 17364, 180, 168, 63, 77, 227, 89, 240, 67)]
  [Deprecated("AllJoynMessageInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynMessageInfoFactory
  {
    [Deprecated("AllJoynMessageInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynMessageInfo Create(string senderUniqueName);
  }
}
