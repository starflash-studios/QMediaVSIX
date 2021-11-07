// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ErrorDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Provides information about an error that occurred.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IErrorDetailsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ErrorDetails : IErrorDetails
  {
    /// <summary>Gets a short description of the error.</summary>
    /// <returns>A short description of the error.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets a detailed description of the error.</summary>
    /// <returns>A detailed description of the error.</returns>
    public extern string LongDescription { [MethodImpl] get; }

    /// <summary>Gets the address to a help page about the error.</summary>
    /// <returns>The address to a help page about the error.</returns>
    public extern Uri HelpUri { [MethodImpl] get; }

    /// <summary>Asynchronously creates an ErrorDetails object based on an **HRESULT** error code.</summary>
    /// <param name="errorCode">The unique code representing the error.</param>
    /// <returns>The newly created ErrorDetails object representing the error.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ErrorDetails> CreateFromHResultAsync(
      int errorCode);
  }
}
