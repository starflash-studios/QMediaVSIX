﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingDoubleKeyFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (EasingDoubleKeyFrame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3369326661, 56238, 20059, 139, 132, 217, 83, 115, 152, 229, 177)]
  internal interface IEasingDoubleKeyFrameStatics
  {
    DependencyProperty EasingFunctionProperty { get; }
  }
}