﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseStreamSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1727364407, 63975, 16778, 156, 222, 160, 32, 233, 86, 85, 43)]
  [ExclusiveTo(typeof (MseStreamSource))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IMseStreamSource2
  {
    IReference<MseTimeRange> LiveSeekableRange { get; set; }
  }
}