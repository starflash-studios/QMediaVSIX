// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UIColorType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines constants that specify known system color values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UIColorType
  {
    /// <summary>The background color.</summary>
    Background,
    /// <summary>The foreground color.</summary>
    Foreground,
    /// <summary>The darkest accent color.</summary>
    AccentDark3,
    /// <summary>The darker accent color.</summary>
    AccentDark2,
    /// <summary>The dark accent color.</summary>
    AccentDark1,
    /// <summary>The accent color.</summary>
    Accent,
    /// <summary>The light accent color.</summary>
    AccentLight1,
    /// <summary>The lighter accent color.</summary>
    AccentLight2,
    /// <summary>The lightest accent color.</summary>
    AccentLight3,
    /// <summary>Not supported. Do not use.</summary>
    Complement,
  }
}
