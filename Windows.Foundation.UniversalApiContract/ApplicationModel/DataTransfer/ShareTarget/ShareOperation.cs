// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  /// <summary>Handles the bulk of the work during a share operation. This includes the data that the user wants to share, setting or removing QuickLinks, and informing the system about the status of the operation.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ShareOperation : IShareOperation, IShareOperation2, IShareOperation3
  {
    /// <summary>Contains a DataPackage object with the data that the user wants to share.</summary>
    /// <returns>Contains the data that the user wants to share.</returns>
    public extern DataPackageView Data { [MethodImpl] get; }

    /// <summary>A string that contains the ID of a QuickLink.</summary>
    /// <returns>The ID of the QuickLink.</returns>
    public extern string QuickLinkId { [MethodImpl] get; }

    /// <summary>Removes the QuickLink from the list of QuickLinks that are available to the user.</summary>
    [MethodImpl]
    public extern void RemoveThisQuickLink();

    /// <summary>Specifies that the app has started to acquire the content that the user wants to share.</summary>
    [MethodImpl]
    public extern void ReportStarted();

    /// <summary>Specifies that the app has acquired the content that the user wants to share.</summary>
    [MethodImpl]
    public extern void ReportDataRetrieved();

    /// <summary>Specifies that the app has requested that the system allow the sharing operation to run as a background task.</summary>
    [MethodImpl]
    public extern void ReportSubmittedBackgroundTask();

    /// <summary>Specifies that the sharing operation is complete. A QuickLink that the system can save as a shortcut for future sharing operations is included.</summary>
    /// <param name="quicklink">A QuickLink object that the system saves as a shortcut for future sharing operations.</param>
    [Overload("ReportCompletedWithQuickLink")]
    [MethodImpl]
    public extern void ReportCompleted(QuickLink quicklink);

    /// <summary>Specifies that the sharing operation is complete.</summary>
    [Overload("ReportCompleted")]
    [MethodImpl]
    public extern void ReportCompleted();

    /// <summary>Specifies that an error occurred during the sharing operation.</summary>
    /// <param name="value">Specifies the error message. The system displays this message to the user.</param>
    [MethodImpl]
    public extern void ReportError(string value);

    /// <summary>Closes the share pane.</summary>
    [MethodImpl]
    public extern void DismissUI();

    /// <summary>Gets the contacts for the share operation.</summary>
    /// <returns>The contacts for the share operation.</returns>
    public extern IVectorView<Contact> Contacts { [MethodImpl] get; }
  }
}
