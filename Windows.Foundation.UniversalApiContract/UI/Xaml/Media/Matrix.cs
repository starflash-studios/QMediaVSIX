// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Matrix
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a 3 × 3 affine transformation matrix used for transformations in two-dimensional space.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct Matrix
  {
    /// <summary>The value of the first row and first column of this Matrix structure.</summary>
    public double M11;
    /// <summary>The value of the first row and second column of this Matrix structure.</summary>
    public double M12;
    /// <summary>The value of the second row and first column of this Matrix structure.</summary>
    public double M21;
    /// <summary>The value of the second row and second column of this Matrix structure.</summary>
    public double M22;
    /// <summary>Gets or sets the value of the third row and first column of this Matrix structure.</summary>
    public double OffsetX;
    /// <summary>Gets or sets the value of the third row and second column of this Matrix structure.</summary>
    public double OffsetY;
  }
}
