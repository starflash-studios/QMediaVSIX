// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapDecoderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BitmapDecoder))]
  [Guid(1354393834, 39329, 16580, 128, 217, 174, 240, 218, 250, 108, 63)]
  internal interface IBitmapDecoderStatics2
  {
    Guid HeifDecoderId { get; }

    Guid WebpDecoderId { get; }
  }
}
