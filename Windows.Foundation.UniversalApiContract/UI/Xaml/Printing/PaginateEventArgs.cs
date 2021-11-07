// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.PaginateEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  /// <summary>Provides event data for the Paginate event.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PaginateEventArgs : IPaginateEventArgs
  {
    /// <summary>Initializes a new instance of the PaginateEventArgs class.</summary>
    [MethodImpl]
    public extern PaginateEventArgs();

    /// <summary>Gets the PrintTaskOptions for the pages involved in the event occurrence.</summary>
    /// <returns>An object that manages the options for print tasks.</returns>
    public extern PrintTaskOptions PrintTaskOptions { [MethodImpl] get; }

    /// <summary>Gets the 1-based page number of the current preview page.</summary>
    /// <returns>The page number.</returns>
    public extern int CurrentPreviewPageNumber { [MethodImpl] get; }
  }
}
