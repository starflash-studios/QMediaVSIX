﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IExponentialEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1870469713, 39122, 22072, 163, 74, 0, 72, 101, 84, 199, 80)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (ExponentialEasingFunction))]
  internal interface IExponentialEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }

    float Exponent { get; }
  }
}