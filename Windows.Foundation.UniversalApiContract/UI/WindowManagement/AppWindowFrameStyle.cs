// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowFrameStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Defines constants that specify the style of frame used for the app window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  public enum AppWindowFrameStyle
  {
    /// <summary>The system default frame style is used for the current window.</summary>
    Default,
    /// <summary>No frame is used for the current window.</summary>
    NoFrame,
  }
}
