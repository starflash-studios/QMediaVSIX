// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the user that the app was activated for.</summary>
  [Guid(485530526, 39266, 18742, 128, 255, 175, 200, 232, 174, 92, 140)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IActivatedEventArgsWithUser : IActivatedEventArgs
  {
    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for. This property returns the logged-in user on platforms that only support single-user sessions. For platforms that support multiple users in a session (such as Xbox) this property returns the logged-in user that the app was activated for.</returns>
    User User { get; }
  }
}
