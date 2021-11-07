// Decompiled with JetBrains decompiler
// Type: Windows.System.LaunchQuerySupportType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the type of activation to query for.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LaunchQuerySupportType
  {
    /// <summary>Activate by URI but do not return a result to the calling app. This is the default.</summary>
    Uri,
    /// <summary>Activate by URI and return a result to the calling app.</summary>
    UriForResults,
  }
}
