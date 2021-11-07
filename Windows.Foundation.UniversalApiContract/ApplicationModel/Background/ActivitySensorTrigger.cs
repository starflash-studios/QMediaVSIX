// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ActivitySensorTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that is activated when the ActivitySensor receives input. This is used when your application needs to respond to the activity sensor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IActivitySensorTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ActivitySensorTrigger : IActivitySensorTrigger, IBackgroundTrigger
  {
    /// <summary>Creates an instance of the ActivitySensorTrigger class with an initial MinimumReportInterval.</summary>
    /// <param name="reportIntervalInMilliseconds">The initial report interval to use for MinimumReportInterval.</param>
    [MethodImpl]
    public extern ActivitySensorTrigger(uint reportIntervalInMilliseconds);

    /// <summary>Gets or sets the list of activities your trigger is subscribed to.</summary>
    /// <returns>The list of subscribed activities.</returns>
    public extern IVector<ActivityType> SubscribedActivities { [MethodImpl] get; }

    /// <summary>Gets the report interval for the trigger.</summary>
    /// <returns>The current report interval for the trigger in milliseconds.</returns>
    public extern uint ReportInterval { [MethodImpl] get; }

    /// <summary>Gets the list of supported activities you can subscribe to.</summary>
    /// <returns>The list of supported activities for subscription.</returns>
    public extern IVectorView<ActivityType> SupportedActivities { [MethodImpl] get; }

    /// <summary>Gets the minimum supported report interval for the sensor trigger.</summary>
    /// <returns>The minimum supported interval in milliseconds.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }
  }
}
