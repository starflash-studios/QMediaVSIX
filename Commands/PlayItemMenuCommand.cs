#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands; 

internal class PlayItemMenuCommand : OleMenuCommand {
    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, CommandID ID ) : base(InvokeHandler, ID) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, CommandID ID, bool QueryStatusSupported ) : base(InvokeHandler, ID, QueryStatusSupported) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, CommandID ID, string Text ) : base(InvokeHandler, ID, Text) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, CommandID ID ) : base(InvokeHandler, ChangeHandler, ID) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, CommandID ID, string Text ) : base(InvokeHandler, ChangeHandler, ID, Text) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, EventHandler BeforeQueryStatus, CommandID ID ) : base(InvokeHandler, ChangeHandler, BeforeQueryStatus, ID) { }

    /// <inheritdoc />
    public PlayItemMenuCommand( EventHandler InvokeHandler, EventHandler ChangeHandler, EventHandler BeforeQueryStatus, CommandID ID, string Text ) : base(InvokeHandler, ChangeHandler, BeforeQueryStatus, ID, Text) { }


    public Func<int, bool> DynamicItemMatchVerifier = default!;

    public PlayItemMenuCommand(CommandID RootID, Func<int, bool> DynamicItemMatchVerifier, EventHandler InvokeHandler, EventHandler BeforeQueryStatusHandler ) : base(InvokeHandler, null, BeforeQueryStatusHandler, RootID) => this.DynamicItemMatchVerifier = DynamicItemMatchVerifier;
    //this.BeforeQueryStatus += ( _, __ ) => { Debug.WriteLine("BQS"); };
    //this.CommandChanged += ( _, __ ) => { Debug.WriteLine("BQS"); };
    //public static void Change(object Sender, EventArgs E ) {
    //    Debug.WriteLine($"Change occurred on {Sender} ({E} ;; {E.GetTypeName()})");
    //}

    public override bool DynamicItemMatch( int CmdID ) {
        //Debug.WriteLine($"DIM {CmdID}");
        //Debug.WriteLine($"Checking match of {CmdID}");
        //base.DynamicItemMatch(cmdId);
        if ( DynamicItemMatchVerifier(CmdID) ) {
            MatchedCommandId = CmdID;
            return true;
        }

        MatchedCommandId = 0;
        return false;
    }
}