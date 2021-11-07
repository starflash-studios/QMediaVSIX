// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Numerics.Plane
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Numerics
{
  /// <summary>Describes a plane (a flat, two-dimensional surface).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Plane
  {
    /// <summary>A vector of three floating-point components on the plane.</summary>
    public Vector3 Normal;
    /// <summary>A floating-point value for a point on the plane but not on the **Normal** vector.</summary>
    public float D;
  }
}
