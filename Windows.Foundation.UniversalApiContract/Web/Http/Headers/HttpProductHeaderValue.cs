// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpProductHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents product information used by the HttpProductHeaderValue and HttpProductInfoHeaderValueCollection classes in the **User-Agent** HTTP header.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpProductHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHttpProductHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpProductHeaderValue : IHttpProductHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpProductHeaderValue class with a product name.</summary>
    /// <param name="productName">The name of the product token used in the **User-Agent** HTTP header.</param>
    [MethodImpl]
    public extern HttpProductHeaderValue(string productName);

    /// <summary>Initializes a new instance of the HttpProductHeaderValue class with a product name and a product version.</summary>
    /// <param name="productName">The name of the product token used in the **User-Agent** HTTP header.</param>
    /// <param name="productVersion">The version of the product token used in the **User-Agent** HTTP header.</param>
    [MethodImpl]
    public extern HttpProductHeaderValue(string productName, string productVersion);

    /// <summary>Gets a token that represents the name of the product to be used in the **User-Agent** HTTP header.</summary>
    /// <returns>The name of the product token</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets a token that represents the version of the product to be used in the **User-Agent** HTTP header.</summary>
    /// <returns>The version of the product token.</returns>
    public extern string Version { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpProductHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpProductHeaderValue instance.</summary>
    /// <param name="input">A string that represents the product name and version.</param>
    /// <returns>An HttpProductHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpProductHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpProductHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="productHeaderValue">The HttpProductHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpProductHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(string input, out HttpProductHeaderValue productHeaderValue);
  }
}
