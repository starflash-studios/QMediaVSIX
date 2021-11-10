#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using EnvDTE80;

namespace QDebug.Listeners;

#nullable enable

public class DiagnosticsListener : IDebugListener {
	/// <inheritdoc />
	public void WriteLine( string? Message = null ) => SysDbg.WriteLine(Message);

	/// <inheritdoc />
	public void WriteLine( string? Message, string Category ) => SysDbg.WriteLine(Message, Category);

	/// <inheritdoc />
	public void WriteLine( string Format, params object?[] Args ) => SysCon.WriteLine(Format, Args);

	/// <inheritdoc />
	public void Write( string? Message = null ) => SysDbg.Write(Message);

	/// <inheritdoc />
	public void Write( string? Message, string Category ) => SysDbg.Write(Message, Category);

	DTE2? _Dt;

	public DTE2? Dt {
		get {
			if (_Dt is null ) {
				//Debug.WriteLine("Constructing DT");
				void RetrieveByName() => _Dt = GetDteByName(@"VisualStudio.DTE");
				TryFor(1000, RetrieveByName);
				if ( _Dt is null ) {
					throw new ArgumentNullException(nameof(Dt), "Is Visual Studio running?");
				}
			}
			return _Dt;
		}
	}

	~DiagnosticsListener() {
		if (_Dt is { } DtObj ) {
			Marshal.ReleaseComObject(DtObj);
		}
	}

	/// <inheritdoc />
	public void Clear() {
		if ( ClearEnabled && Dt is { } D ) {
			D.ExecuteCommand("Edit.ClearOutputWindow");
		}
	}

	/// <summary>
	/// Determines whether clearing of Visual Studio's output window is enabled.
	/// </summary>
	public bool ClearEnabled { get; set; } = true;

	/// <summary>
	/// Sets the <see cref="ClearEnabled"/> parameter of all currently listening <see cref="DiagnosticsListener"/> classes to the desired value.
	/// </summary>
	/// <param name="ClearEnabled">Whether clearing of Visual Studio's output window is enabled.</param>
	public static void SetClearEnabledGlobal(bool ClearEnabled) {
		foreach( DiagnosticsListener DL in Debug.Query<DiagnosticsListener>() ) {
			DL.ClearEnabled = ClearEnabled;
		}
	}

	//static void TryFor( int Ms, Func<Action> ActionFunc ) => TryFor(Ms, ActionFunc.Invoke());

	static void TryFor( int Ms, Action Action ) {
		DateTime Timeout = DateTime.Now.AddMilliseconds(Ms);
		bool Success = false;

		do {
			try {
				Action();
				Success = true;
			} catch ( Exception ) {
				if ( DateTime.Now > Timeout ) {
					throw;
				}
			}
		} while ( !Success );
	}

	static DTE2? GetDteByName( string Name ) {
		IntPtr NumFetched = Marshal.AllocHGlobal(sizeof(int));

		IMoniker[] Monikers = new IMoniker[1];

		Marshal.ThrowExceptionForHR(CreateBindCtx(Reserved: 0, Ppbc: out IBindCtx BindCtx));

		BindCtx.GetRunningObjectTable(out IRunningObjectTable? RunningObjectTable);

		if (RunningObjectTable is null ) { return null; }

		RunningObjectTable.EnumRunning(out IEnumMoniker MonikerEnumerator);
		MonikerEnumerator.Reset();

		while ( MonikerEnumerator.Next(1, Monikers, NumFetched) == 0 ) {
			Exception? Ex = Marshal.GetExceptionForHR(CreateBindCtx(0, out IBindCtx Ctx));
			if ( Ex is not null ) { throw Ex; }

			Monikers[0].GetDisplayName(Ctx, null, out string RunningObjectName);

			if ( RunningObjectName.Contains(Name) ) {
				RunningObjectTable.GetObject(Monikers[0], out object RunningObjectVal);

				DTE2 Dte = (DTE2)RunningObjectVal;
				return Dte;
			}
		}
		return null;
	}

	[DllImport("ole32.dll")]
	static extern int CreateBindCtx( uint Reserved, out IBindCtx Ppbc );

	static Exception GetException( int HRESULT ) => SetCode(new Exception(), HRESULT);

	static void ThrowOrContinue( int HRESULT ) {
		if ( HRESULT != 0 ) {
			throw GetException(HRESULT);
		}
	}

	static void ThrowOrContinue( Func<int> ActionWithHRESULT ) => ThrowOrContinue(ActionWithHRESULT());

	static Exception SetCode( Exception Ex, int HRESULT ) {
		const BindingFlags Flags = BindingFlags.Instance | BindingFlags.NonPublic;
		FieldInfo? FieldInfo = typeof(Exception).GetField("_HResult", Flags);

		FieldInfo?.SetValue(Ex, HRESULT);

		return Ex;
	}
}