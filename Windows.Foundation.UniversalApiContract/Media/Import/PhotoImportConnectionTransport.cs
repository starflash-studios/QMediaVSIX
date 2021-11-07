// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportConnectionTransport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the connection transport used for photo import.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportConnectionTransport
  {
    /// <summary>The connection transport is unknown.</summary>
    Unknown,
    /// <summary>The connection transport is USB.</summary>
    Usb,
    /// <summary>The connection transport is Internet Protocol.</summary>
    IP,
    /// <summary>The connection transport is Bluetooth.</summary>
    Bluetooth,
  }
}
