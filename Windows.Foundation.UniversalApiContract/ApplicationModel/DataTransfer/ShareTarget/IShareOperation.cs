// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [Guid(575060664, 53496, 16833, 168, 42, 65, 55, 219, 101, 4, 251)]
  [ExclusiveTo(typeof (ShareOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IShareOperation
  {
    DataPackageView Data { get; }

    string QuickLinkId { get; }

    void RemoveThisQuickLink();

    void ReportStarted();

    void ReportDataRetrieved();

    void ReportSubmittedBackgroundTask();

    [Overload("ReportCompletedWithQuickLink")]
    void ReportCompleted(QuickLink quicklink);

    [Overload("ReportCompleted")]
    void ReportCompleted();

    void ReportError(string value);
  }
}
