﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshVisualizerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2951370415, 13866, 16405, 177, 85, 115, 58, 31, 134, 152, 49)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (RefreshVisualizer))]
  [WebHostHidden]
  internal interface IRefreshVisualizerStatics
  {
    DependencyProperty InfoProviderProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty ContentProperty { get; }

    DependencyProperty StateProperty { get; }
  }
}