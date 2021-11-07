// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ITappedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TappedRoutedEventArgs))]
  [Guid(2694440638, 58916, 17818, 187, 29, 224, 92, 115, 226, 204, 102)]
  internal interface ITappedRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
