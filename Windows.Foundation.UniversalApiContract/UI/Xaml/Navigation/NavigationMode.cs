// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Specifies the navigation stack characteristics of a navigation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum NavigationMode
  {
    /// <summary>Navigation is to a new instance of a page (not going forward or backward in the stack).</summary>
    New,
    /// <summary>Navigation is going backward in the stack.</summary>
    Back,
    /// <summary>Navigation is going forward in the stack.</summary>
    Forward,
    /// <summary>Navigation is to the current page (perhaps with different data).</summary>
    Refresh,
  }
}
