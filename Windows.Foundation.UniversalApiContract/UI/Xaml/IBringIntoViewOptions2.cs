﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBringIntoViewOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3897942158, 25782, 4625, 189, 219, 31, 221, 187, 110, 130, 49)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BringIntoViewOptions))]
  internal interface IBringIntoViewOptions2
  {
    double HorizontalAlignmentRatio { get; set; }

    double VerticalAlignmentRatio { get; set; }

    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }
  }
}