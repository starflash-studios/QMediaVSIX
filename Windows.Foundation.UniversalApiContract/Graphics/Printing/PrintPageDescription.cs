// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintPageDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Represents the data that describes a document page.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct PrintPageDescription
  {
    /// <summary>The page size in device independent pixels (DIPs).</summary>
    public Size PageSize;
    /// <summary>The Rect within the page size on which content may actually be printed. Content outside of the , whether less or greater than the page size, will be cropped by the print target. The  is specified in device independent pixels (DIPs).</summary>
    public Rect ImageableRect;
    /// <summary>The resolution in dots per inch (DPI) for the X dimension of the page.</summary>
    public uint DpiX;
    /// <summary>The resolution in dots per inch (DPI) for the Y dimension of the page.</summary>
    public uint DpiY;
  }
}
