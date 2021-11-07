// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynServiceInfoRemovedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynServiceInfoRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynServiceInfoRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(230655527, 39679, 18773, 146, 39, 105, 83, 186, 244, 21, 105)]
  internal interface IAllJoynServiceInfoRemovedEventArgsFactory
  {
    [Deprecated("AllJoynServiceInfoRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynServiceInfoRemovedEventArgs Create(string uniqueName);
  }
}
