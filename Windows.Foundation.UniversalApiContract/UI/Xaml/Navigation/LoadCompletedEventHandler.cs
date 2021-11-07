// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.LoadCompletedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Represents the method that will handle the LoadCompleted event.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">The event data.</param>
  [Guid(2931488645, 17404, 20012, 149, 195, 151, 174, 132, 234, 188, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void LoadCompletedEventHandler(object sender, NavigationEventArgs e);
}
