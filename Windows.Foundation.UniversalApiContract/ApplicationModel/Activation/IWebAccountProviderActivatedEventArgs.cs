// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IWebAccountProviderActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Provider;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Contains methods for providing information to an app activated as a result of a web account provider operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1924601716, 39146, 19663, 151, 82, 70, 217, 5, 16, 4, 241)]
  public interface IWebAccountProviderActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the web account provider operation.</summary>
    /// <returns>The web account provider operation.</returns>
    IWebAccountProviderOperation Operation { get; }
  }
}
