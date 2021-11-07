﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualStateManager))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1262192192, 45239, 16460, 158, 244, 217, 73, 100, 14, 36, 93)]
  internal interface IVisualStateManagerProtected
  {
    void RaiseCurrentStateChanging(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);

    void RaiseCurrentStateChanged(
      VisualStateGroup stateGroup,
      VisualState oldState,
      VisualState newState,
      Control control);
  }
}