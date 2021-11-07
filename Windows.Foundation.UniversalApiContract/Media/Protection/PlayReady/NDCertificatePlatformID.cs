// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCertificatePlatformID
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the client platforms with which a PlayReady-ND certificate can be associated.</summary>
  /// <deprecated type="deprecate">NDCertificatePlatformID is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("NDCertificatePlatformID is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NDCertificatePlatformID
  {
    /// <summary>Client platform is Microsoft Windows.</summary>
    Windows = 0,
    /// <summary>Client platform is the Apple OSX operating system.</summary>
    OSX = 1,
    /// <summary>Client platform is the Microsoft Windows Phone 7 operating system running on an ARM processor.</summary>
    WindowsOnARM = 2,
    /// <summary>Client platform is the Microsoft Windows Phone 7 operating system.</summary>
    WindowsMobile7 = 5,
    /// <summary>Client platform is the Apple iOS operating system running on an ARM processor.</summary>
    iOSOnARM = 6,
    /// <summary>Client platform is the Xbox operating system running on a Power PC processor.</summary>
    XBoxOnPPC = 7,
    /// <summary>Client platform is the Microsoft Windows Phone 8 operating system running on an ARM processor.</summary>
    WindowsPhone8OnARM = 8,
    /// <summary>Client platform is the Microsoft Windows Phone 8 operating system running on an x86 processor.</summary>
    WindowsPhone8OnX86 = 9,
    /// <summary>Client platform is the Xbox operating system.</summary>
    XboxOne = 10, // 0x0000000A
    /// <summary>Client platform is the Google Android operating system running on an ARM processor.</summary>
    AndroidOnARM = 11, // 0x0000000B
    /// <summary>Client platform is the Microsoft Windows Phone 8.1 operating system running on an ARM processor.</summary>
    WindowsPhone81OnARM = 12, // 0x0000000C
    /// <summary>Client platform is the Microsoft Windows Phone 8.1 operating system running on an x86 processor.</summary>
    WindowsPhone81OnX86 = 13, // 0x0000000D
  }
}
