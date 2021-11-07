// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.AccessibilitySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Provides access to the high contrast accessibility settings.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AccessibilitySettings : IAccessibilitySettings
  {
    /// <summary>Initializes a new AccessibilitySettings object.</summary>
    [MethodImpl]
    public extern AccessibilitySettings();

    /// <summary>Gets a value that indicates whether the system high contrast feature is on or off.</summary>
    /// <returns>True if the high contrast feature is on; otherwise false.</returns>
    public extern bool HighContrast { [MethodImpl] get; }

    /// <summary>Gets the name of the default high contrast color scheme.</summary>
    /// <returns>The name of the default high contrast color scheme.</returns>
    public extern string HighContrastScheme { [MethodImpl] get; }

    /// <summary>Occurs when the system high contrast feature turns on or off.</summary>
    public extern event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged;
  }
}
