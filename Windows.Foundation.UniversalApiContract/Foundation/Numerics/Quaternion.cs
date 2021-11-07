// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Numerics.Quaternion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Numerics
{
  /// <summary>Describes a quaternion, which is an abstract representation of an orientation in space that is based on complex numbers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Quaternion
  {
    /// <summary>The *x* component of the quaternion, which is the coefficient of the **i** unit vector in the quaternion.</summary>
    public float X;
    /// <summary>The *y* component of the quaternion, which is the coefficient of the **j** unit vector in the quaternion.</summary>
    public float Y;
    /// <summary>The *z* component of the quaternion, which is the coefficient of the **k** unit vector in the quaternion.</summary>
    public float Z;
    /// <summary>The *w* component of the quaternion, which is the real number part of the quaternion.</summary>
    public float W;
  }
}
