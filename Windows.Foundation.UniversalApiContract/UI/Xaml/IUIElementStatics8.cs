// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [Guid(398341255, 18549, 18709, 176, 177, 164, 192, 248, 81, 223, 63)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUIElementStatics8
  {
    RoutedEvent BringIntoViewRequestedEvent { get; }

    RoutedEvent ContextRequestedEvent { get; }

    DependencyProperty KeyTipTargetProperty { get; }

    DependencyProperty KeyboardAcceleratorPlacementTargetProperty { get; }

    DependencyProperty KeyboardAcceleratorPlacementModeProperty { get; }

    void RegisterAsScrollPort(UIElement element);
  }
}
