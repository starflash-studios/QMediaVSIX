// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RequiresPointer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify when an element requires a mouse-like pointer behavior from a game pad.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RequiresPointer
  {
    /// <summary>The pointer never acts as a mouse.</summary>
    Never,
    /// <summary>The pointer acts as a mouse when the user engages mouse-mode.</summary>
    WhenEngaged,
    /// <summary>The pointer acts as a mouse when the page gets focus. Supported on Page elements only.</summary>
    WhenFocused,
  }
}
