// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.UnhandledError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Represents the error data for a system error as reported by an UnhandledErrorDetected event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class UnhandledError : IUnhandledError
  {
    /// <summary>Gets a value that indicates whether the error has been handled.</summary>
    /// <returns>**true** if the error has been handled. A value of **true** permits the app to continue. **false** if the error has not been handled. A value of **false** can result in the app being terminated once this event propagates to the Windows Runtime system.</returns>
    public extern bool Handled { [MethodImpl] get; }

    /// <summary>Wraps the underlying error info in a language specific exception, and throws the error.</summary>
    [MethodImpl]
    public extern void Propagate();
  }
}
