// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a system event that triggers a background task to run.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(typeof (ISystemTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class SystemTrigger : ISystemTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a system event trigger.</summary>
    /// <param name="triggerType">Specifies the system event type.</param>
    /// <param name="oneShot">True if the system event trigger will be used once; false if it will be used every time the event occurs.</param>
    [MethodImpl]
    public extern SystemTrigger(SystemTriggerType triggerType, bool oneShot);

    /// <summary>Gets whether a system event trigger will be used only once.</summary>
    /// <returns>True if the system event trigger will be used only once; false if it will be used every time the event occurs.</returns>
    public extern bool OneShot { [MethodImpl] get; }

    /// <summary>Gets the system event type of a system event trigger.</summary>
    /// <returns>A system event type.</returns>
    public extern SystemTriggerType TriggerType { [MethodImpl] get; }
  }
}
