// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information to an app that was launched after being suspended for a web authentication broker operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1977459668, 30484, 17725, 183, 255, 185, 94, 58, 23, 9, 218)]
  public interface IWebAuthenticationBrokerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the WebAuthenticationResult object returned from the web authentication broker operation.</summary>
    /// <returns>The result of the web authentication broker operation.</returns>
    WebAuthenticationResult WebAuthenticationResult { get; }
  }
}
