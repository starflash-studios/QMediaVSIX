﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IDisplayRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [Guid(3679503266, 16532, 24391, 140, 177, 234, 1, 221, 175, 170, 148)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (DisplayRegion))]
  internal interface IDisplayRegion
  {
    string DisplayMonitorDeviceId { get; }

    bool IsVisible { get; }

    Point WorkAreaOffset { get; }

    Size WorkAreaSize { get; }

    WindowingEnvironment WindowingEnvironment { get; }

    event TypedEventHandler<DisplayRegion, object> Changed;
  }
}