﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.IDispatcherQueueShutdownStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DispatcherQueueShutdownStartingEventArgs))]
  [Guid(3295824972, 65431, 16576, 162, 38, 204, 10, 170, 84, 94, 137)]
  internal interface IDispatcherQueueShutdownStartingEventArgs
  {
    Deferral GetDeferral();
  }
}