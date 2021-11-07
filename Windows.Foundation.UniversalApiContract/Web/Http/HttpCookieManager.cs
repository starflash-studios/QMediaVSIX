// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookieManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Add or delete an HttpCookie or view the cookies associated with an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpCookieManager : IHttpCookieManager
  {
    /// <summary>Add or change an HttpCookie in the cookies associated with an app that is sent on future requests.</summary>
    /// <param name="cookie">The HttpCookie to change or add.</param>
    /// <returns>**true** if the HttpCookie replaced an existing cookie; otherwise **false**.</returns>
    [Overload("SetCookie")]
    [MethodImpl]
    public extern bool SetCookie(HttpCookie cookie);

    /// <summary>Add or change an HttpCookie in the cookies associated with an app.</summary>
    /// <param name="cookie">The HttpCookie to change or add.</param>
    /// <param name="thirdParty">A value that indicates whether the HttpCookie is a third party HTTP cookie.</param>
    /// <returns>**true** if the HttpCookie replaced an existing cookie; otherwise **false**.</returns>
    [Overload("SetCookieWithThirdParty")]
    [MethodImpl]
    public extern bool SetCookie(HttpCookie cookie, bool thirdParty);

    /// <summary>Delete an HttpCookie from the cookies associated with an app.</summary>
    /// <param name="cookie">The HttpCookie to delete.</param>
    [MethodImpl]
    public extern void DeleteCookie(HttpCookie cookie);

    [MethodImpl]
    public extern HttpCookieCollection GetCookies(Uri uri);
  }
}
