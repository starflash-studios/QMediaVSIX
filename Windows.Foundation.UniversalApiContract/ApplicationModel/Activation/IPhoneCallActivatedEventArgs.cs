﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IPhoneCallActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1415664161, 41921, 19693, 182, 47, 140, 96, 82, 54, 25, 173)]
  public interface IPhoneCallActivatedEventArgs : IActivatedEventArgs
  {
    Guid LineId { get; }
  }
}