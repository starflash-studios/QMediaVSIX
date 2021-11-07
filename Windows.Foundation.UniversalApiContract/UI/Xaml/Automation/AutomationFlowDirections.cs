// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationFlowDirections
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines the direction of flow.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationFlowDirections
  {
    /// <summary>Flow is in the default direction.</summary>
    Default,
    /// <summary>Flow is from right to left.</summary>
    RightToLeft,
    /// <summary>Flow is from bottom to top.</summary>
    BottomToTop,
    /// <summary>Flow is vertical.</summary>
    Vertical,
  }
}
