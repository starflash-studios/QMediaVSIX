// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.FindAllAccountsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>This class represents the result of an account retrieval operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FindAllAccountsResult : IFindAllAccountsResult
  {
    /// <summary>Gets the list of retrieved web accounts (if the operation was successful).</summary>
    /// <returns>An **IVectorView ** of **WebAccount ** objects.</returns>
    public extern IVectorView<WebAccount> Accounts { [MethodImpl] get; }

    /// <summary>Gets the status of the web account retrieval operation.</summary>
    /// <returns>A value indicating the result status.</returns>
    public extern FindAllWebAccountsStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error, if one occurred, during the web account retrieval operation.</summary>
    /// <returns>The provider error.</returns>
    public extern WebProviderError ProviderError { [MethodImpl] get; }
  }
}
