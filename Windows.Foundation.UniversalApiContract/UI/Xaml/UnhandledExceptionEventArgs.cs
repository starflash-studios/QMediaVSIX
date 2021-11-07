// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UnhandledExceptionEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for the UnhandledException event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class UnhandledExceptionEventArgs : IUnhandledExceptionEventArgs
  {
    /// <summary>Gets the **HRESULT** code associated with the unhandled exception.</summary>
    /// <returns>The **HRESULT** code (for Visual C++ component extensions (C++/CX)), or a mapped common language runtime (CLR)  System.Exception.</returns>
    public extern HResult Exception { [MethodImpl] get; }

    /// <summary>Gets the message string as passed by the originating unhandled exception.</summary>
    /// <returns>The message string, which may be useful for debugging.</returns>
    public extern string Message { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the exception is handled.</summary>
    /// <returns>**true** to mark the exception as handled, which indicates that the event system should not process it further; otherwise, **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
