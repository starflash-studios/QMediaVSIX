﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualState2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(262207638, 25792, 17915, 141, 36, 251, 131, 41, 140, 13, 147)]
  [ExclusiveTo(typeof (VisualState))]
  internal interface IVisualState2
  {
    SetterBaseCollection Setters { get; }

    IVector<StateTriggerBase> StateTriggers { get; }
  }
}