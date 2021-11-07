// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.UICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a command in a context menu.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IUICommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UICommand : IUICommand
  {
    /// <summary>Creates a new instance of the UICommand class using the specified label.</summary>
    /// <param name="label">The label for the UICommand.</param>
    [MethodImpl]
    public extern UICommand(string label);

    /// <summary>Creates a new instance of the UICommand class using the specified label and event handler.</summary>
    /// <param name="label">The label for the new command.</param>
    /// <param name="action">The event handler for the new command.</param>
    [MethodImpl]
    public extern UICommand(string label, UICommandInvokedHandler action);

    /// <summary>Creates a new instance of the UICommand class using the specified label, event handler, and command identifier.</summary>
    /// <param name="label">The label for the new command.</param>
    /// <param name="action">The event handler for the new command.</param>
    /// <param name="commandId">The command identifier for the new command.</param>
    [MethodImpl]
    public extern UICommand(string label, UICommandInvokedHandler action, [Variant] object commandId);

    /// <summary>Creates a new instance of the UICommand class.</summary>
    [MethodImpl]
    public extern UICommand();

    /// <summary>Gets or sets the label for the command.</summary>
    /// <returns>The label for the command.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the handler for the event that is fired when the user selects the UICommand.</summary>
    /// <returns>The event handler associated with the UICommand.</returns>
    public extern UICommandInvokedHandler Invoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier of the command.</summary>
    /// <returns>Represents the identifier of the command.</returns>
    public extern object Id { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }
  }
}
