// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.CredentialPromptType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Provides the ability to control when to show or hide the credential prompt user interface. This includes the user interface for the app to collect user consent to access data stored in Live. The user must see the user interface in order for the app to obtain any user data, if not app will see an error when they try to obtain user data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CredentialPromptType
  {
    /// <summary>Show the UI only if an error occurred.</summary>
    PromptIfNeeded,
    /// <summary>Always show the UI. If a default username exists, the username is automatically inserted into the appropriate field.</summary>
    RetypeCredentials,
    /// <summary>Never show the UI, even if an error occurs.</summary>
    DoNotPrompt,
  }
}
