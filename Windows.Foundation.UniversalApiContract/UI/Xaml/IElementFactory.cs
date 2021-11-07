// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Supports the creation and recycling of UIElement objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(399682960, 4976, 21960, 128, 225, 120, 180, 144, 4, 169, 225)]
  public interface IElementFactory
  {
    /// <summary>Gets an UIElement object.</summary>
    /// <param name="args">An instance of ElementFactoryGetArgs.</param>
    /// <returns>A UIElement object.</returns>
    UIElement GetElement(ElementFactoryGetArgs args);

    /// <summary>Recycles a UIElement that was previously retrieved using GetElement.</summary>
    /// <param name="args">An instance of ElementFactoryRecycleArgs.</param>
    void RecycleElement(ElementFactoryRecycleArgs args);
  }
}
