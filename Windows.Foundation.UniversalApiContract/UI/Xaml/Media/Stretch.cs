// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Stretch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes how content is resized to fill its allocated space.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Stretch
  {
    /// <summary>The content preserves its original size.</summary>
    None,
    /// <summary>The content is resized to fill the destination dimensions. The aspect ratio is not preserved.</summary>
    Fill,
    /// <summary>The content is resized to fit in the destination dimensions while it preserves its native aspect ratio.</summary>
    Uniform,
    /// <summary>The content is resized to fill the destination dimensions while it preserves its native aspect ratio. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit in the destination dimensions.</summary>
    UniformToFill,
  }
}
