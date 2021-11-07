// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PickerFlyoutBase))]
  [Guid(1514998469, 35246, 16613, 167, 241, 187, 112, 35, 85, 173, 243)]
  internal interface IPickerFlyoutBaseStatics
  {
    DependencyProperty TitleProperty { get; }

    string GetTitle(DependencyObject element);

    void SetTitle(DependencyObject element, string value);
  }
}
