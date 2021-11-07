// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapModel3DShadingOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the type of shading that you want to appear for 3D objects.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum MapModel3DShadingOption
  {
    /// <summary>The vertex normals of the imported 3D model or flat shading if that data is not available.</summary>
    Default,
    /// <summary>Flat shading.</summary>
    Flat,
    /// <summary>Smooth shading.</summary>
    Smooth,
  }
}
