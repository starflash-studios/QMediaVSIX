﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapPolygon2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2529730846, 25451, 16408, 156, 46, 172, 201, 18, 42, 1, 178)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapPolygon))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMapPolygon2
  {
    IVector<Geopath> Paths { get; }
  }
}