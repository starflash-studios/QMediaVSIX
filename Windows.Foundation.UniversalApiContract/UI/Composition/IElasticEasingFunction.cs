﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IElasticEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ElasticEasingFunction))]
  [Guid(1725850245, 1358, 21908, 132, 117, 194, 44, 181, 31, 27, 213)]
  internal interface IElasticEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }

    int Oscillations { get; }

    float Springiness { get; }
  }
}