// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Represents an error encountered while parsing JSON data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IJsonErrorStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public static class JsonError
  {
    /// <summary>Gets the specific error using the returned **HRESULT** value. Possible values are defined by JsonErrorStatus.</summary>
    /// <param name="hresult">An **HRESULT** returned during the operation.</param>
    /// <returns>The error encountered.</returns>
    [MethodImpl]
    public static extern JsonErrorStatus GetJsonStatus(int hresult);
  }
}
