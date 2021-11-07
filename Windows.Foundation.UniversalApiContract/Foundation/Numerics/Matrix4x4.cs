// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Numerics.Matrix4x4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Numerics
{
  /// <summary>Describes a 4*4 floating point matrix.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Matrix4x4
  {
    /// <summary>The row one and column one element of the matrix.</summary>
    public float M11;
    /// <summary>The row one and column two element of the matrix.</summary>
    public float M12;
    /// <summary>The row one and column three element of the matrix.</summary>
    public float M13;
    /// <summary>The row one and column four element of the matrix.</summary>
    public float M14;
    /// <summary>The row two and column one element of the matrix.</summary>
    public float M21;
    /// <summary>The row two and column two element of the matrix.</summary>
    public float M22;
    /// <summary>The row two and column three element of the matrix.</summary>
    public float M23;
    /// <summary>The row two and column four element of the matrix.</summary>
    public float M24;
    /// <summary>The row three and column one element of the matrix.</summary>
    public float M31;
    /// <summary>The row three and column two element of the matrix.</summary>
    public float M32;
    /// <summary>The row three and column three element of the matrix.</summary>
    public float M33;
    /// <summary>The row three and column four element of the matrix.</summary>
    public float M34;
    /// <summary>The row four and column one element of the matrix.</summary>
    public float M41;
    /// <summary>The row four and column two element of the matrix.</summary>
    public float M42;
    /// <summary>The row four and column three element of the matrix.</summary>
    public float M43;
    /// <summary>The row four and column four element of the matrix.</summary>
    public float M44;
  }
}
