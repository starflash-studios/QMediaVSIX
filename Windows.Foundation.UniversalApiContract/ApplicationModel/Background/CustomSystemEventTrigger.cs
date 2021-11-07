// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.CustomSystemEventTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>This class allows you to specify a custom system trigger so that you can register it and respond when it is triggered by the system.</summary>
  [Activatable(typeof (ICustomSystemEventTriggerFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class CustomSystemEventTrigger : ICustomSystemEventTrigger, IBackgroundTrigger
  {
    /// <summary>Creates an instance of a **CustomSystemEventTrigger**, with the specified identifier and recurrence.</summary>
    /// <param name="triggerId">The identifier for the created **CustomSystemEventTrigger**.</param>
    /// <param name="recurrence">When the trigger may be activated.</param>
    [MethodImpl]
    public extern CustomSystemEventTrigger(
      string triggerId,
      CustomSystemEventTriggerRecurrence recurrence);

    /// <summary>The trigger identifier that uniquely identifies the background task that needs to be started by this trigger.</summary>
    /// <returns>The trigger identifier string.</returns>
    public extern string TriggerId { [MethodImpl] get; }

    /// <summary>Gets when this custom system event trigger may be activated.</summary>
    /// <returns>An enum that specifies when this custom system event trigger may be activated.</returns>
    public extern CustomSystemEventTriggerRecurrence Recurrence { [MethodImpl] get; }
  }
}
