// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookieCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Provides a collection container for instances of the HttpCookie class.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpCookieCollection : IVectorView<HttpCookie>, IIterable<HttpCookie>
  {
    [MethodImpl]
    public extern HttpCookie GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(HttpCookie value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpCookie[] items);

    [MethodImpl]
    public extern IIterator<HttpCookie> First();
  }
}
