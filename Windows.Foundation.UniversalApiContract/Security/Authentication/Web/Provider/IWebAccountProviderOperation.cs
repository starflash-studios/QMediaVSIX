// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines properties for web account provider operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1834820646, 4273, 16794, 164, 78, 249, 197, 22, 21, 116, 230)]
  public interface IWebAccountProviderOperation
  {
    /// <summary>Gets the kind of web account provider operation.</summary>
    /// <returns>The kind of web account provider operation.</returns>
    WebAccountProviderOperationKind Kind { get; }
  }
}
