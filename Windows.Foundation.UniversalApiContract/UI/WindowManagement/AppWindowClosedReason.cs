// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowClosedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Defines constants that specify how a window close operation was initiated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  public enum AppWindowClosedReason
  {
    /// <summary>The operation was initiated by something other than the user or app code.</summary>
    Other,
    /// <summary>The operation was initiated programmatically by code in the app.</summary>
    AppInitiated,
    /// <summary>The operation was initiated by the user.</summary>
    UserInitiated,
  }
}
