// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceWatcherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that causes a background task to run when changes occur to the list of devices. Returned by GetBackgroundTrigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class DeviceWatcherTrigger : IDeviceWatcherTrigger, IBackgroundTrigger
  {
  }
}
