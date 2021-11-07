// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(868991577, 65073, 16817, 184, 18, 8, 109, 33, 232, 126, 22)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  internal interface IBitmapEncoderStatics2
  {
    Guid HeifEncoderId { get; }
  }
}
