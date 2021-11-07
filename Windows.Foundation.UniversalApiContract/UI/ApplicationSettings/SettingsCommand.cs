// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.SettingsCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Creates a settings command object that represents a settings entry. This settings command can be appended to the ApplicationCommands vector.</summary>
  [DualApiPartition(version = 167772162)]
  [Static(typeof (ISettingsCommandStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISettingsCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SettingsCommand : IUICommand
  {
    /// <summary>Creates a new settings command.</summary>
    /// <param name="settingsCommandId">The ID of the command.</param>
    /// <param name="label">The label for the command, which is displayed in the settings pane.</param>
    /// <param name="handler">The event handler that is called when the user selects this command in the settings pane.</param>
    [MethodImpl]
    public extern SettingsCommand(
      [Variant] object settingsCommandId,
      string label,
      UICommandInvokedHandler handler);

    /// <summary>Gets or sets the label for the command.</summary>
    /// <returns>The label for the command.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the handler for the event that is raised when the user selects the command.</summary>
    /// <returns>The event handler associated with the command.</returns>
    public extern UICommandInvokedHandler Invoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command ID.</summary>
    /// <returns>The command ID.</returns>
    public extern object Id { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    /// <summary>Gets the command for a web account in the account settings pane.</summary>
    /// <returns>The command.</returns>
    public static extern SettingsCommand AccountsCommand { [MethodImpl] get; }
  }
}
