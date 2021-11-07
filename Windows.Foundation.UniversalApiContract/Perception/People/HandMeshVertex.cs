// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HandMeshVertex
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.People
{
  /// <summary>Represents an individual vertex in a hand mesh vertex buffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public struct HandMeshVertex
  {
    /// <summary>The position of the vertex.</summary>
    public Vector3 Position;
    /// <summary>The normal of the vertex.</summary>
    public Vector3 Normal;
  }
}
