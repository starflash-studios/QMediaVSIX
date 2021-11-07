// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.GetPreviewPageEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  /// <summary>Provides event data for the GetPreviewPage event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class GetPreviewPageEventArgs : IGetPreviewPageEventArgs
  {
    /// <summary>Initializes a new instance of the GetPreviewPageEventArgs class.</summary>
    [MethodImpl]
    public extern GetPreviewPageEventArgs();

    /// <summary>Gets the page number of the potentially repaginated page involved in the preview.</summary>
    /// <returns>The page number of the potentially repaginated page.</returns>
    public extern int PageNumber { [MethodImpl] get; }
  }
}
