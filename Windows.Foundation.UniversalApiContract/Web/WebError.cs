// Decompiled with JetBrains decompiler
// Type: Windows.Web.WebError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web
{
  /// <summary>Provides error status resulting from a web service operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IWebErrorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class WebError
  {
    /// <summary>Gets a WebErrorStatus value based on an error encountered by a web service operation.</summary>
    /// <param name="hresult">The error encountered by a web service operation represented as an **hResult**.</param>
    /// <returns>The error status value for a web service operation.</returns>
    [MethodImpl]
    public static extern WebErrorStatus GetStatus(int hresult);
  }
}
