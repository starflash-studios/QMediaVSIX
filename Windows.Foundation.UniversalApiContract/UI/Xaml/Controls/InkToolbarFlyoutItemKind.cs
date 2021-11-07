// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarFlyoutItemKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies the types of buttons that can be used on an InkToolbar flyout.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkToolbarFlyoutItemKind
  {
    /// <summary>A basic button.</summary>
    Simple,
    /// <summary>A basic radio button.</summary>
    Radio,
    /// <summary>A check box.</summary>
    Check,
    /// <summary>A radio button that can be toggled on or off.</summary>
    RadioCheck,
  }
}
