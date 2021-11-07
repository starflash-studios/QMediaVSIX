// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapCodecInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(1074572018, 50352, 17298, 163, 176, 111, 111, 155, 169, 92, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapCodecInformation))]
  internal interface IBitmapCodecInformation
  {
    Guid CodecId { get; }

    IVectorView<string> FileExtensions { get; }

    string FriendlyName { get; }

    IVectorView<string> MimeTypes { get; }
  }
}
