// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  [Guid(2965998753, 46937, 23385, 177, 173, 240, 120, 106, 169, 229, 61)]
  [ExclusiveTo(typeof (DisplayView))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayView
  {
    IVectorView<DisplayPath> Paths { get; }

    IReference<SizeInt32> ContentResolution { get; set; }

    void SetPrimaryPath(DisplayPath path);

    IMap<Guid, object> Properties { get; }
  }
}
