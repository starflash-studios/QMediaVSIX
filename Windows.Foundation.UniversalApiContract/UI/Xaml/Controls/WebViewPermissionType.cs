// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewPermissionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants the specify the type of permission requested in a WebView.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum WebViewPermissionType
  {
    /// <summary>Permission is for geolocation.</summary>
    Geolocation,
    /// <summary>Permission is for unlimited **IndexedDB** data storage.</summary>
    UnlimitedIndexedDBQuota,
    /// <summary>Permission is for media.</summary>
    Media,
    /// <summary>Permission is for pointer lock.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] PointerLock,
    /// <summary>Permission is for web notifications.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] WebNotifications,
    /// <summary>Permission is for screen capture.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Screen,
    /// <summary>Permission is for immersive view (WebVR).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] ImmersiveView,
  }
}
