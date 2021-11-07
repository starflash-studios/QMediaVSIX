// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonValueType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Specifies the JSON value type of a JsonValue object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum JsonValueType
  {
    /// <summary>The JsonValue object is Null.</summary>
    Null,
    /// <summary>The JsonValue object is a **Boolean**.</summary>
    Boolean,
    /// <summary>The JsonValue object is a **Double**.</summary>
    Number,
    /// <summary>The JsonValue object is a **String**.</summary>
    String,
    /// <summary>The JsonValue object is an Array.</summary>
    Array,
    /// <summary>The JsonValue object is an Object.</summary>
    Object,
  }
}
