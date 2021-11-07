// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies the animation to run when content appears on a Page.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEntranceNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class EntranceNavigationTransitionInfo : 
    NavigationTransitionInfo,
    IEntranceNavigationTransitionInfo
  {
    /// <summary>Initializes a new instance of the EntranceNavigationTransitionInfo class.</summary>
    [MethodImpl]
    public extern EntranceNavigationTransitionInfo();

    /// <summary>Identifies the EntranceNavigationTransitionInfo.IsTargetElement XAML attached property.</summary>
    /// <returns>The identifier for the EntranceNavigationTransitionInfo.IsTargetElement XAML attached property.</returns>
    public static extern DependencyProperty IsTargetElementProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the EntranceNavigationTransitionInfo.IsTargetElement XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The EntranceNavigationTransitionInfo.IsTargetElement attached property value of the specified object. **true** if the element is the animation target; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsTargetElement(UIElement element);

    /// <summary>Sets the value of the EntranceNavigationTransitionInfo.IsTargetElement XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. **true** if the element is the animation target; otherwise, **false**.</param>
    [MethodImpl]
    public static extern void SetIsTargetElement(UIElement element, bool value);
  }
}
