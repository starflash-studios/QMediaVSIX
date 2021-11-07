// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.ISignalNotifierStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [Guid(474891622, 33792, 18131, 161, 21, 125, 12, 13, 252, 159, 98)]
  [ExclusiveTo(typeof (SignalNotifier))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISignalNotifierStatics
  {
    [Overload("AttachToEvent")]
    SignalNotifier AttachToEvent(string name, SignalHandler handler);

    [Overload("AttachToEventWithTimeout")]
    SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler,
      TimeSpan timeout);

    [Overload("AttachToSemaphore")]
    SignalNotifier AttachToSemaphore(string name, SignalHandler handler);

    [Overload("AttachToSemaphoreWithTimeout")]
    SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler,
      TimeSpan timeout);
  }
}
