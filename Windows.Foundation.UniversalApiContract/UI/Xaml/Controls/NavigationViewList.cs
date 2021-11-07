// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that displays menu items in a NavigationView control.</summary>
  [Composable(typeof (INavigationViewListFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class NavigationViewList : ListView, INavigationViewList
  {
    /// <summary>Initializes a new instance of the NavigationViewList class.</summary>
    [MethodImpl]
    public extern NavigationViewList();
  }
}
