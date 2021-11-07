// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.AppViewBackButtonVisibility
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines constants that specify whether the back button is shown in the system UI.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppViewBackButtonVisibility
  {
    /// <summary>The back button is shown.</summary>
    Visible,
    /// <summary>The back button is not shown and space is not reserved for it in the layout.</summary>
    Collapsed,
    /// <summary>The back button is shown, but not enabled.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Disabled,
  }
}
