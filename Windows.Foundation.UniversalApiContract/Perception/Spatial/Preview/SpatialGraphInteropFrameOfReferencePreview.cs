// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Preview.SpatialGraphInteropFrameOfReferencePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Preview
{
  /// <summary>Represents a spatial node created for interop based on a spatial coordinate system from the app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialGraphInteropFrameOfReferencePreview : 
    ISpatialGraphInteropFrameOfReferencePreview
  {
    /// <summary>Gets the coordinate system on which this interop frame of reference is based.</summary>
    /// <returns>The coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    /// <summary>Gets the spatial node ID created for this interop frame of reference.</summary>
    /// <returns>The spatial node's ID.</returns>
    public extern Guid NodeId { [MethodImpl] get; }

    /// <summary>Gets the transform from the basis coordinate system to the static node.</summary>
    /// <returns>The transform.</returns>
    public extern Matrix4x4 CoordinateSystemToNodeTransform { [MethodImpl] get; }
  }
}
