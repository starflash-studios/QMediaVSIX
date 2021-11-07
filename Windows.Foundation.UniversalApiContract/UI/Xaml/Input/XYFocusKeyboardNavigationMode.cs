// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies the 2D directional navigation behavior when using the keyboard arrow keys.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum XYFocusKeyboardNavigationMode
  {
    /// <summary>Behavior is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback behavior is **Disabled**.</summary>
    Auto,
    /// <summary>Arrow keys can be used for 2D directional navigation.</summary>
    Enabled,
    /// <summary>Arrow keys cannot be used for 2D directional navigation.</summary>
    Disabled,
  }
}
