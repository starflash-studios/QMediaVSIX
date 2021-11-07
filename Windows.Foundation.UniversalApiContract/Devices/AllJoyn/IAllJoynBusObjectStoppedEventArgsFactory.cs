// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusObjectStoppedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1797455176, 53411, 16981, 149, 58, 71, 114, 180, 2, 128, 115)]
  [Deprecated("AllJoynBusObjectStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynBusObjectStoppedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynBusObjectStoppedEventArgsFactory
  {
    [Deprecated("AllJoynBusObjectStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynBusObjectStoppedEventArgs Create(int status);
  }
}
