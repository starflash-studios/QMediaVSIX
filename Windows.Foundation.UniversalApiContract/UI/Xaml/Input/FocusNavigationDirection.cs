// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusNavigationDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies the direction that you can programmatically move focus from one element to another element within the app UI.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FocusNavigationDirection
  {
    /// <summary>The next element in the tab order.</summary>
    Next,
    /// <summary>The previous element in the tab order.</summary>
    Previous,
    /// <summary>An element above the element with focus. </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Up,
    /// <summary>An element below the element with focus. </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Down,
    /// <summary>An element to the left of the element with focus. </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Left,
    /// <summary>An element to the right of the element with focus. </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Right,
    /// <summary>No change in focus.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] None,
  }
}
