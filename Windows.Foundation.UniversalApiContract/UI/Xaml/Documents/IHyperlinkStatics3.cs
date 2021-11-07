// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlinkStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Hyperlink))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1041620640, 8286, 18759, 153, 165, 116, 231, 87, 232, 225, 180)]
  internal interface IHyperlinkStatics3
  {
    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }

    DependencyProperty ElementSoundModeProperty { get; }
  }
}
