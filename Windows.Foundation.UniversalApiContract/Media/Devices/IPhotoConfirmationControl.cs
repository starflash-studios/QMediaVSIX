﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IPhotoConfirmationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [Guid(3371430755, 65374, 17794, 169, 168, 5, 80, 248, 90, 74, 118)]
  [ExclusiveTo(typeof (PhotoConfirmationControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoConfirmationControl
  {
    bool Supported { get; }

    bool Enabled { get; set; }

    MediaPixelFormat PixelFormat { get; set; }
  }
}