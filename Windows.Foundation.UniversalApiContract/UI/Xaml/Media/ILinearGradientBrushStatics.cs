﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILinearGradientBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LinearGradientBrush))]
  [Guid(2063000836, 11715, 16611, 190, 11, 179, 20, 193, 60, 185, 145)]
  internal interface ILinearGradientBrushStatics
  {
    DependencyProperty StartPointProperty { get; }

    DependencyProperty EndPointProperty { get; }
  }
}