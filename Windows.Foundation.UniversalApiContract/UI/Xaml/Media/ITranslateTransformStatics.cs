﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITranslateTransformStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [Guid(4095322769, 57410, 16657, 156, 47, 210, 1, 48, 65, 35, 221)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TranslateTransform))]
  internal interface ITranslateTransformStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty XProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty YProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}