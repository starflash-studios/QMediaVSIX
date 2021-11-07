// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FindNextElementOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides options to help identify the next element that can programmatically receive navigation focus.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class FindNextElementOptions : IFindNextElementOptions
  {
    /// <summary>Initializes a new instance of the FindNextElementOptions class.</summary>
    [MethodImpl]
    public extern FindNextElementOptions();

    /// <summary>Gets or sets the object that must be the root from which to identify the next focus candidate to receive navigation focus.</summary>
    /// <returns>The root object. </returns>
    public extern DependencyObject SearchRoot { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a bounding rectangle where all overlapping navigation candidates are excluded from navigation focus.</summary>
    /// <returns>The bounding rectangle.</returns>
    public extern Rect ExclusionRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a bounding rectangle used to identify the focus candidates most likely to receive navigation focus.</summary>
    /// <returns>The bounding rectangle.</returns>
    public extern Rect HintRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the focus navigation strategy used to identify the best candidate element to receive focus.</summary>
    /// <returns>The focus navigation strategy.</returns>
    public extern XYFocusNavigationStrategyOverride XYFocusNavigationStrategyOverride { [MethodImpl] get; [MethodImpl] set; }
  }
}
