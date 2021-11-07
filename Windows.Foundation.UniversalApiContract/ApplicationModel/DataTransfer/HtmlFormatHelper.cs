// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.HtmlFormatHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Responsible for formatting HTML content that you want to share or add to the Clipboard. Also allows you to get HTML fragments from the content.</summary>
  [Static(typeof (IHtmlFormatHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public static class HtmlFormatHelper
  {
    /// <summary>Gets a string that represents an HTML fragment.</summary>
    /// <param name="htmlFormat">The formatted HTML.</param>
    /// <returns>An HTML fragment based on the formatted HTML.</returns>
    [MethodImpl]
    public static extern string GetStaticFragment(string htmlFormat);

    /// <summary>Takes a string that represents HTML content and adds the necessary headers to ensure it is formatted correctly for share and Clipboard operations.</summary>
    /// <param name="htmlFragment">A string representing the HTML content.</param>
    /// <returns>A string representing the formatted HTML.</returns>
    [MethodImpl]
    public static extern string CreateHtmlFormat(string htmlFragment);
  }
}
