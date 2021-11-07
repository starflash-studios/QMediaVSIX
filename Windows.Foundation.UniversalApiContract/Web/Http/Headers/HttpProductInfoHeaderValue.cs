// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpProductInfoHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents product information used in the **User-Agent** HTTP header on an HTTP request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpProductInfoHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHttpProductInfoHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpProductInfoHeaderValue : IHttpProductInfoHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpProductInfoHeaderValue class with a product comment.</summary>
    /// <param name="productComment">The product comment used in the **User-Agent** HTTP header.</param>
    [MethodImpl]
    public extern HttpProductInfoHeaderValue(string productComment);

    /// <summary>Initializes a new instance of the HttpProductInfoHeaderValue class with a product name and version.</summary>
    /// <param name="productName">The name of the product token used in the **User-Agent** HTTP header.</param>
    /// <param name="productVersion">The version of the product token used in the **User-Agent** HTTP header.</param>
    [MethodImpl]
    public extern HttpProductInfoHeaderValue(string productName, string productVersion);

    /// <summary>Gets the product from the HttpProductInfoHeaderValue used in the **User-Agent** HTTP header.</summary>
    /// <returns>The product name and version used in the **User-Agent** HTTP header.</returns>
    public extern HttpProductHeaderValue Product { [MethodImpl] get; }

    /// <summary>Gets the product comment from the HttpProductInfoHeaderValue used in the **User-Agent** HTTP header.</summary>
    /// <returns>The product comment used in the **User-Agent** HTTP header.</returns>
    public extern string Comment { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpProductInfoHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpProductInfoHeaderValue instance.</summary>
    /// <param name="input">A string that represents the product information.</param>
    /// <returns>An HttpProductInfoHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpProductInfoHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpProductInfoHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="productInfoHeaderValue">The HttpProductInfoHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpProductInfoHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpProductInfoHeaderValue productInfoHeaderValue);
  }
}
