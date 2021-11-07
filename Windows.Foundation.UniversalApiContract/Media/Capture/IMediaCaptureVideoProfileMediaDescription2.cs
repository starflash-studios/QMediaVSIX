// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfileMediaDescription2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfileMediaDescription))]
  [Guid(3332828947, 12845, 16698, 184, 90, 104, 168, 142, 2, 244, 233)]
  internal interface IMediaCaptureVideoProfileMediaDescription2
  {
    string Subtype { get; }

    IMapView<Guid, object> Properties { get; }
  }
}
