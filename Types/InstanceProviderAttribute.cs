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

using Mono.Reflection;

namespace QMediaVSIX.Commands;

[AttributeUsage(AttributeTargets.Class)]
public class InstanceProviderAttribute : Attribute {
    /// <summary>
    /// The name of the instance field.
    /// </summary>
    public string InstanceFieldName { get; }

    /// <summary>
    /// The name of the instance construction method.
    /// </summary>
    public string? ConstructorMethodName { get; }

    public InstanceProviderAttribute( string InstanceFieldName, string ConstructorMethodName ) {
        this.InstanceFieldName = InstanceFieldName;
        this.ConstructorMethodName = ConstructorMethodName;
    }

    public static async Task ConstructAllInstanceTypesAsync( bool AllowAttributeInheritance = true ) {
        // ReSharper disable once LoopCanBePartlyConvertedToQuery
        foreach (Type Tp in Assembly.GetExecutingAssembly().GetTypes() ) {
            if ( Tp.IsAbstract || Tp.IsInterface ) { continue; }
            //Debug.WriteLine($"Checking {Tp.GetTypeName()} for instance providers.");
            if (Tp.GetCustomAttribute<InstanceProviderAttribute>(AllowAttributeInheritance) is { } Attr ) {
                Debug.WriteLine($"\tConstructing instance for {Tp.GetTypeName()} ({Attr.ConstructorMethodName} sets {Attr.InstanceFieldName}).");
                await ConstructInstanceAsync(Tp, Attr);
            }
        }
        //Debug.WriteLine("Construction all complete.");
        //Debug.WriteLine($"TestProvider became as such: {TestProvider.SomeInstance}");
        //Debug.WriteLine($"TestAsyncProvider became as such: {TestAsyncProvider.SomeInstance}");
        //Debug.Break();
        //System.Diagnostics.Debugger.Break();
    }

    public static async Task ConstructInstanceAsync(Type Tp, bool AllowAttributeInheritance = true ) {
        if ( Tp.GetCustomAttribute<InstanceProviderAttribute>(AllowAttributeInheritance) is not { } Attr ) {
            throw new NotSupportedException($"Type must contain a {nameof(InstanceProviderAttribute)}.");
        }
        await ConstructInstanceAsync(Tp, Attr);
    }

    static readonly Type
        //_TaskType = typeof(Task),
        _GenericTaskType = typeof(Task<>);

    public static async Task ConstructInstanceAsync( Type Tp, InstanceProviderAttribute Attr, BindingFlags AllowedFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static ) {
        try {
            switch ( Attr.ConstructorMethodName ) {
                case { } CM:
                    if ( Tp.GetMethod(CM, AllowedFlags) is not { } Method ) {
                        throw new ArgumentNullException(nameof(Method), "No constructor method was found.");
                    }
                    object RetVal = Method.Invoke(null, null);
                    Type RetType = Method.ReturnType;
                    //Debug.WriteLine($"\t\tConstructor return type is {RetType.GetTypeName()}");
                    if ( RetType.IsGenericType && RetType.GetGenericTypeDefinition() == _GenericTaskType ) {
                        //Debug.WriteLine("\t\t--> Asynchronous task detected.");
                        Task Tk = (Task)RetVal;
                        await Tk;

                        Type TaskRetType = RetType.GetGenericArguments().FirstOrDefault() ?? throw new ArgumentNullException(nameof(TaskRetType), $"Generic arguments for {RetType.GetTypeName()} were null.");
                        //Debug.WriteLine($"\t\tTask return type is {TaskRetType}.");
                        RetVal = GetTaskReturn( Tk, TaskRetType, AllowedFlags ) ?? throw new ArgumentNullException("Asynchronous constructor method returned null.");
                    }

                    if ( Tp.GetField(Attr.InstanceFieldName, AllowedFlags) is { } InstField ) {
                        //Debug.WriteLine("Setting static instance field.");
                        InstField.SetValue(null, RetVal);
                    } else if ( Tp.GetProperty(Attr.InstanceFieldName, AllowedFlags) is { } InstProp ) {
                        //Debug.WriteLine("Setting static instance property.");
                        InstProp.GetBackingField().SetValue(null, RetVal);
                    } else {
                        throw new ArgumentNullException(nameof(InstField), "No static instance property/field was found.");
                    }
                    break;
                default:
                    throw new ArgumentNullException(nameof(ConstructorMethodName), "No constructor method name was provided; asynchronous or otherwise.");
            }
        } catch ( Exception Ex ) {
            Debug.WriteLine($"Exception {Ex.GetTypeName()} was thrown.\n{Ex}");
            throw;
        }
    }

    public static object? GetTaskReturn( Task Tk, Type ReturnType, BindingFlags AllowedFlags ) => typeof(Task<>).MakeGenericType(ReturnType).GetProperty("Result", AllowedFlags).GetValue(Tk);
}

//[ProvidesInstance(nameof(SomeInstance), nameof(ConstructInstance))]
//public class TestProvider {
//    public static TestProvider? SomeInstance = null;

//    string SomeStr;

//    TestProvider(string Str = "Egg") {
//        Debug.WriteLine("Default constructor.");
//        SomeStr = Str;
//    }

//    public static TestProvider ConstructInstance() {
//        Debug.WriteLine("Constructor method.");
//        return new TestProvider("eggplant");
//    }

//    public override string ToString() => $"{this.GetTypeName()}.{nameof(SomeStr)}: {SomeStr}";
//}

//[ProvidesInstance(nameof(SomeInstance), nameof(ConstructInstanceAsync))]
//public class TestAsyncProvider {
//    public static TestAsyncProvider? SomeInstance = null;

//    int SomeVal;

//    TestAsyncProvider(int V = 7) {
//        Debug.WriteLine("Default synchronous constructor in asynchronous type.");
//        SomeVal = V;
//    }

//    public static async Task<TestAsyncProvider> ConstructInstanceAsync() {
//        Debug.WriteLine("Asynchronous constructor method.");
//        await Task.Delay(200);
//        return new TestAsyncProvider(15);
//    }

//    public override string ToString() => $"{this.GetTypeName()}.{nameof(SomeVal)}: {SomeVal}";
//}