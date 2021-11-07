// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.VisualElementsRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>A deferral object used during the creation of the **Pin to Start**  flyout. By using this object, the app can delay the display of the flyout while it gathers the information and assets that will be shown in that flyout.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VisualElementsRequestDeferral : IVisualElementsRequestDeferral
  {
    /// <summary>Tells Windows that the app is ready to display the **Pin to Start**  flyout. The app calls this method when it has finished setting the properties that specify what to show in that flyout.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
