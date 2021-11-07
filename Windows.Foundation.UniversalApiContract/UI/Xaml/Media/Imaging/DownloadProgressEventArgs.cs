// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.DownloadProgressEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides event data for the DownloadProgress event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class DownloadProgressEventArgs : IDownloadProgressEventArgs
  {
    /// <summary>Gets download progress as a value that is between 0 and 100.</summary>
    /// <returns>The download progress. A value of 0 indicates no progress; 100 indicates that the download is complete.</returns>
    public extern int Progress { [MethodImpl] get; [MethodImpl] set; }
  }
}
