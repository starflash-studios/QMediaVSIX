// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayWireFormatStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DisplayWireFormat))]
  [Guid(3312820781, 50150, 24442, 189, 251, 135, 198, 171, 134, 97, 213)]
  internal interface IDisplayWireFormatStatics
  {
    DisplayWireFormat CreateWithProperties(
      IIterable<IKeyValuePair<Guid, object>> extraProperties,
      DisplayWireFormatPixelEncoding pixelEncoding,
      int bitsPerChannel,
      DisplayWireFormatColorSpace colorSpace,
      DisplayWireFormatEotf eotf,
      DisplayWireFormatHdrMetadata hdrMetadata);
  }
}
