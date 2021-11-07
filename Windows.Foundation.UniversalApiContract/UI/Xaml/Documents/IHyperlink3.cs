// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Hyperlink))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3287373785, 58835, 20407, 135, 2, 79, 109, 133, 221, 158, 10)]
  internal interface IHyperlink3
  {
    DependencyObject XYFocusLeft { get; set; }

    DependencyObject XYFocusRight { get; set; }

    DependencyObject XYFocusUp { get; set; }

    DependencyObject XYFocusDown { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }
  }
}
