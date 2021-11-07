// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialAppLaunchResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>The result of attempting to launch an app on a remote device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DialAppLaunchResult
  {
    /// <summary>The app successfully launched.</summary>
    Launched,
    /// <summary>The app failed to launch.</summary>
    FailedToLaunch,
    /// <summary>The app was not found.</summary>
    NotFound,
    /// <summary>An error occurred while attempting to retrieve the state.</summary>
    NetworkFailure,
  }
}
