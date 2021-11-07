// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynServiceInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynServiceInfo))]
  [Guid(1971444413, 65027, 20299, 148, 164, 240, 47, 220, 189, 17, 184)]
  internal interface IAllJoynServiceInfoFactory
  {
    [Deprecated("AllJoynServiceInfo has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynServiceInfo Create(
      string uniqueName,
      string objectPath,
      ushort sessionPort);
  }
}
