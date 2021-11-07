// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.BindingFailedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle the DebugSettings.BindingFailed event.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">The event data.</param>
  [Guid(325785474, 21690, 16909, 161, 170, 130, 130, 135, 33, 205, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void BindingFailedEventHandler(object sender, BindingFailedEventArgs e);
}
