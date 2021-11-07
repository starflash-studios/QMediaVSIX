// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [Guid(3522722526, 60577, 17761, 163, 43, 100, 96, 27, 78, 5, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElementStatics3
  {
    [IndependentlyAnimatable]
    DependencyProperty Transform3DProperty { [IndependentlyAnimatable] get; }

    DependencyProperty CanDragProperty { get; }

    bool TryStartDirectManipulation(Pointer value);
  }
}
