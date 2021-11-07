// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoinerEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynAcceptSessionJoinerEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3024313280, 24901, 17054, 132, 219, 213, 191, 231, 114, 177, 79)]
  [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynAcceptSessionJoinerEventArgsFactory
  {
    [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynAcceptSessionJoinerEventArgs Create(
      string uniqueName,
      ushort sessionPort,
      AllJoynTrafficType trafficType,
      byte proximity,
      IAllJoynAcceptSessionJoiner acceptSessionJoiner);
  }
}
