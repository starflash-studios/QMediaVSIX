// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.VisualElementsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Passed to the SecondaryTile.VisualElementsRequested event handler to provide the visual elements details.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VisualElementsRequestedEventArgs : IVisualElementsRequestedEventArgs
  {
    /// <summary>Gets the VisualElementsRequest object for the event.</summary>
    /// <returns>The object associated with the event.</returns>
    public extern VisualElementsRequest Request { [MethodImpl] get; }
  }
}
