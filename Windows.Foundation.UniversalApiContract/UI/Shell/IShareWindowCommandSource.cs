// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.IShareWindowCommandSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [Guid(3409672931, 27548, 22046, 188, 204, 97, 230, 142, 10, 191, 239)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (ShareWindowCommandSource))]
  internal interface IShareWindowCommandSource
  {
    void Start();

    void Stop();

    void ReportCommandChanged();

    event TypedEventHandler<ShareWindowCommandSource, ShareWindowCommandEventArgs> CommandRequested;

    event TypedEventHandler<ShareWindowCommandSource, ShareWindowCommandEventArgs> CommandInvoked;
  }
}
