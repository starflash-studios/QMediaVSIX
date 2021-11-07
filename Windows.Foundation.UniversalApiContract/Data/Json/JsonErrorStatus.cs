// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Defines errors encountered while parsing JSON data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum JsonErrorStatus
  {
    /// <summary>An unknown error occurred.</summary>
    Unknown,
    /// <summary>The string is invalid. It is possible the expressed value type of the JSON encapsulated data type does not match what is defined by JsonValueType.</summary>
    InvalidJsonString,
    /// <summary>The number is invalid. It is possible the expressed value type of the JSON encapsulated data type does not match what is defined by JsonValueType.</summary>
    InvalidJsonNumber,
    /// <summary>The specified JsonValue cannot be found.</summary>
    JsonValueNotFound,
    /// <summary>This operation exceeds the internal limit of 1024 nested JSON objects.</summary>
    ImplementationLimit,
  }
}
