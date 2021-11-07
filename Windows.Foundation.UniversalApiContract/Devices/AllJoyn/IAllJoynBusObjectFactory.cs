// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusObjectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(741318411, 36354, 20380, 172, 39, 234, 109, 173, 93, 59, 80)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynBusObject))]
  internal interface IAllJoynBusObjectFactory
  {
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynBusObject Create(string objectPath);

    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynBusObject CreateWithBusAttachment(
      string objectPath,
      AllJoynBusAttachment busAttachment);
  }
}
