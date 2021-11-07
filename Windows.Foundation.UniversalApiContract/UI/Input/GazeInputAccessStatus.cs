// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.GazeInputAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the permission state for tracking the user's gaze.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum GazeInputAccessStatus
  {
    /// <summary>The user has not specified whether the app can track their gaze.</summary>
    Unspecified,
    /// <summary>The user has given permission for the app to to track their gaze.</summary>
    Allowed,
    /// <summary>The user has denied permission for the app to track their gaze.</summary>
    DeniedByUser,
    /// <summary>The system has denied permission for the app to track the user's gaze.</summary>
    DeniedBySystem,
  }
}
