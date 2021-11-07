// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducerStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1362138992, 18743, 18733, 128, 128, 35, 100, 57, 152, 124, 235)]
  [ExclusiveTo(typeof (AllJoynProducerStoppedEventArgs))]
  [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynProducerStoppedEventArgs
  {
    int Status { [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
