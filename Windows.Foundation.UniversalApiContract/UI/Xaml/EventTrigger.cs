// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.EventTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a trigger that applies a set of actions (animation storyboards) in response to an event. Not commonly used. See Remarks.</summary>
  [ContentProperty(Name = "Actions")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EventTrigger : TriggerBase, IEventTrigger
  {
    /// <summary>Initializes a new instance of the EventTrigger class.</summary>
    [MethodImpl]
    public extern EventTrigger();

    /// <summary>Gets or sets the name of the event that initiates the trigger. Not commonly set, see Remarks.</summary>
    /// <returns>The name or identifier of the event.</returns>
    public extern RoutedEvent RoutedEvent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of BeginStoryboard objects that this EventTrigger maintains.</summary>
    /// <returns>The existing TriggerActionCollection.</returns>
    public extern TriggerActionCollection Actions { [MethodImpl] get; }
  }
}
