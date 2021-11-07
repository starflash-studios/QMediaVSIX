// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.PropertyChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Represents the method that will handle the PropertyChanged event. When programming with Microsoft .NET this delegate is hidden, use the System.ComponentModel.PropertyChangedEventHandler delegate.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">Event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1358011414, 2594, 19854, 160, 137, 30, 169, 149, 22, 87, 210)]
  [WebHostHidden]
  public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
}
