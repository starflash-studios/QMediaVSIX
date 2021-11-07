// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynWatcherStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(3388776507, 28701, 19112, 151, 221, 162, 187, 10, 143, 95, 163)]
  [ExclusiveTo(typeof (AllJoynWatcherStoppedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynWatcherStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  internal interface IAllJoynWatcherStoppedEventArgs
  {
    int Status { [Deprecated("AllJoynWatcherStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
