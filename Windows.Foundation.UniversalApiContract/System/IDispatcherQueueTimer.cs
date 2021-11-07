// Decompiled with JetBrains decompiler
// Type: Windows.System.IDispatcherQueueTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DispatcherQueueTimer))]
  [Guid(1609218845, 41756, 18215, 177, 172, 55, 69, 70, 73, 213, 106)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IDispatcherQueueTimer
  {
    TimeSpan Interval { get; set; }

    bool IsRunning { get; }

    bool IsRepeating { get; set; }

    void Start();

    void Stop();

    event TypedEventHandler<DispatcherQueueTimer, object> Tick;
  }
}
