// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopupStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1524875034, 28212, 16598, 138, 127, 202, 130, 42, 175, 89, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Popup))]
  internal interface IPopupStatics
  {
    DependencyProperty ChildProperty { get; }

    DependencyProperty IsOpenProperty { get; }

    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }

    DependencyProperty ChildTransitionsProperty { get; }

    DependencyProperty IsLightDismissEnabledProperty { get; }
  }
}
