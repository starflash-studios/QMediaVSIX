﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IWindowActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(396191207, 18008, 19638, 170, 19, 65, 208, 148, 234, 37, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WindowActivatedEventArgs))]
  internal interface IWindowActivatedEventArgs : ICoreWindowEventArgs
  {
    CoreWindowActivationState WindowActivationState { get; }
  }
}