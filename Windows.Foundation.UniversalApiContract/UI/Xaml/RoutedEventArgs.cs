// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.RoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Contains state information and event data associated with a routed event.</summary>
  [Composable(typeof (IRoutedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class RoutedEventArgs : IRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the RoutedEventArgs class.</summary>
    [MethodImpl]
    public extern RoutedEventArgs();

    /// <summary>Gets a reference to the object that raised the event. This is often a template part of a control rather than an element that was declared in your app UI.</summary>
    /// <returns>The object that raised the event.</returns>
    public extern object OriginalSource { [MethodImpl] get; }
  }
}
