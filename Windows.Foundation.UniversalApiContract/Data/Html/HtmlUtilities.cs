// Decompiled with JetBrains decompiler
// Type: Windows.Data.Html.HtmlUtilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Html
{
  /// <summary>Provides utility methods for use with HTML-formatted data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHtmlUtilities), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public static class HtmlUtilities
  {
    /// <summary>Converts HTML-formatted data to a string that contains the text content extracted from the HTML.</summary>
    /// <param name="html">A String containing HTML-formatted data.</param>
    /// <returns>A String of text content.</returns>
    [MethodImpl]
    public static extern string ConvertToText(string html);
  }
}
