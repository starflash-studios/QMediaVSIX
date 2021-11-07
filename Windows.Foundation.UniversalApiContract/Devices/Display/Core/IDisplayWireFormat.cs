// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayWireFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayWireFormat))]
  [Guid(449615485, 34604, 23096, 187, 185, 29, 72, 114, 183, 98, 85)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayWireFormat
  {
    DisplayWireFormatPixelEncoding PixelEncoding { get; }

    int BitsPerChannel { get; }

    DisplayWireFormatColorSpace ColorSpace { get; }

    DisplayWireFormatEotf Eotf { get; }

    DisplayWireFormatHdrMetadata HdrMetadata { get; }

    IMapView<Guid, object> Properties { get; }
  }
}
