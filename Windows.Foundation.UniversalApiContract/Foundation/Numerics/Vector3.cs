// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Numerics.Vector3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Numerics
{
  /// <summary>Describes a vector of three floating-point components.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Vector3
  {
    /// <summary>The x component of the vector.</summary>
    public float X;
    /// <summary>The y component of the vector.</summary>
    public float Y;
    /// <summary>The z component of the vector.</summary>
    public float Z;
  }
}
