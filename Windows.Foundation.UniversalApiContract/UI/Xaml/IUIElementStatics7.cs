// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(3667608723, 42645, 16709, 174, 147, 136, 128, 36, 57, 106, 15)]
  internal interface IUIElementStatics7
  {
    RoutedEvent PreviewKeyDownEvent { get; }

    RoutedEvent CharacterReceivedEvent { get; }

    RoutedEvent PreviewKeyUpEvent { get; }
  }
}
