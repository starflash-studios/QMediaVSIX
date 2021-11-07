// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityContentInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Represents the content metadata of this activity in JSON format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserActivityContentInfoStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class UserActivityContentInfo : IUserActivityContentInfo
  {
    /// <summary>Provides the **UserActivityContentInfo** in the form of a JSON string.</summary>
    /// <returns>The JSON content.</returns>
    [MethodImpl]
    public extern string ToJson();

    /// <summary>Creates a **UserActivityContentInfo** from a JSON string.</summary>
    /// <param name="value">The content to store in JSON format.</param>
    /// <returns>A **UserActivityContentInfo** that contains the JSON data.</returns>
    [MethodImpl]
    public static extern UserActivityContentInfo FromJson(string value);
  }
}
