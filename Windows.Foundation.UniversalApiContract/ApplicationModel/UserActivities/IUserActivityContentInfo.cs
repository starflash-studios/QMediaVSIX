// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityContentInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Represents the content metadata of this activity in JSON format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3013207469, 4991, 16541, 130, 45, 225, 175, 39, 206, 8, 220)]
  public interface IUserActivityContentInfo
  {
    /// <summary>Provide the **UserActivityContentInfo** in the form of a JSON string.</summary>
    /// <returns>The JSON content.</returns>
    string ToJson();
  }
}
