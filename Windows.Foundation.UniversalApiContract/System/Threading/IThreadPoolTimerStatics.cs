// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolTimerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ExclusiveTo(typeof (ThreadPoolTimer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(445291778, 58498, 17947, 184, 199, 142, 250, 209, 204, 229, 144)]
  [WebHostHidden]
  internal interface IThreadPoolTimerStatics
  {
    [Overload("CreatePeriodicTimer")]
    ThreadPoolTimer CreatePeriodicTimer(TimerElapsedHandler handler, TimeSpan period);

    [Overload("CreateTimer")]
    ThreadPoolTimer CreateTimer(TimerElapsedHandler handler, TimeSpan delay);

    [Overload("CreatePeriodicTimerWithCompletion")]
    ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period,
      TimerDestroyedHandler destroyed);

    [Overload("CreateTimerWithCompletion")]
    ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay,
      TimerDestroyedHandler destroyed);
  }
}
