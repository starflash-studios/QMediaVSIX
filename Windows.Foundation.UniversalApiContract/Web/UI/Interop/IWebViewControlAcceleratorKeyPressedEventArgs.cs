// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.IWebViewControlAcceleratorKeyPressedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.Web.UI.Interop
{
  [ExclusiveTo(typeof (WebViewControlAcceleratorKeyPressedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2007147838, 31860, 17277, 162, 144, 58, 192, 216, 205, 86, 85)]
  internal interface IWebViewControlAcceleratorKeyPressedEventArgs
  {
    CoreAcceleratorKeyEventType EventType { get; }

    VirtualKey VirtualKey { get; }

    CorePhysicalKeyStatus KeyStatus { get; }

    WebViewControlAcceleratorKeyRoutingStage RoutingStage { get; }

    bool Handled { get; set; }
  }
}
