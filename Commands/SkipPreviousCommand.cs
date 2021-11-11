#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class SkipPreviousCommand : SessionCommand<SkipPreviousCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4129;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");


    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;


    /// <summary>
    /// Initialises a new instance of the <see cref="SkipPreviousCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    
    public SkipPreviousCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static SkipPreviousCommand? Instance { get; set; }

    /// <inheritdoc />
    public override string Title => "Skip Previous";

    public override void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine($"Skipping previous in {Current?.ToString() ?? "<NULL>"}");
        Current?.SkipPrevious();
    }
}