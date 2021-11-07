// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementTheme
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies a UI theme that should be used for individual UIElement parts of an app UI.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ElementTheme
  {
    /// <summary>Use the Application.RequestedTheme value for the element. This is the default.</summary>
    Default,
    /// <summary>Use the **Light** default theme.</summary>
    Light,
    /// <summary>Use the **Dark** default theme.</summary>
    Dark,
  }
}
