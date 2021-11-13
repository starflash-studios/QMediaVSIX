#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel.Design;
using System.Globalization;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

using QMediaVSIX.Controls;

#endregion

namespace QMediaVSIX.Commands;

internal abstract class SimpleCommand : NotifyPropertyChange {
    /// <summary>
    /// The title of the command.
    /// </summary>
    public abstract string Title { get; }

    /// <summary>
    /// Command ID.
    /// </summary>
    protected abstract int SelfCommandId { get; }

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    protected abstract Guid SelfCommandSet { get; }

    /// <summary>
    /// VS Package that provides this command, not null.
    /// </summary>
    protected readonly AsyncPackage Package;

    /// <summary>
    /// Initialises a new instance of the current command class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    protected SimpleCommand( AsyncPackage Package, OleMenuCommandService CommandService ) {
        this.Package = Package          ?? throw new ArgumentNullException(nameof(Package));
        CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));
        // ReSharper disable once VirtualMemberCallInConstructor
        CtoAddToMenu(Package, CommandService);
    }

    public virtual void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        CommandID MenuCommandID = new CommandID(SelfCommandSet, SelfCommandId);
        MenuCommand MenuItem = new MenuCommand(Execute, MenuCommandID);
        CommandService.AddCommand(MenuItem);
    }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    protected static SimpleCommand? Instance { get; } = null;

    /// <summary>
    /// Gets the service provider from the owner package.
    /// </summary>
    protected IAsyncServiceProvider ServiceProvider => Package;

    /// <summary>
    /// This function is the callback used to execute the command when the menu item is clicked.
    /// See the constructor to see how the menu item is associated with this function using
    /// OleMenuCommandService service and MenuCommand class.
    /// </summary>
    /// <param name="Sender">Event sender.</param>
    /// <param name="E">Event args.</param>
    public virtual void Execute( object Sender, EventArgs E ) {
        ThreadHelper.ThrowIfNotOnUIThread();
        string Message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetTypeName(true));

        // Show a message box to prove we were here
        VsShellUtilities.ShowMessageBox(
            Package,
            Message,
            Title,
            OLEMSGICON.OLEMSGICON_INFO,
            OLEMSGBUTTON.OLEMSGBUTTON_OK,
            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
    }

    /// <summary>
    /// Sets the command to be enabled, returning <see langword="true"/> if successful.
    /// </summary>
    /// <param name="MakeEnabled">Whether to make the command enabled or disabled. Command is enabled if <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the change was successful.</returns>
    public bool SetCommandEnabled( bool MakeEnabled = true ) => ChangeEnableable(MakeEnabled);

    /// <summary>
    /// Sets the command to be disabled, returning <see langword="true"/> if successful.
    /// </summary>
    /// <param name="MakeDisabled">Whether to make the command disabled or enabled. Command is disabled if <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the change was successful.</returns>
    public bool SetCommandDisabled( bool MakeDisabled = true ) => ChangeEnableable(!MakeDisabled);

    internal bool ChangeEnableable( bool EnableCmd ) => ChangeEnableable(Package, new CommandID(SelfCommandSet, SelfCommandId), EnableCmd);

    public static bool ChangeEnableable( AsyncPackage Package, CommandID CmdID, bool EnableCmd ) {
        OleMenuCommandService Mcs = Package.GetService<IMenuCommandService, OleMenuCommandService>();
        MenuCommand? MC = Mcs.FindCommand(CmdID);
        if ( MC is not null ) {
            MC.Enabled = EnableCmd;
            return true;
        }
        Debug.WriteLine($"MenuCommand was unable to be found for {CmdID}");
        return false;
    }
}