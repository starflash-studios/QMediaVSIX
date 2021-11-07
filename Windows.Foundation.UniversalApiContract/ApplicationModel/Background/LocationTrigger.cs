// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.LocationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a location event that triggers a background task. This is used for Geofencing.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILocationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class LocationTrigger : ILocationTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a location event trigger.</summary>
    /// <param name="triggerType">The type of location event for this trigger.</param>
    [MethodImpl]
    public extern LocationTrigger(LocationTriggerType triggerType);

    /// <summary>The type of location event for this trigger.</summary>
    /// <returns>The type of location event for this trigger.</returns>
    public extern LocationTriggerType TriggerType { [MethodImpl] get; }
  }
}
