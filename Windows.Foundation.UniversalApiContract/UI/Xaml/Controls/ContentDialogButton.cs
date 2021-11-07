// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialogButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the default button on a content dialog.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum ContentDialogButton
  {
    /// <summary>No button is specified as the default.</summary>
    None,
    /// <summary>The primary button is the default.</summary>
    Primary,
    /// <summary>The secondary button is the default.</summary>
    Secondary,
    /// <summary>The close button is the default.</summary>
    Close,
  }
}
