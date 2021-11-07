// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IPointerRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3663892234, 38738, 18914, 189, 226, 73, 236, 202, 185, 25, 77)]
  [ExclusiveTo(typeof (PointerRoutedEventArgs))]
  internal interface IPointerRoutedEventArgs
  {
    Pointer Pointer { get; }

    VirtualKeyModifiers KeyModifiers { get; }

    bool Handled { get; set; }

    PointerPoint GetCurrentPoint(UIElement relativeTo);

    IVector<PointerPoint> GetIntermediatePoints(UIElement relativeTo);
  }
}
