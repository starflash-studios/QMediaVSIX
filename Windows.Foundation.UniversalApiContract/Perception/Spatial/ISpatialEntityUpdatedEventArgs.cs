﻿// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3848738662, 25211, 17355, 164, 159, 179, 190, 109, 71, 222, 237)]
  [ExclusiveTo(typeof (SpatialEntityUpdatedEventArgs))]
  internal interface ISpatialEntityUpdatedEventArgs
  {
    SpatialEntity Entity { get; }
  }
}