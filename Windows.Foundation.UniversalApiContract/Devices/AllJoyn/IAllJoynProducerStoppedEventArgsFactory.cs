// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducerStoppedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(1448253793, 45593, 19822, 159, 120, 250, 63, 153, 250, 143, 229)]
  [ExclusiveTo(typeof (AllJoynProducerStoppedEventArgs))]
  [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynProducerStoppedEventArgsFactory
  {
    [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    AllJoynProducerStoppedEventArgs Create(int status);
  }
}
