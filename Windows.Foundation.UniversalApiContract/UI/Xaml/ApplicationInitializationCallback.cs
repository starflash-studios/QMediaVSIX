// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ApplicationInitializationCallback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the callback that should be invoked during the initialization sequence.</summary>
  /// <param name="p">Parameters that convey information for custom startup initialization.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3056933973, 49796, 18148, 131, 16, 251, 9, 103, 250, 183, 111)]
  public delegate void ApplicationInitializationCallback(ApplicationInitializationCallbackParams p);
}
