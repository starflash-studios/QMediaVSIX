// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.ShareWindowCommandSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IShareWindowCommandSourceStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ShareWindowCommandSource : IShareWindowCommandSource
  {
    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void ReportCommandChanged();

    public extern event TypedEventHandler<ShareWindowCommandSource, ShareWindowCommandEventArgs> CommandRequested;

    public extern event TypedEventHandler<ShareWindowCommandSource, ShareWindowCommandEventArgs> CommandInvoked;

    [MethodImpl]
    public static extern ShareWindowCommandSource GetForCurrentView();
  }
}
