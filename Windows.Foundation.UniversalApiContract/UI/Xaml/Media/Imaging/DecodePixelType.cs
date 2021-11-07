// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.DecodePixelType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides values that can be used for decoding operations to optimize for logical versus physical pixels in the source image file.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DecodePixelType
  {
    /// <summary>Use a physical pixel value.</summary>
    Physical,
    /// <summary>Use a logical pixel value.</summary>
    Logical,
  }
}
