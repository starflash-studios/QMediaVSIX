// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the method that handles the KeyUp and KeyDown  events.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2086916837, 31246, 19986, 185, 106, 119, 21, 170, 111, 241, 200)]
  [WebHostHidden]
  public delegate void KeyEventHandler(object sender, KeyRoutedEventArgs e);
}
