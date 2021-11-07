// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewTransferContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents information about a window drag operation.</summary>
  [Static(typeof (IApplicationViewTransferContextStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class ApplicationViewTransferContext : IApplicationViewTransferContext
  {
    /// <summary>Initializes a new instance of the ApplicationViewTransferContext class.</summary>
    [MethodImpl]
    public extern ApplicationViewTransferContext();

    /// <summary>Gets or sets the ID of the application view.</summary>
    /// <returns>The ID of the application view.</returns>
    public extern int ViewId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the format ID of the DataPackage for the drag operation.</summary>
    /// <returns>The format ID of the DataPackage for the drag operation.</returns>
    public static extern string DataPackageFormatId { [MethodImpl] get; }
  }
}
