// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragOperationDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Enables you to drag-and-drop content with a target app asynchronously.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class DragOperationDeferral : IDragOperationDeferral
  {
    /// <summary>Indicates that the content for an asynchronous drag-and-drop operation is ready for a target app.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
