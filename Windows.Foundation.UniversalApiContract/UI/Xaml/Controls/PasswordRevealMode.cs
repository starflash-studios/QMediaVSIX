// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PasswordRevealMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the password reveal behavior of a PasswordBox.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PasswordRevealMode
  {
    /// <summary>The password reveal button is visible. The password is not obscured while the button is pressed.</summary>
    Peek,
    /// <summary>The password reveal button is not visible. The password is always obscured.</summary>
    Hidden,
    /// <summary>The password reveal button is not visible. The password is not obscured.</summary>
    Visible,
  }
}
