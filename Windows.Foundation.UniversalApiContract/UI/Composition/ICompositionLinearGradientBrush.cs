﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLinearGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(2554053913, 43483, 16700, 162, 216, 42, 144, 86, 252, 82, 94)]
  [ExclusiveTo(typeof (CompositionLinearGradientBrush))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface ICompositionLinearGradientBrush
  {
    Vector2 EndPoint { get; set; }

    Vector2 StartPoint { get; set; }
  }
}