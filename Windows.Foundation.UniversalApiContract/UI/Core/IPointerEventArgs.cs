﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IPointerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (PointerEventArgs))]
  [Guid(2450365617, 42492, 18977, 140, 9, 73, 223, 230, 255, 226, 95)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerEventArgs : ICoreWindowEventArgs
  {
    PointerPoint CurrentPoint { get; }

    VirtualKeyModifiers KeyModifiers { get; }

    IVector<PointerPoint> GetIntermediatePoints();
  }
}