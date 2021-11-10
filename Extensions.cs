using System.Collections.Generic;
using System.Collections.ObjectModel;

using Microsoft.VisualStudio.Shell;
using System.ComponentModel.Design;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Threading;

using QMediaVSIX.Core.Collections;

namespace QMediaVSIX;

public static class Extensions {

    //public static async Task<T?> GetServiceAsync<T>( this AsyncPackage Pkg ) where T : IMenuCommandService => await Pkg.GetServiceAsync(typeof(T)) switch {
    //		T Result => Result,
    //		_                => default
    //	};

    public static async Task<OleMenuCommandService> GetMenuCommandServiceAsync( this AsyncPackage Pkg ) => (await Pkg.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService)!;

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


    public static string GetTypeName<T>( this object? _, bool FullName = false ) => GetName(typeof(T), FullName);

    public static string GetTypeName( this object? Obj, bool FullName = false ) => GetName(Obj?.GetType(), FullName);

    public static string GetTypeName<T>( this T? _, bool FullName = false ) => GetName(typeof(T), FullName);

    public static string GetName<T>( bool FullName = false ) => GetName(typeof(T), FullName);

    public static string GetName( this Type? T, bool FullName = false ) {
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
}