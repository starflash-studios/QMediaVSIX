// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.TimeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a time event that triggers a background task to run.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(typeof (ITimeTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimeTrigger : ITimeTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a time event trigger.</summary>
    /// <param name="freshnessTime">Specifies the number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after *freshnessTime* elapses. If the OneShot property is false, *freshnessTime* specifies the interval between recurring tasks.</param>
    /// <param name="oneShot">True if the time event trigger will be used once; false if it will be used each time *freshnessTime* elapses.</param>
    [MethodImpl]
    public extern TimeTrigger(uint freshnessTime, bool oneShot);

    /// <summary>Gets the interval of a time event trigger.</summary>
    /// <returns>Specifies the number of minutes to wait before scheduling the background task. The minimum value for **FreshnessTime** is 15 minutes. The system schedules the task within 15 minutes after **FreshnessTime** elapses.</returns>
    public extern uint FreshnessTime { [MethodImpl] get; }

    /// <summary>Gets whether the time event trigger will be used only once or each time the FreshnessTime interval elapses.</summary>
    /// <returns>True if the time event trigger will be used once; false if it will be used each time the FreshnessTime interval elapses.</returns>
    public extern bool OneShot { [MethodImpl] get; }
  }
}
