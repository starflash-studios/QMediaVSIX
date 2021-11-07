// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the UIElement.CharacterReceived  routed event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  public sealed class CharacterReceivedRoutedEventArgs : 
    RoutedEventArgs,
    ICharacterReceivedRoutedEventArgs
  {
    /// <summary>Gets the composed character associated with the UIElement.CharacterReceived event. </summary>
    /// <returns>The composed character associated with the UIElement.CharacterReceived event.</returns>
    public extern char Character { [MethodImpl] get; }

    /// <summary>Gets the status of the physical key that raised the character-received event.</summary>
    /// <returns>The status of the key that was pressed.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
