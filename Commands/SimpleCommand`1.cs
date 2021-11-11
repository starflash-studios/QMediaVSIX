#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel.Design;
using System.Reflection;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), nameof(InitializeAsync))]
internal abstract class SimpleCommand<T> : SimpleCommand where T : SimpleCommand {
    /// <inheritdoc />
    protected SimpleCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    // ReSharper disable once UnassignedGetOnlyAutoProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    protected new static SimpleCommand<T>? Instance { get; }

    /// <summary>
    /// Initialises the singleton instance of the command.
    /// </summary>
    public static async Task<object> InitializeAsync() {
        //Debug.WriteLine("Will initialise...");
        if (typeof(T).IsAbstract || typeof(T).IsInterface ) {
            //Debug.WriteLine("...or not.");
            return null!;
        }

        AsyncPackage Package = QMediaVSIXPackage.Instance;
        // Switch to the main thread - the call to AddCommand in SkipNextCommand's constructor requires
        // the UI thread.
        //Debug.WriteLine("Switching main...");
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

        //Debug.WriteLine("Retrieving service...");
        OleMenuCommandService CommandService = await Package.GetServiceAsync<IMenuCommandService, OleMenuCommandService>() ?? throw new ArgumentNullException(nameof(CommandService), "No CommandService could be created at this time.");

        //Debug.WriteLine("Constructing...");
        Type Tp = typeof(T);
        ConstructorInfo? CI = Tp.GetConstructor(ConstructorSearchFlags, typeof(AsyncPackage), typeof(OleMenuCommandService));
        object? Constructed = CI?.Invoke(new object[] { Package, CommandService });
        //Debug.WriteLine($"Type: {Tp}\n\tCI: {CI}\n\tConstructed: {Constructed}");
        //Debug.WriteLine($"Constructing: {Tp.GetTypeName()}");
        return Constructed ?? throw new ArgumentNullException(nameof(Tp), "Constructor method returned null.");
    }

    const BindingFlags ConstructorSearchFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
}