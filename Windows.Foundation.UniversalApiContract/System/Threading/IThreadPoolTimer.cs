﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ThreadPoolTimer))]
  [Guid(1498332792, 21994, 19080, 165, 13, 52, 2, 174, 31, 156, 242)]
  internal interface IThreadPoolTimer
  {
    TimeSpan Period { get; }

    TimeSpan Delay { get; }

    void Cancel();
  }
}