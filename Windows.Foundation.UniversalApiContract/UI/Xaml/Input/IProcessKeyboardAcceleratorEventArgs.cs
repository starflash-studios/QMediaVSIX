﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IProcessKeyboardAcceleratorEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (ProcessKeyboardAcceleratorEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(4219060758, 38699, 17420, 155, 131, 43, 65, 152, 220, 240, 157)]
  internal interface IProcessKeyboardAcceleratorEventArgs
  {
    VirtualKey Key { get; }

    VirtualKeyModifiers Modifiers { get; }

    bool Handled { get; set; }
  }
}