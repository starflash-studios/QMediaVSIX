﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileDataSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides a source of tiles for a MapTileSource. This class serves as the base class for HttpMapTileDataSource, LocalMapTileDataSource, and CustomMapTileDataSource.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IMapTileDataSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MapTileDataSource : DependencyObject, IMapTileDataSource
  {
    /// <summary>Initializes a new instance of the MapTileDataSource class.</summary>
    [MethodImpl]
    public extern MapTileDataSource();
  }
}