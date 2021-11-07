// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.XYFocusNavigationStrategyOverride
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies how the XAML framework determines the target of an XY navigation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum XYFocusNavigationStrategyOverride
  {
    /// <summary>No navigation override is applied.</summary>
    None,
    /// <summary>Indicates that navigation strategy is inherited from the element's ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**.</summary>
    Auto,
    /// <summary>Indicates that focus moves to the first element encountered when projecting the edge of the currently focused element in the  direction of navigation.</summary>
    Projection,
    /// <summary>Indicates that focus moves to the element closest to the axis of the navigation direction.</summary>
    NavigationDirectionDistance,
    /// <summary>Indicates that focus moves to the closest element based on the shortest 2D distance (Manhattan metric). </summary>
    RectilinearDistance,
  }
}
