#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

public static class SimpleCommandExtensions {
    public static async Task InitializeAllInAssemblyAsync( AsyncPackage Package ) {
        Type
            WantedGenericType = typeof(SimpleCommand<>),
            WantedType = typeof(SimpleCommand);
        object[] Params = { Package };
        // ReSharper disable once LoopCanBePartlyConvertedToQuery
        foreach ( Type Tp in Assembly.GetExecutingAssembly().GetTypes() ) {
            if ( !Tp.IsAbstract && Tp.IsSubclassOf(WantedType) && Tp.IsSubClassOfGeneric(WantedGenericType) ) {
                //First IsSubclassOf check speeds iteration of type members as it first checks if it's a command, then does a more expensive check to see if it is a strongly-typed command.
                //This helps with performance as the more expensive check is run less times, and only on likely candidates as opposed to every type in the assembly.
                Task Tk = (Task)Tp.GetMethod("InitializeAsync", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy).Invoke(null, Params);
                await Tk;
            }
        }
    }

    static bool IsSubClassOfGeneric( this Type Child, Type Parent ) {
        if ( Child == Parent ) {
            return false;
        }

        if ( Child.IsSubclassOf(Parent) ) {
            return true;
        }

        Type? Ch = Child;

        Type[] Parameters = Parent.GetGenericArguments();
        bool IsParameterLessGeneric = !(Parameters is { Length: > 0 } && ((Parameters[0].Attributes & TypeAttributes.BeforeFieldInit) == TypeAttributes.BeforeFieldInit));

        while ( Ch is not null && Ch != typeof(object) ) {
            Type Cur = GetFullTypeDefinition(Ch);
            if ( Parent == Cur || (IsParameterLessGeneric && Cur.GetInterfaces().Select(GetFullTypeDefinition).Contains(GetFullTypeDefinition(Parent))) ) {
                return true;
            }
            if ( !IsParameterLessGeneric ) {
                if ( GetFullTypeDefinition(Parent) == Cur && !Cur.IsInterface ) {
                    if ( VerifyGenericArguments(GetFullTypeDefinition(Parent), Cur) ) {
                        if ( VerifyGenericArguments(Parent, Ch) ) {
                            return true;
                        }
                    }
                } else {
                    if ( Ch.GetInterfaces().Where(I => GetFullTypeDefinition(Parent) == GetFullTypeDefinition(I)).Any(Item => VerifyGenericArguments(Parent, Item)) ) {
                        return true;
                    }
                }
            }

            Ch = Ch.BaseType;
        }

        return false;
    }

    static Type GetFullTypeDefinition( Type Type ) => Type.IsGenericType ? Type.GetGenericTypeDefinition() : Type;

    static bool VerifyGenericArguments( Type Parent, Type Child ) {
        Type[] ChildArguments = Child.GetGenericArguments();
        Type[] ParentArguments = Parent.GetGenericArguments();
        if ( ChildArguments.Length == ParentArguments.Length ) {
            return !ChildArguments.Where(( T, I ) => (T.Assembly != ParentArguments[I].Assembly || T.Name != ParentArguments[I].Name || T.Namespace != ParentArguments[I].Namespace) && !T.IsSubclassOf(ParentArguments[I])).Any();
        }

        return true;
    }
}