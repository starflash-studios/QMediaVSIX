// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IRightTappedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1748272797, 31701, 16435, 178, 55, 23, 47, 121, 171, 227, 147)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RightTappedRoutedEventArgs))]
  internal interface IRightTappedRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
