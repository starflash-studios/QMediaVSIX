// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyboardAccelerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2464552990, 6574, 18010, 155, 60, 167, 30, 233, 234, 116, 32)]
  [WebHostHidden]
  [ExclusiveTo(typeof (KeyboardAccelerator))]
  internal interface IKeyboardAccelerator
  {
    VirtualKey Key { get; set; }

    VirtualKeyModifiers Modifiers { get; set; }

    bool IsEnabled { get; set; }

    DependencyObject ScopeOwner { get; set; }

    event TypedEventHandler<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs> Invoked;
  }
}
