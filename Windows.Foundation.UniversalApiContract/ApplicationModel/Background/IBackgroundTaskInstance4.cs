// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskInstance4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides access to a background task instance including information about the user.</summary>
  [Guid(2133455420, 43524, 19208, 151, 176, 6, 216, 116, 205, 171, 245)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IBackgroundTaskInstance4 : IBackgroundTaskInstance
  {
    /// <summary>Gets the user context for the background task. AppServiceConnection.User is used by the calling app to pass the user context. The app service can retrieve that user context with this property.</summary>
    /// <returns>The user context.</returns>
    User User { get; }
  }
}
