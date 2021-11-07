// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Indicates the type of devices that the user wants to enumerate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DeviceClass
  {
    /// <summary>Indicates that the user wants to enumerate all devices.</summary>
    All,
    /// <summary>Indicates that the user wants to enumerate all audio capture devices.</summary>
    AudioCapture,
    /// <summary>Indicates that the user wants to enumerate all audio rendering devices.</summary>
    AudioRender,
    /// <summary>Indicates that the user wants to enumerate all portable storage devices.</summary>
    PortableStorageDevice,
    /// <summary>Indicates that the user wants to enumerate all video capture devices.</summary>
    VideoCapture,
    /// <summary>Indicates that the user wants to enumerate all scanning devices.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ImageScanner,
    /// <summary>Indicates that the user wants to enumerate all location aware devices.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Location,
  }
}
