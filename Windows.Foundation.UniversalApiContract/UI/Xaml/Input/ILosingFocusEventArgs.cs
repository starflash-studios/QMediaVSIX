// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ILosingFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(4193682375, 55177, 18219, 170, 147, 109, 65, 5, 230, 218, 190)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (LosingFocusEventArgs))]
  internal interface ILosingFocusEventArgs
  {
    DependencyObject OldFocusedElement { get; }

    DependencyObject NewFocusedElement { get; set; }

    FocusState FocusState { get; }

    FocusNavigationDirection Direction { get; }

    bool Handled { get; set; }

    FocusInputDeviceKind InputDevice { get; }

    bool Cancel { get; set; }
  }
}
