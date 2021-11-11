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
    /// <param name="Package">Owner package, not null.</param>
    public static async Task<SimpleCommand<T>> InitializeAsync( AsyncPackage Package ) {
        // Switch to the main thread - the call to AddCommand in SkipNextCommand's constructor requires
        // the UI thread.
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

        OleMenuCommandService CommandService = await Package.GetServiceAsync<IMenuCommandService, OleMenuCommandService>() ?? throw new ArgumentNullException(nameof(CommandService));

        Type Tp = typeof(T);
        Debug.WriteLine($"Type: {Tp.GetTypeName()}");
        //foreach(ConstructorInfo CI in Tp.GetConstructors(ConstructorSearchFlags) ) {
        //    int I = 0;
        //    foreach(ParameterInfo PI in CI.GetParameters() ) {
        //        if (PI.ParameterType)
        //    }
        //}
        ConstructorInfo? CI = Tp.GetConstructor(ConstructorSearchFlags, typeof(AsyncPackage), typeof(OleMenuCommandService));
        Debug.WriteLine($"Constructor: {CI}"); //Constructor returns null, consider manual checking of all constructors and comparing required parameter types. ;; Perhaps it's because the type is 'protected' 'private' in SessionCommand.
        object? Constructed = CI?.Invoke(new object[] { Package, CommandService });
        Debug.WriteLine($"Constructed: {Constructed}");
        return Constructed as SimpleCommand<T>;

        Debug.WriteLine($"Constructing: {typeof(T)}");
        return (SimpleCommand<T>)typeof(SimpleCommand<T>).GetConstructor(new[] { typeof(AsyncPackage), typeof(OleMenuCommandService) }).Invoke(new object[] {Package, CommandService});
        //Instance = new SimpleCommand<T>(Package, CommandService);
    }

    const BindingFlags ConstructorSearchFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
}