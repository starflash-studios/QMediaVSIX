// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyRoutedEventArgs))]
  [WebHostHidden]
  [Guid(3570220542, 16505, 17129, 163, 154, 48, 149, 211, 240, 73, 198)]
  internal interface IKeyRoutedEventArgs
  {
    VirtualKey Key { get; }

    CorePhysicalKeyStatus KeyStatus { get; }

    bool Handled { get; set; }
  }
}
