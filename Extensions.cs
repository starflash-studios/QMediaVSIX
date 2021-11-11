#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Threading;

using QMediaVSIX.Core.Collections;

#endregion

namespace QMediaVSIX;

public static class Extensions {

    //public static async Task<T?> GetServiceAsync<T>( this AsyncPackage Pkg ) where T : IMenuCommandService => await Pkg.GetServiceAsync(typeof(T)) switch {
    //		T Result => Result,
    //		_                => default
    //	};

    public static string? GetFriendlyName( this TypeCode TC ) =>
        TC switch {
            TypeCode.Empty => "null",
            TypeCode.Object => "object",
            TypeCode.DBNull => "DBNull",
            TypeCode.Boolean => "bool",
            TypeCode.Char => "char",
            TypeCode.SByte => "sbyte",
            TypeCode.Byte => "byte",
            TypeCode.Int16 => "short",
            TypeCode.UInt16 => "ushort",
            TypeCode.Int32 => "int",
            TypeCode.UInt32 => "uint",
            TypeCode.Int64 => "long",
            TypeCode.UInt64 => "ulong",
            TypeCode.Single => "float",
            TypeCode.Double => "double",
            TypeCode.Decimal => "decimal",
            TypeCode.DateTime => "DateTime",
            TypeCode.String => "string",
            _ => null
        };


    public static string GetTypeName<T>( this object? _, bool FullName = true ) => GetName(typeof(T), FullName);

    public static string GetTypeName( this object? Obj, bool FullName = true ) => GetName(Obj?.GetType(), FullName);

    public static string GetTypeName<T>( this T? _, bool FullName = true ) => GetName(typeof(T), FullName);

    public static string GetName<T>( bool FullName = true ) => GetName(typeof(T), FullName);

    public static string GetTypeName( this Type? T, bool FullName = true ) => GetName(T, FullName);

    public static string GetName( this Type? T, bool FullName = true ) {
        TypeCode TC = Type.GetTypeCode(T);
        return TC switch {
            TypeCode.Object => null,
            _ => GetFriendlyName(TC)
        } ?? (FullName ? GetFullNameInternal(T) : T?.Name ?? string.Empty);
    }

    internal static string GetFullNameInternal( Type? T ) => T switch { { } Tp => Tp.FullName switch { { } FN => FN,
        _ => $"{Tp.Assembly.FullName}.{Tp.Name}"
    },
        _ => string.Empty
    };

    public static IEnumerable<T> AsReversed<T>( this IList<T> Ls ) {
        int L = Ls.Count;
        for ( int I = L - 1; I >= 0; I-- ) {
            yield return Ls[I];
        }
    }

    public static ObservableCollection<TValue> GetLinkedCollection<TKey, TValue>(this ObservableDictionary<TKey, TValue> Dict ) where TKey : notnull {
        ObservableCollection<TValue> Coll = new ObservableCollection<TValue>(Dict.Values);
        Dict.KeyAdded += ( D, Key ) => {
            Coll.Add(D[Key]);
        };
        Dict.KeyRemoved += ( _, _, Value ) => {
            Coll.Remove(Value);
        };
        return Coll;
    }

    public static async Task<OleMenuCommandService?> GetMenuCommandServiceAsync( this AsyncPackage Pkg ) => await GetServiceAsync<IMenuCommandService, OleMenuCommandService>(Pkg);

    public static async Task<T?> GetServiceAsync<T>(this IAsyncServiceProvider Provider) =>
        await Provider.GetServiceAsync(typeof(T)) switch {
            T RetVal => RetVal,
            _        => default
        };

    public static async Task<TExact?> GetServiceAsync<TInt, TExact>( this IAsyncServiceProvider Provider ) {
        Type Tp = typeof(TInt);
        if ( !Tp.IsInterface ) { throw new NotSupportedException(); }
        return await Provider.GetServiceAsync(Tp) switch {
            TExact RetVal => RetVal,
            _             => default
        };
    }

    public static void RunInUI(this JoinableTaskFactory JTF, Func<Task> Tk) {
        _ = JTF.RunAsync(async () => {
            await JTF.SwitchToMainThreadAsync();
            await Tk.Invoke();
        });
    }

    [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Extension Method")]
    public static void RunInBackground( this JoinableTaskFactory JTF, Func<Action> Tk ) => _ = Task.Run(Tk.Invoke());

    public static T? GetCustomAttribute<T>( this Type Tp, bool CanReturnInherited = true ) where T : Attribute {
        foreach( object Attr in Tp.GetCustomAttributes(typeof(T), CanReturnInherited) ) {
            if ( Attr is T RetVal ) {
                return RetVal;
            }
        }
        return null;
    }

    //[DoesNotReturn]
    public static void ThrowIfNull( [/*[NotNull*/NotNullWhen(false)] this object? Param, [/*CallerArgumentExpression(nameof(Param))*/CallerMemberName] string? ParamName = null, [CallerLineNumber] int? LineNumber = null, [CallerFilePath] string? FilePath = null ) {
        if ( Param is null ) {
            throw new ArgumentNullException(ParamName, $"Parameter {ParamName} is null ({FilePath}@{LineNumber})");
        }
    }

    public static bool IsEqualOrSubclassOf( this Type Derived, Type Base ) => Derived == Base || Derived.IsSubclassOf(Base);

    public static ConstructorInfo? GetConstructor(this Type Tp, BindingFlags Flags, params Type[] ParamTypes ) {
        if ( ParamTypes.Length <= 0 ) {
            throw new NotSupportedException("Parameters must be present. For parameterless searches, utilise other existing extension methods.");
        }
        //Debug.WriteLine($"Checking {Tp} for constructors...");
        foreach ( ConstructorInfo CI in Tp.GetConstructors(Flags) ) {
            //Debug.WriteLine($"\tFound: {CI} -- does this match the {ParamTypes.Length} parameters?");
            int I = 0;
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach(ParameterInfo PI in CI.GetParameters() ) {
                //Debug.WriteLine($"\t\t{I}]{PI.ParameterType} {PI.Name} == {ParamTypes[I]}?");
                if (PI.ParameterType.IsEqualOrSubclassOf(ParamTypes[I])) {
                    I++;
                    if (I >= ParamTypes.Length ) {
                        //Debug.WriteLine("\tAbove was found to be valid.");
                        return CI;
                    }
                }
            }
        }
        return null;
    }

    public static PropertyInfo? GetMostDerivedProperty( this Type Tp, string PropertyName, BindingFlags Flags ) {
        PropertyInfo? RetProp = null;
        // ReSharper disable once LoopCanBePartlyConvertedToQuery
        foreach (PropertyInfo PI in Tp.GetProperties(Flags) ) {
            if (PI.Name == PropertyName ) {
                if (RetProp is null || PI.PropertyType.IsSubclassOf(RetProp.PropertyType) ) {
                    RetProp = PI;
                }
            }
        }
        return RetProp;
    }

    public static FieldInfo? GetMostDerivedField( this Type Tp, string PropertyName, BindingFlags Flags ) {
        FieldInfo? RetField = null;
        // ReSharper disable once LoopCanBePartlyConvertedToQuery
        foreach ( FieldInfo FI in Tp.GetFields(Flags) ) {
            if ( FI.Name == PropertyName ) {
                if ( RetField is null || FI.FieldType.IsSubclassOf(RetField.FieldType) ) {
                    RetField = FI;
                }
            }
        }
        return RetField;
    }
}