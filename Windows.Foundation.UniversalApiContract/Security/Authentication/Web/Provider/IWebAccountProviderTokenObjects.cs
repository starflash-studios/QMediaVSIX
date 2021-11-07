// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenObjects
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines properties for web account provider token objects.</summary>
  [Guid(1083123787, 4904, 17115, 137, 164, 11, 206, 122, 113, 125, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderTokenObjects
  {
    /// <summary>Gets the web account provider operation.</summary>
    /// <returns>The web account provider operation.</returns>
    IWebAccountProviderOperation Operation { get; }
  }
}
