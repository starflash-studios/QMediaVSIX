// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.PickerLocationId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  /// <summary>Identifies the storage location that the file picker presents to the user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PickerLocationId
  {
    /// <summary>The **Documents** library.</summary>
    DocumentsLibrary,
    /// <summary>The **Computer** folder.</summary>
    ComputerFolder,
    /// <summary>The Windows desktop.</summary>
    Desktop,
    /// <summary>The **Downloads** folder.</summary>
    Downloads,
    /// <summary>The HomeGroup.</summary>
    HomeGroup,
    /// <summary>The **Music** library.</summary>
    MusicLibrary,
    /// <summary>The **Pictures** library.</summary>
    PicturesLibrary,
    /// <summary>The **Videos** library.</summary>
    VideosLibrary,
    /// <summary>The **Objects** library.</summary>
    Objects3D,
    /// <summary>An unspecified location.</summary>
    Unspecified,
  }
}
