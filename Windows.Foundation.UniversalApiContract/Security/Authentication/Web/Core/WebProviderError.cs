// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebProviderError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Represents an error from a web account provider.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebProviderErrorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebProviderError : IWebProviderError
  {
    /// <summary>Initializes a new instance of the WebProviderError class.</summary>
    /// <param name="errorCode">The error code.</param>
    /// <param name="errorMessage">The error message.</param>
    [MethodImpl]
    public extern WebProviderError(uint errorCode, string errorMessage);

    /// <summary>Gets the error code.</summary>
    /// <returns>The error code.</returns>
    public extern uint ErrorCode { [MethodImpl] get; }

    /// <summary>Gets the error message.</summary>
    /// <returns>The error message.</returns>
    public extern string ErrorMessage { [MethodImpl] get; }

    /// <summary>Gets the error properties.</summary>
    /// <returns>The error properties.</returns>
    public extern IMap<string, string> Properties { [MethodImpl] get; }
  }
}
