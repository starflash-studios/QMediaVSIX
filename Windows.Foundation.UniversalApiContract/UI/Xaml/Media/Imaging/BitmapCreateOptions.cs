// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.BitmapCreateOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Specifies initialization options for a bitmap image.</summary>
  [WebHostHidden]
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapCreateOptions : uint
  {
    /// <summary>No options are specified.</summary>
    None = 0,
    /// <summary>Loads images without using an existing image cache. This option should be selected only when images in a cache need to be refreshed.</summary>
    IgnoreImageCache = 8,
  }
}
