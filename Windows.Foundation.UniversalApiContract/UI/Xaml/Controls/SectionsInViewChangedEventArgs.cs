// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the Hub.SectionsInViewChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISectionsInViewChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class SectionsInViewChangedEventArgs : ISectionsInViewChangedEventArgs
  {
    /// <summary>Gets a collection that contains the hub sections that moved into view.</summary>
    /// <returns>A collection that contains the hub sections that moved into view.</returns>
    public extern IVector<HubSection> AddedSections { [MethodImpl] get; }

    /// <summary>Gets a collection that contains the hub sections that moved out of view.</summary>
    /// <returns>A collection that contains the hub sections that moved into view.</returns>
    public extern IVector<HubSection> RemovedSections { [MethodImpl] get; }
  }
}
