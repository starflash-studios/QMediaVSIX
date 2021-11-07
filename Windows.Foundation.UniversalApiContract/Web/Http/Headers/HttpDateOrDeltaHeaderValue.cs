// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Retry-After** HTTP header on an HTTP response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpDateOrDeltaHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpDateOrDeltaHeaderValue : IHttpDateOrDeltaHeaderValue, IStringable
  {
    /// <summary>Gets the value of the **HTTP-date** information used in the **Retry-After** HTTP header.</summary>
    /// <returns>The value of the **HTTP-date** information.</returns>
    public extern IReference<DateTime> Date { [MethodImpl] get; }

    /// <summary>Gets the value of the **delta-seconds** information used in the **Retry-After** HTTP header.</summary>
    /// <returns>The value of the **delta-seconds** information.</returns>
    public extern IReference<TimeSpan> Delta { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpDateOrDeltaHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpDateOrDeltaHeaderValue instance.</summary>
    /// <param name="input">A string that represents the **HTTP-date** or **delta-seconds** information in the **Retry-After** HTTP header.</param>
    /// <returns>An HttpDateOrDeltaHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpDateOrDeltaHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpDateOrDeltaHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="dateOrDeltaHeaderValue">The HttpDateOrDeltaHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpDateOrDeltaHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue);
  }
}
