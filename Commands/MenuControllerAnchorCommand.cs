#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.Generic;
using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Collections;
using QMediaVSIX.Core;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal abstract class MenuControllerAnchorCommand<T> : SessionCommand<T> where T : MenuControllerAnchorCommand<T> {

    protected MenuControllerAnchorCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }
}

internal abstract class MenuControllerCommand<T, TStore> : SessionCommand<T> where T : MenuControllerCommand<T, TStore> {

    public readonly FauxFirstList<(string Name, TStore Stored)> Items;

    /// <summary>
    /// Initialises a new instance of the <see cref="PlayCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    /// <param name="InitialStorage">The initial collection of menu choices.</param>
    /// <param name="InitialChosen">The first menu choice to check.</param>
    protected MenuControllerCommand( AsyncPackage Package, OleMenuCommandService CommandService, IEnumerable<(string Name, TStore Stored)> InitialStorage, uint InitialChosen ) : base(Package, CommandService) {
        Items = new FauxFirstList<(string, TStore)>(("none", default!), InitialStorage);
        // ReSharper disable once VirtualMemberCallInConstructor
        CurrentChosenOption = InitialChosen;
    }

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        //base.CtoAddToMenu(Package, CommandService);
        CommandID DynamicItemRootID = new CommandID(new Guid(QMediaVSIXPackage.guidQMediaVSIXPackageToolbarItemCmdSet), (int)QMediaVSIXPackage.cmdidPlayCommand);
        MenuControllerItemMenuCommand DMC = new MenuControllerItemMenuCommand(DynamicItemRootID, IsValidDynamicItem, OnInvokedDynamicItem, OnBeforeQueryStatusDynamicItem);
        CommandService.AddCommand(DMC);
    }

    void OnInvokedDynamicItem( object Sender, EventArgs E ) {
        MenuControllerItemMenuCommand DMC = (MenuControllerItemMenuCommand)Sender;
        Debug.WriteLine($"INVOKED!! {DMC.Text} ({DMC.Checked})");
        if ( DMC.Checked ) {
            return;
        }

        if ( DMC.Text == "none" ) {
            Debug.WriteLine("Setting active as null.");
            CurrentChosenOption = 0;
            //SessionCommandManager.SetActiveFromCommand(null);
            return;
        }

        int In = Items.FindIndex(Tp => Tp.Name == DMC.Text);
        // ReSharper disable once ConvertSwitchStatementToSwitchExpression
        switch ( In ) {
            case > 0:
                CurrentChosenOption = (uint)In;
                //SessionCommandManager.SetActiveFromCommand(Items[In].Session);
                break;
            //case 0:
            //case <= 0:
            default:
                CurrentChosenOption = 0;
                //SessionCommandManager.SetActiveFromCommand(null);
                break;
        }
    }

    void OnBeforeQueryStatusDynamicItem( object Sender, EventArgs E ) {
        MenuControllerItemMenuCommand DMC = (MenuControllerItemMenuCommand)Sender;
        DMC.Enabled = true;
        DMC.Visible = true;

        bool IsRoot = DMC.MatchedCommandId == 0;
        //Debug.WriteLine($"Checking for {DMC.MatchedCommandId}");
        if ( IsRoot ) {
            //Debug.WriteLine(0);
            DMC.Text = Items[(int)CurrentChosenOption].Name;
            DMC.Checked = true;
        } else {
            int Delta = DMC.MatchedCommandId - SelfCommandId;
            //Debug.WriteLine(Delta);
            if ( Delta <= CurrentChosenOption ) {
                Delta--;
            }
            DMC.Text = Items[Delta].Name;
            DMC.Checked = false;
        }

        DMC.MatchedCommandId = 0;
    }

    bool IsValidDynamicItem( int CmdID ) {
        ThreadHelper.ThrowIfNotOnUIThread();
        bool CheckA = CmdID >= SelfCommandId;
        bool CheckB = CmdID - SelfCommandId < Items.Count; //+1 for 'none' option
        return CheckA && CheckB;
        //Up to 100 items can be defined. No additional checks are required though, as Visual Studio will never call this function at a delta value greater than 100 anyways.
    }

    // ReSharper disable once InconsistentNaming
    internal uint _CurrentChosenOption;

    public virtual uint CurrentChosenOption {
        get => _CurrentChosenOption;
        set {
            if ( value != _CurrentChosenOption ) {
                Debug.WriteLine($"Changed to {value}");
                RaisePropertyChanging();
                _CurrentChosenOption = value;
                RaisePropertyChanged();
            } else {
                Debug.WriteLine($"Equal change ignored (wanted from: {_CurrentChosenOption} to {value})");
            }
        }
    }

    public TStore? CurrentChosen => CurrentChosenOption < 0 ? default : Items[(int)CurrentChosenOption].Stored;

    public void ChangeChosenOption( TStore? Session ) =>
        CurrentChosenOption = Session switch {
            { } S when Items.FindIndex(T => T.Stored.SafeEquals(S)) is var In => (uint)In,
            _                                                            => 0u
        };

    internal class MenuControllerItemMenuCommand : OleMenuCommand {
        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, CommandID ID ) : base(InvokeHandler, ID) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, CommandID ID, bool QueryStatusSupported ) : base(InvokeHandler, ID, QueryStatusSupported) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, CommandID ID, string Text ) : base(InvokeHandler, ID, Text) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, CommandID ID ) : base(InvokeHandler, ChangeHandler, ID) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, CommandID ID, string Text ) : base(InvokeHandler, ChangeHandler, ID, Text) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, EventHandler BeforeQueryStatus, CommandID ID ) : base(InvokeHandler, ChangeHandler, BeforeQueryStatus, ID) { }

        /// <inheritdoc />
        public MenuControllerItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, EventHandler BeforeQueryStatus, CommandID ID, string Text ) : base(InvokeHandler, ChangeHandler, BeforeQueryStatus, ID, Text) { }


        public Func<int, bool> DynamicItemMatchVerifier = default!;

        public MenuControllerItemMenuCommand( CommandID RootID, Func<int, bool> DynamicItemMatchVerifier, EventHandler InvokeHandler, EventHandler BeforeQueryStatusHandler ) : base(InvokeHandler, null, BeforeQueryStatusHandler, RootID) => this.DynamicItemMatchVerifier = DynamicItemMatchVerifier;

        public override bool DynamicItemMatch( int CmdID ) {
            if ( DynamicItemMatchVerifier(CmdID) ) {
                MatchedCommandId = CmdID;
                return true;
            }

            MatchedCommandId = 0;
            return false;
        }
    }
}