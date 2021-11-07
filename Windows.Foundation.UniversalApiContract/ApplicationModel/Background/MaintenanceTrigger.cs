// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MaintenanceTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a maintenance trigger.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(typeof (IMaintenanceTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MaintenanceTrigger : IMaintenanceTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a maintenance trigger.</summary>
    /// <param name="freshnessTime">The number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after *freshnessTime* elapses.</param>
    /// <param name="oneShot">True if the maintenance trigger is used once; false if it is used each time the *freshnessTime* interval elapses.</param>
    [MethodImpl]
    public extern MaintenanceTrigger(uint freshnessTime, bool oneShot);

    /// <summary>Gets the interval of a maintenance trigger.</summary>
    /// <returns>The number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after FreshnessTime elapses.</returns>
    public extern uint FreshnessTime { [MethodImpl] get; }

    /// <summary>Gets whether the maintenance trigger is used only once or each time the FreshnessTime interval elapses.</summary>
    /// <returns>True if the maintenance trigger is used once; false if it is used each time the FreshnessTime interval elapses.</returns>
    public extern bool OneShot { [MethodImpl] get; }
  }
}
