#region Copyright (C) 2017-2020  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.Foundation;
using Microsoft.VisualStudio.Shell;

using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX {

    [AsyncMethodBuilder(typeof(ATaskMB))]
    public class AsyncTask : Task {
        public AsyncTask( Action Ak = null ) : base(Ak ?? (() => { })) { }

        public async Task InvokeAsync() => await ConfigureAwait(false);

        public void Invoke(bool Block = false) {
            if (Block) {
                ThreadHelper.JoinableTaskFactory.Run(async () => await InvokeAsync());
            } else {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () => await InvokeAsync());
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Operator Name")]
        public static implicit operator AsyncTask(Func<Task> Lambda) => (AsyncTask)Lambda.Invoke();
        public static implicit operator Func<Task>(AsyncTask ATask) => async () => await ATask.InvokeAsync().ConfigureAwait(false);
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Operator Name")]
        public static implicit operator AsyncTask( Delegate Del ) => new AsyncTask(() => Del.DynamicInvoke());
    }

    public static class AsyncTask_Extensions {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "VSTHRD003:Avoid awaiting foreign Tasks", Justification = "<Pending>")]
        public static void Invoke(this Task T, bool Block = false) {
            if (Block) {
                ThreadHelper.JoinableTaskFactory.Run(async () => await T.ConfigureAwait(false));
            } else {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () => await T.ConfigureAwait(false));
            }
        }
        //public static void Invoke(this Action Ak, bool Block = false) => new AsyncTask(Ak).Invoke(Block);
        //public static async Task InvokeAsync(this Action Ak) => await new AsyncTask(Ak).InvokeAsync();


        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "<Pending>")]
        //public static AsyncTask<T> GetAsyncTask<T>( this IAsyncOperation<T> Op ) => AsyncTask<T>.GetAsyncTask(Op);
    }

    public class ATaskMB<T> {
        AsyncTaskMethodBuilder<T> _MB;

        public ATaskMB() => _MB = AsyncTaskMethodBuilder<T>.Create();

        public static ATaskMB<T> Create() => new ATaskMB<T>();

        public void Start<TStateMachine>( ref TStateMachine StateMachine ) where TStateMachine : IAsyncStateMachine => _MB.Start(ref StateMachine);

        public void SetStateMachine( IAsyncStateMachine StateMachine ) => _MB.SetStateMachine(StateMachine);
        public void SetException( Exception Exception ) => _MB.SetException(Exception);
        public void SetResult( T Result ) => _MB.SetResult(Result);

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter Awaiter, ref TStateMachine StateMachine )
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine => _MB.AwaitOnCompleted(ref Awaiter, ref StateMachine);

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter Awaiter, ref TStateMachine StateMachine )
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine => _MB.AwaitUnsafeOnCompleted(ref Awaiter, ref StateMachine);

        public AsyncTask<T> Task => _MB.Task as AsyncTask<T>;
    }

    public class ATaskMB {
        AsyncTaskMethodBuilder _MB;

        public ATaskMB() => _MB = AsyncTaskMethodBuilder.Create();

        public static ATaskMB Create() => new ATaskMB();

        public void Start<TStateMachine>( ref TStateMachine StateMachine ) where TStateMachine : IAsyncStateMachine => _MB.Start(ref StateMachine);

        public void SetStateMachine( IAsyncStateMachine StateMachine ) => _MB.SetStateMachine(StateMachine);
        public void SetException( Exception Exception ) => _MB.SetException(Exception);
        public void SetResult() => _MB.SetResult();

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter Awaiter, ref TStateMachine StateMachine )
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine => _MB.AwaitOnCompleted(ref Awaiter, ref StateMachine);

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
            ref TAwaiter Awaiter, ref TStateMachine StateMachine )
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine => _MB.AwaitUnsafeOnCompleted(ref Awaiter, ref StateMachine);

        public AsyncTask Task => _MB.Task as AsyncTask;
    }

    [AsyncMethodBuilder(typeof(ATaskMB<>))]
    public class AsyncTask<T> : Task<T> {

        public AsyncTask( Func<T> Ak = null ) : base(Ak ?? (() => throw new NotSupportedException())) { }

        public async Task<T> InvokeAsync() => await ConfigureAwait(false);

        public void Invoke(bool Block = false) {
            if (Block) {
                ThreadHelper.JoinableTaskFactory.Run(async () => await InvokeAsync());
            } else {
                ThreadHelper.JoinableTaskFactory.RunAsync(async () => await InvokeAsync());
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Operator Name")]
        public static implicit operator AsyncTask<T>(Func<Task> Lambda) => (AsyncTask<T>)Lambda.Invoke();
        public static implicit operator Func<Task>(AsyncTask<T> ATask) => async () => await ATask.InvokeAsync().ConfigureAwait(false);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "<Pending>")]
        public static AsyncTask<T> GetAsyncTask( IAsyncOperation<T> Op ) => (AsyncTask<T>)Op.AsTask();
    }
}
