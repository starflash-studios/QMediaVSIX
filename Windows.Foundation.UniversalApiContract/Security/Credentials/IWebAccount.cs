// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Enables a class to represent an account from a web account provider.</summary>
  [Guid(1766276786, 32817, 18878, 128, 187, 150, 203, 70, 217, 154, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccount
  {
    /// <summary>Gets the web authentication provider for the account.</summary>
    /// <returns>The web authentication provider for the account.</returns>
    WebAccountProvider WebAccountProvider { get; }

    /// <summary>Gets the username for the web account.</summary>
    /// <returns>The username for the web account.</returns>
    string UserName { get; }

    /// <summary>Gets the connected state of the web account.</summary>
    /// <returns>The connected state of the web account.</returns>
    WebAccountState State { get; }
  }
}
